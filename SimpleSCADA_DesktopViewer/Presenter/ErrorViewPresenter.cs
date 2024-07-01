using SimpleSCADA_SharedResources;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class ErrorViewPresenter
    {
        private ErrorManager _errorManager;
        private ErrorView _errorView;


        

        public ErrorViewPresenter()
        {
            _errorManager = new ErrorManager();
            _errorView = new ErrorView();

            _errorView.LoadErrorsRequested += OnLoadErrors;

        }

        public void OpenWindow(object? sender, EventArgs e)
        {
            _errorView.Show();
        }

        private void SetUpLinks()
        {
            throw new NotImplementedException();
        }

        private void OnLoadErrors(object? sender, EventArgs? e)
        {
            _errorView.LoadDataInList(_errorManager.GetAllErrors());
        }
    }
}
