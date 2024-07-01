using SimpleSCADA_DesktopViewer.Presenter;
using SimpleSCADA_DesktopViewer.Control_f;
using SimpleSCADA_DesktopViewer.PlantSatus;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            PlantManager plantManager = new PlantManager();
            Plant plant = plantManager.GetPlant();
            plant.requestedPlantState = PlantState.IDLE;
            plant.ActualPlantState = PlantState.IDLE;
            plantManager.EditPlant(plant);

                                        MachineListener machineListener = new MachineListener();

            Task subscribeToNodes = Task.Run(() => machineListener.SubscribeNodes());

            //Task.Run(() => machineListener.SubscribeNodes());

            ConveyorbeltControl conveyorbeltControl = new ConveyorbeltControl();

            Task converyorBeltControlTask = Task.Run(() => conveyorbeltControl.ExecutePlant());

            MainWindowPresenter presenter = new MainWindowPresenter();
            presenter.Run();


            
        }
    }
}