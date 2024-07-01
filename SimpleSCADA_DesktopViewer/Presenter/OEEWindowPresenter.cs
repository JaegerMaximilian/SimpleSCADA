using SimpleSCADA_SharedResources;
using SimpleSCADA_DesktopViewer.Presenter.TopSigried;
using Syncfusion.Windows.Forms.Chart;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class OEEWindowPresenter
    {
        public event EventHandler<OEE> LoadOEE;
        #region Methods
        //Models
        private OEEManager _OEEManager;

        //View
        private OEEView _OEEView;

        #endregion

        #region Constructor and Events

        public OEEWindowPresenter()
        {
            _OEEManager = new OEEManager();
            _OEEView = new OEEView();
            
            SetUpLinks();
        }

        #endregion

        #region Methods

        private void SetUpLinks()
        {
            _OEEView.UpdateView += UpdateView;
        }

        public void OpenWindow(object sender, EventArgs e)
        {
            _OEEView.Show();
            UpdateView(this, EventArgs.Empty);
        }

        private void UpdateView(object sender, EventArgs e)
        {
            try
            {
                // latest quality rate gauge
                OEE oeefromDB = _OEEManager.GetLatestOEE();
                if (oeefromDB == null)
                {
                    return;
                }
                _OEEView.radialGauge1.Value = float.Parse(oeefromDB.QualityRate.ToString());

                // last week quality rate bar chart
                List<OEE> oeeList = _OEEManager.GetOEEfromWeek();
                ChartSeries series1 = new ChartSeries();
                series1.Name = "Leistungseffizienz";
                series1.Type = ChartSeriesType.Column;
                series1.Text = series1.Name;
                int i = 7;
                foreach (OEE item in oeeList)
                {
                    series1.Points.Add(i + "-" + item.Date.ToString("ddd"), item.Leistungseffizienz);
                    i--;
                }
                _OEEView.chartControl1.Series.Clear();
                _OEEView.chartControl1.Series.Add(series1);

                // last week avg digital gauge
                _OEEView.digitalGauge1.Value = _OEEManager.CalculateOEE().ToString();
            }
            catch
            {
                return;
            }
        }
        #endregion
    }
}
