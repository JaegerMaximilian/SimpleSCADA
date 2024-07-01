using SimpleSCADA_DesktopViewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class ProductionHistoryWindowPresenter
    {
        private ProductionHistoryView _productionHistroyView;
        private ProductionCycleManager _productionCycleManager;
        private LogManager _LogManager;
        public ProductionHistoryWindowPresenter()
        {
            _productionHistroyView = new ProductionHistoryView();

            _productionCycleManager = new ProductionCycleManager();
            _LogManager = new LogManager();
            _productionHistroyView.LoadLogsAndFinishedProductsRequested += OnLoadLogsAndFinishedProductsRequested;
        }


        public void OpenWindow(object? sender, EventArgs e)
        {
            _productionHistroyView.Show();
        }

        private void OnLoadLogsAndFinishedProductsRequested(object? sender, EventArgs? e)
        {
            List<ProductionCycle> finishedProductionCycles = _productionCycleManager.GetFinishedProductionCycles();
            List<Log> allLogs = _LogManager.GetAllLogs();

            _productionHistroyView.LoadDataInList(finishedProductionCycles, allLogs);
        }
    }
}
