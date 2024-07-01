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
    public partial class ErrorView : Form
    {
        //Variables
        bool isMouseDown;
        Point lastLocation;

        #region Events
        public event EventHandler LoadErrorsRequested;
        #endregion

        public ErrorView()
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
            LoadErrorsRequested?.Invoke(this, EventArgs.Empty);
        }

        public void LoadDataInList(List<Error> errors)
        {

            ErrorListView.Items.Clear();


            int i = 0;
            foreach (var error in errors)
            {
                ListViewItem item = new ListViewItem(error.Id.ToString(), i);
                item.SubItems.Add(error.Description);
                item.SubItems.Add(error.ErrorType.ToString());
                item.SubItems.Add(error.Severity.ToString());
                if (error.Log != null)
                {
                    item.SubItems.Add(error.Log.Description);
                    item.SubItems.Add(error.Log.PlantState.ToString());
                }
                else
                {
                    item.SubItems.Add("-");
                    item.SubItems.Add("-");
                }

                item.SubItems.Add(error.TimeOfOccurence.ToString());
                item.SubItems.Add(error.TimeWhenFixed.ToString());

                i++;


                ErrorListView.Items.Add(item);
            }
        }
    }
}
