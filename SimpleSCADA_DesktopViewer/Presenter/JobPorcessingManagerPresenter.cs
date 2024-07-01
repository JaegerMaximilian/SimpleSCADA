using SimpleSCADA_DesktopViewer.Views;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class JobPorcessingManagerPresenter
    {
        #region Membervariables

        //Model
        private ProductionCycleManager _productionQueue;
        
        //View
        private JobProcessingView _jobProcessingView;

        private RecipeManager _recipeManager;
        #endregion

        #region Constructor

        public JobPorcessingManagerPresenter(ProductionCycleManager productionCycleManager,RecipeManager recipeManager)
        {
            //Model nachtragen
            _jobProcessingView = new JobProcessingView();
            _productionQueue = productionCycleManager;
            _recipeManager = recipeManager;

            SetUpLinks();
        }
        #endregion

        #region Methods
        private void SetUpLinks()
        {
            _jobProcessingView.NewProductionCycle += SaveOrder;
            _jobProcessingView.EditProductionCycle += EditOrder;
            _jobProcessingView.RequestProductionCycle += GetOrder;
            _jobProcessingView.DeleteProductionCycle += DeleteOrder;
        }

        public void OpenWindow(object? sender, EventArgs e)
        {
            _jobProcessingView.Show();
            _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), null);
        }

        private void UpdateView(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
            _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), null);
        }

        private void GetOrder(object? sender, int id)
        {
            _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), _productionQueue.GetProductionCycle(id));
        }

        private void GetOrders(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
            _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), null);
        }

        private void SaveOrder(object? sender, ProductionCycle newProductionCycle)
        {
            Recipe recipe = _recipeManager.GetRecipes().SingleOrDefault(x => x.Name == newProductionCycle.Recipe.Name);

            _productionQueue.AddProductionCycle(new ProductionCycle(newProductionCycle.Customer,
                recipe.Id, newProductionCycle.NumberOfProducts));

            _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), newProductionCycle);
        }

        private void EditOrder(object? sender, ProductionCycle editProductionCycle)
        {
            Recipe recipe = _recipeManager.GetRecipes().SingleOrDefault(x => x.Name == editProductionCycle.Recipe.Name);

            _productionQueue.EditProductionCycle(new ProductionCycle(editProductionCycle.Id, editProductionCycle.Customer,
                recipe.Id, editProductionCycle.NumberOfProducts));

            _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), editProductionCycle);

        }

        private void DeleteOrder(object? sender, int id)
        {
            if (id > 0)
            {
                _productionQueue.DeleteProductionCycle(_productionQueue.GetProductionCycle(id));
                _jobProcessingView.UpdateView(_productionQueue.GetProductionQueue(), _recipeManager.GetRecipes(), null);
            }
        }
        #endregion


    }
}
