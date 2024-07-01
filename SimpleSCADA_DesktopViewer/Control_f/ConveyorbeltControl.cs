using Microsoft.IdentityModel.Tokens;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SimpleSCADA_SharedResources;
using static System.Collections.Specialized.BitVector32;
using Syncfusion.Windows.Forms.Chart;

namespace SimpleSCADA_DesktopViewer.Control_f
{
    public class ConveyorbeltControl
    {
        int _ControlVar;
        Transitions _Transitions;
        SimpleSCADA_SharedResources.Recipe _CurrentRecipe;
        SimpleSCADA_SharedResources.Plant _Plant;
        SimpleSCADA_SharedResources.Plant _NewPlant;
        SimpleSCADA_SharedResources.PlantManager _PlantManager;
        SimpleSCADA_SharedResources.ProductionCycle _CurrentProductionCycle;
        SimpleSCADA_SharedResources.Error _Error;
        SimpleSCADA_SharedResources.Log _Log;
        Task _Task;
        CancellationTokenSource _CancellationTokenSource;
        CancellationToken _CancellationToken;
        static ManualResetEvent _PauseEvent = new ManualResetEvent(true);


        public ConveyorbeltControl()
        {
            this._Transitions = new Transitions();
            this._CurrentRecipe = new SimpleSCADA_SharedResources.Recipe();
            this._NewPlant = new SimpleSCADA_SharedResources.Plant();
            this._PlantManager = new SimpleSCADA_SharedResources.PlantManager();
            this._ControlVar = 0;
        }


        public async Task ExecutePlant()
        {
            _Plant = new Plant();
            _Plant = _PlantManager.GetPlant();
            _CancellationTokenSource = new CancellationTokenSource();
            _CancellationToken = _CancellationTokenSource.Token;


            while (true)
            {
                _NewPlant = new Plant();
                _NewPlant = _PlantManager.GetPlant();

                if (_NewPlant.requestedPlantState == _Plant.requestedPlantState)
                {
                    Thread.Sleep(1000);
                    continue;
                }

                _Plant = new Plant();
                _Plant = _NewPlant;

                bool abortCondition = false;

                switch (_Plant.requestedPlantState)
                {

                    case PlantState.RUNNING:
                        update_DB_tblPlant_state(PlantState.RUNNING);
                        if (_ControlVar > 0) { _PauseEvent.Set(); break; }
                        _Task = Task.Run(() =>
                        {
                           try
                            {
                                // Your function code here
                                _ControlVar++;
                                runPlant();
                            }
                            catch (Exception ex)
                            {
                                if (ex.ToString().Substring(0, 3) == "Opc")
                                {
                                    _Error = new Error("No connection to OPCUA-Server",ErrorType.OPC_UA,ErrorSeverity.SHITTY,DateTime.Now);
                                    ErrorManager.AddError(_Error);                         
                                }
                            }
                        }, _CancellationToken);

                        break;

                    case PlantState.STOP:
                        update_DB_tblPlant_state(PlantState.STOP);
                        _CancellationTokenSource.Cancel();
                        _ControlVar = 0;
                        break;

                    case PlantState.PAUSED:
                        update_DB_tblPlant_state(PlantState.PAUSED);
                        _PauseEvent.Reset();
                        break;

                    case PlantState.IDLE:
                        update_DB_tblPlant_state(PlantState.IDLE);
                        //chillex
                        break;

                    case PlantState.FINISHED:
                        update_DB_tblPlant_state(PlantState.FINISHED);
                        _ControlVar = 0;
                        break;

                    case PlantState.MAINTENANCE:
                        update_DB_tblPlant_state(PlantState.MAINTENANCE);
                        _PauseEvent.Reset();
                        break;

                    default:
                        abortCondition = true;
                        break;

                }

                if (abortCondition)
                {

                    Console.WriteLine("Coveyorbelt control is off now");

                    Console.ReadLine();
                    break;
                }

                Thread.Sleep(1000);
            }

        }

       private void update_DB_tblPlant_state(PlantState plantState)
        {
            _Plant.ActualPlantState = plantState;

            _PlantManager.EditPlant(_Plant);

        }


        private async Task runPlantAsync()
        {
            //Initialize vars

            _CurrentProductionCycle = _Plant.ActiveProductionCycle;
            _CurrentRecipe = _CurrentProductionCycle.Recipe;

            List<StationWithChosenUtility> neededStationsWithUtility = _PlantManager.GetOrderedStationsToDrive(_Plant);

            //get parameter for process

            int cycles = _CurrentProductionCycle.NumberOfProducts;

            List<int> stationOrder = new List<int>();

            foreach (StationWithChosenUtility curStatition in neededStationsWithUtility)
            {
                stationOrder.Add(int.Parse(curStatition.Station.Name.Remove(0, 8)));
            }

            //Execute production cycle

            for (int count = 0; count < cycles; count++)
            {
                int previousGoal = default;
                int i = 0;

                foreach (int Goal in stationOrder)
                {

                    if (i == stationOrder.Count - 1) //ending logik
                    {
                        await Task.Run(() => _Transitions.RouteAsync(new int[] { previousGoal, Goal }, _CancellationToken), _CancellationToken);
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        await Task.Run(() => _Transitions.RouteAsync(new int[] { Goal, 0 }, _CancellationToken), _CancellationToken);
                        continue;

                    }

                    if (i == 0) //starting logik
                    {
                        await Task.Run(() => _Transitions.RouteAsync(new int[] { 0, Goal }, _CancellationToken), _CancellationToken);
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        previousGoal = Goal;
                        i++;
                        continue;
                    }

                    await Task.Run(() => _Transitions.RouteAsync(new int[] { previousGoal, Goal }, _CancellationToken), _CancellationToken);

                    Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);

                    previousGoal = Goal;
                    i++;
                }

                _Plant.ActiveProductionCycle.FinishedProducts++;
                _PlantManager.EditPlant(_Plant);
            }


        } //Not used for now


        private void runPlant()
        {
            //Initialize vars

            _CurrentProductionCycle = _Plant.ActiveProductionCycle;
            _CurrentRecipe = _CurrentProductionCycle.Recipe;

            List<StationWithChosenUtility> neededStationsWithUtility = _PlantManager.GetOrderedStationsToDrive(_Plant);

            //get parameter for process

            int cycles = _CurrentProductionCycle.NumberOfProducts;

            List<int> stationOrder = new List<int>();

            foreach (StationWithChosenUtility curStatition in neededStationsWithUtility)
            {
                stationOrder.Add(int.Parse(curStatition.Station.Name.Remove(0, 8)));
            }

            //Execute production cycle

            for (int count = 0; count < cycles; count++)
            {
                int previousGoal = default;
                int i = 0;

                foreach (int Goal in stationOrder)
                {

                    if (i == stationOrder.Count - 1) //ending logik
                    {
                        Console.WriteLine("Going from " + previousGoal.ToString() +" to "+ Goal.ToString());
                        _Transitions.Route(new int[] { previousGoal, Goal });
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        Console.WriteLine("Going from " + Goal.ToString() + " to Startpoint") ;
                        _Transitions.Route(new int[] { Goal, 0 });
                        continue;

                    }

                    if (i == 0) //starting logik
                    {
                        Console.WriteLine("Going from " +  "Startpoint to " + Goal.ToString());
                        _Transitions.Route(new int[] { 0, Goal });
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        previousGoal = Goal;
                        i++;
                        continue;
                    }

                    Console.WriteLine("Going from " + previousGoal.ToString() + " to " + Goal.ToString());
                    _Transitions.Route(new int[] { previousGoal, Goal });

                    Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);

                    previousGoal = Goal;
                    i++;

                    _NewPlant = new Plant();
                    _NewPlant = _PlantManager.GetPlant();

                    if (_NewPlant.requestedPlantState == PlantState.PAUSED || _NewPlant.requestedPlantState == PlantState.MAINTENANCE)
                    {
                        _PauseEvent.WaitOne();
                    }

                    if (_NewPlant.requestedPlantState == PlantState.STOP)
                    {
                        break;
                    }

                }

                if (_NewPlant.requestedPlantState == PlantState.STOP) 
                {
                    if (_CancellationToken.IsCancellationRequested)
                    {
                        _Error = new Error("Plant is stopped means uncertain plant situation", ErrorType.OPC_UA, ErrorSeverity.WARNING, DateTime.Now);
                        ErrorManager.AddError(_Error);
                        break;
                    }
                }
                _Plant.ActiveProductionCycle.FinishedProducts++;
                Console.WriteLine("Finished products in active cycle: "+_Plant.ActiveProductionCycle.FinishedProducts.ToString());
                _PlantManager.EditPlant(_Plant);
            }

            if (_Plant.ActiveProductionCycle.FinishedProducts == _Plant.ActiveProductionCycle.NumberOfProducts)
            {
                _Plant.ActualPlantState = PlantState.FINISHED;
            }
        }
    }
}
