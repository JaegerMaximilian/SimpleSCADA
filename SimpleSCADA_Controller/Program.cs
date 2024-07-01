using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SimpleSCADA_Controller.Control;
using SimpleSCADA_SharedResources;
using System.Threading.Tasks;

namespace SimpleSCADA_Controller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MachineListener machineListener = new MachineListener();
          
            Task subscribeToNodes = Task.Run(() => machineListener.SubscribeNodes());

            //Task.Run(() => machineListener.SubscribeNodes());

            ConveyorbeltControl conveyorbeltControl = new ConveyorbeltControl();

            Task converyorBeltControlTask = Task.Run(() => conveyorbeltControl.ExecutePlant());

            Console.ReadKey();
        }
    }
}