using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer
{
    public partial class ProductionHistoryView : Form
    {
        //Variables
        bool isMouseDown;
        Point lastLocation;

        public event EventHandler LoadLogsAndFinishedProductsRequested;

        public ProductionHistoryView()
        {
            InitializeComponent();
        }

        private void panel_move(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel_mouse_down(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void panel_mouse_up(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadLogsAndFinishedProductsRequested?.Invoke(this, EventArgs.Empty);

        }

        public void LoadDataInList(List<ProductionCycle> finishedProductionCycles, List<Log> logs)
        {

            // fill ListView of ProductionCycles

            listView_ProductionCycle.Items.Clear();
            
            int i = 0;
            foreach (var pc in finishedProductionCycles)
            {
                ListViewItem item = new ListViewItem(pc.Id.ToString(), i);
                item.SubItems.Add(pc.Customer);
                item.SubItems.Add(pc.Recipe.Name);
                item.SubItems.Add(pc.FinishedProducts.ToString());
                item.SubItems.Add(pc.EstimatedTime.ToString());

                i++;


                listView_ProductionCycle.Items.Add(item);

            }
            // fill ListView of Logs

            listView_Logs.Items.Clear();
            i = 0;
            foreach (var log in logs)
            {
                ListViewItem item2 = new ListViewItem(log.Id.ToString(), i);
                item2.SubItems.Add(log.Description);
                if (log.ProductionCycle.Id != null)
                {
                    item2.SubItems.Add(log.ProductionCycle.Id.ToString());
                }else
                {
                    item2.SubItems.Add("-");
                }
                item2.SubItems.Add(log.PlantState.ToString());
                item2.SubItems.Add(log.Starttime.ToString());

                i++;

                listView_Logs.Items.Add(item2);
            }
        }
    }
}
