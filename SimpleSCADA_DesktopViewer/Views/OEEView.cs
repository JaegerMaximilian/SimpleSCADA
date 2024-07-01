using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using Opc.Ua;
using SimpleSCADA_SharedResources;
using Syncfusion.Windows.Forms.Chart;

namespace SimpleSCADA_DesktopViewer
{
    public partial class OEEView : Form
    {
        //Variables
        bool isMouseDown;
        Point lastLocation;

        public event EventHandler UpdateView;

        public OEEView()
        {
            InitializeComponent();
        }

        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OEEView_Load(object sender, EventArgs e)
        {

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
    }
}
