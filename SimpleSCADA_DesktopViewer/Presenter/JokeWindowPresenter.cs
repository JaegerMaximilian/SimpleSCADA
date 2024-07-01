using SimpleSCADA_SharedResources;
using SimpleSCADA_DesktopViewer.Presenter.TopSigried;
using SimpleSCADA_DesktopViewer.Views;

namespace SimpleSCADA_DesktopViewer.Presenter
{
    internal class JokeWindowPresenter
    {
        #region Methods
        ////Models
        //private OEEManager _OEEManager;

        ////View
        //private OEEView _OEEView;
        private JokeView _jokeView;

        #endregion

        #region Constructor and Events

        public JokeWindowPresenter()
        {
            //_OEEManager = new OEEManager();
            _jokeView = new JokeView();
            
            SetUpLinks();
        }

        #endregion

        #region Methods

        private void SetUpLinks()
        {
            _jokeView.SeriousButton += GetJoke;
        }

        public void OpenWindow(object sender, EventArgs e)
        {
            _jokeView.Show();
        }

        private void UpdateView(object sender, EventArgs e)
        {
            // Send current list to View if Modell has changed
            throw new NotImplementedException();

        }

        private async void GetJoke(object sender, EventArgs e)
        {
            string joke = await ChuckNorrisJokeDownloader.GetJsonString();
            _jokeView.WriteJokeToTxtBox(joke);
        }

        #endregion
    }
}
