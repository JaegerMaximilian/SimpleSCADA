using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSCADA_DesktopViewer.Views
{
    public partial class JokeView : Form
    {
        //Variables
        bool isMouseDown;
        Point lastLocation;

        public event EventHandler<EventArgs> SeriousButton;

        public JokeView()
        {
            InitializeComponent();
        }

        private void btn_Serious_Click(object sender, EventArgs e)
        {
            SeriousButton?.Invoke(this, EventArgs.Empty);
        }

        public void WriteJokeToTxtBox(string joke)
        {
            txt_joke.Text = joke;
        }

        private void btn_CloseRecipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            txt_joke.Text = String.Empty;
        }

        private void JokeView_Load(object sender, EventArgs e)
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
