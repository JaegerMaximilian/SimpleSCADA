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

namespace SimpleSCADA_DesktopViewer.Views
{
    public partial class JobProcessingView : Form
    {
        #region Events
        public event EventHandler<ProductionCycle> NewProductionCycle;
        public event EventHandler<ProductionCycle> EditProductionCycle;
        public event EventHandler<int> RequestProductionCycle;
        public event EventHandler<int> DeleteProductionCycle;
        #endregion

        #region Members
        //Variables
        bool isMouseDown;
        Point lastLocation;
        #endregion

        #region Constructor
        public JobProcessingView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxAuftrag.SelectedIndex == 0 || cboxAuftrag.SelectedIndex == -1 ||
                    cbFertigungsrezept.SelectedIndex == 0 || cbFertigungsrezept.SelectedIndex == -1)
                {
                    ProductionCycle newProductionCycle = new ProductionCycle(tbKunde.Text,
                        new Recipe(cbFertigungsrezept.SelectedItem.ToString()),
                        int.Parse(tbAnzahl.Text));

                    NewProductionCycle?.Invoke(this, newProductionCycle);
                }
                else if (cboxAuftrag.SelectedIndex > 0 && cbFertigungsrezept.SelectedIndex > 0)
                {
                    ProductionCycle editProductionCycle = new ProductionCycle(GetProductionCycleIdFromComboBox(),
                        tbKunde.Text,
                        new Recipe(cbFertigungsrezept.SelectedItem.ToString()),
                        int.Parse(tbAnzahl.Text));
                    EditProductionCycle?.Invoke(this, editProductionCycle);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Des hod jetzt epan ned hi ghaud!");
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            RequestProductionCycle?.Invoke(this, GetProductionCycleIdFromComboBox());
        }

        private void btn_CloseJobs_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        public void UpdateView(List<ProductionCycle> productionCycles, List<Recipe> recipes, ProductionCycle selectedProductionCycle)
        {

            #region Refresch TextBoxes

            if (selectedProductionCycle == null)
            {
                tbAuftragsname.Text = "";
                tbAuftragsnummer.Text = "";
                tbKunde.Text = "";
                tbAnzahl.Text = "";
            }
            else
            {
                tbAuftragsname.Text = $"{selectedProductionCycle.Id}, {selectedProductionCycle.Customer}";
                tbAuftragsnummer.Text = selectedProductionCycle.Id.ToString();
                tbKunde.Text = selectedProductionCycle.Customer;
                tbAnzahl.Text = selectedProductionCycle.NumberOfProducts.ToString();
            }
            #endregion

            #region Refresch ComboBoxes
            // Combobox Fertigungsrezept
            cbFertigungsrezept.Items.Clear();
            cbFertigungsrezept.Items.Add("");
            foreach (var recipe in recipes)
            {
                cbFertigungsrezept.Items.Add(recipe.Name);
            }


            // Combobox Auftrag
            cboxAuftrag.Items.Clear();
            cboxAuftrag.Items.Add("");
            foreach (var productionCycle in productionCycles)
            {
                cboxAuftrag.Items.Add($"{productionCycle.Id}, {productionCycle.Customer}");
            }

            if (selectedProductionCycle != null)
            {
                cboxAuftrag.SelectedIndex = productionCycles.FindIndex(x => x.Id == selectedProductionCycle.Id) + 1;
                cbFertigungsrezept.SelectedIndex = recipes.FindIndex(x => x.Name == selectedProductionCycle.Recipe.Name) + 1;
            }

            #endregion
        }

        private int GetProductionCycleIdFromComboBox()
        {
            if (cboxAuftrag.SelectedIndex == -1 || cboxAuftrag.SelectedIndex == 0) return 0;
            string[] ids = cboxAuftrag.SelectedItem.ToString().Split(',');
            return int.Parse(ids[0]);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteProductionCycle?.Invoke(this, GetProductionCycleIdFromComboBox());
        }
        #endregion
    }
}
