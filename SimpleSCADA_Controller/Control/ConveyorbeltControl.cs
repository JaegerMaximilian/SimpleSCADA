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


namespace SimpleSCADA_Controller.Control
{
    public class ConveyorbeltControl
    {

        Transitions _Transitions;    
        SimpleSCADA_SharedResources.Recipe _CurrentRecipe;
        SimpleSCADA_SharedResources.Plant _Plant;
        SimpleSCADA_SharedResources.Plant _NewPlant;
        SimpleSCADA_SharedResources.PlantManager _PlantManager;
        SimpleSCADA_SharedResources.ProductionCycle _CurrentProductionCycle;
        CancellationTokenSource _CancellationTokenSource;
        CancellationToken _CancellationToken;


        public ConveyorbeltControl() 
        {
            this._Transitions = new Transitions();
            this._CurrentRecipe = new SimpleSCADA_SharedResources.Recipe();
            this._NewPlant = new SimpleSCADA_SharedResources.Plant();
            this._PlantManager = new SimpleSCADA_SharedResources.PlantManager();
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
                    Thread.Sleep(5000);
                    continue;
                }

                _Plant = new Plant();
                _Plant = _NewPlant;

                bool abortCondition = false;         

                switch (_Plant.requestedPlantState)
                {

                    case PlantState.RUNNING:                    
                        update_DB_tblPlant_state(PlantState.RUNNING);                    
                        runPlant();                
                        break;

                    case PlantState.STOP:                      
                        update_DB_tblPlant_state(PlantState.STOP);
                        break;

                    case PlantState.PAUSED:
                        update_DB_tblPlant_state(PlantState.PAUSED);
                        //chillex
                        break;

                    case PlantState.IDLE:
                        update_DB_tblPlant_state(PlantState.IDLE);
                        //chillex
                        break;

                    case PlantState.FINISHED:
                        update_DB_tblPlant_state(PlantState.FINISHED);
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

                Thread.Sleep(5000);
            }

        }

        private  void update_DB_tblPlant_state(PlantState plantState)
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
                stationOrder.Add(int.Parse(curStatition.Station.Name.Remove(0,8)));
            }

            //Execute production cycle

            for (int count=0;count<cycles;count++)
            {
                int previousGoal = default;
                int i = 0;

               foreach(int Goal in stationOrder)
                {

                    if (i==stationOrder.Count-1) //ending logik
                    {
                        await Task.Run(()=>_Transitions.RouteAsync(new int[] { previousGoal, Goal },_CancellationToken),_CancellationToken);
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait*1000);
                        await Task.Run(()=>_Transitions.RouteAsync(new int[] { Goal, 0 }, _CancellationToken), _CancellationToken);
                        continue;

                    }

                    if (i==0) //starting logik
                    {
                        await Task.Run(() => _Transitions.RouteAsync(new int[] { 0, Goal },_CancellationToken), _CancellationToken);
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        previousGoal = Goal;
                        i++;
                        continue;
                    }

                    await Task.Run(() => _Transitions.RouteAsync(new int[] { previousGoal, Goal }, _CancellationToken), _CancellationToken);

                    Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait*1000);

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
                        _Transitions.Route(new int[] { previousGoal, Goal });
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        _Transitions.Route(new int[] { Goal, 0 });
                        continue;

                    }

                    if (i == 0) //starting logik
                    {
                        _Transitions.Route(new int[] { 0, Goal });
                        Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);
                        previousGoal = Goal;
                        i++;
                        continue;
                    }

                     _Transitions.Route(new int[] { previousGoal, Goal });

                    Thread.Sleep(neededStationsWithUtility[i].ChosenUtility.SecondsToWait * 1000);

                    previousGoal = Goal;
                    i++;

                    Plant newPlant = new Plant();
                    newPlant = _PlantManager.GetPlant();

                    if (newPlant.requestedPlantState != _Plant.requestedPlantState)
                    {
                        break;
                    }               
                }

                if(_NewPlant.requestedPlantState == PlantState.PAUSED || _NewPlant.requestedPlantState == PlantState.STOP) { break; }

                _Plant.ActiveProductionCycle.FinishedProducts++;
                _PlantManager.EditPlant(_Plant);
            }

            if (_Plant.ActiveProductionCycle.FinishedProducts == _Plant.ActiveProductionCycle.NumberOfProducts)
            {
                _Plant.ActualPlantState = PlantState.FINISHED;
            }
        }
    }
}
