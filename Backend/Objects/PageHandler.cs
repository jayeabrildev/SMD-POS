using SMD_Water_Station.Frontend;
using SMD_Water_Station.Views;
using System.Windows.Forms;

namespace SMD_Water_Station.Classes
{
    public class PageHandler
    {
        Form selected;
        public static HomeView _homePage;
        public static ProductsView _productsPage;
        public static SalesView _salesPage;
        public static Form_AccountSettings _accountSettings;

        public void Home()
        {
            if (_homePage == null)
            {
                _homePage = new HomeView();
            }
            selected = _homePage;
            LoadToContainer();
        }

        public void Products()
        {
            selected = null;
            if (_productsPage == null)
            {
                _productsPage = new ProductsView();
            }
            selected = _productsPage;
            LoadToContainer();
        }

        public void Sales()
        {
            selected = null;
            if (_salesPage == null)
            {
                _salesPage = new SalesView();
            }
            selected = _salesPage;
            LoadToContainer();
        }

        public void LoadToContainer()
        {
            selected.TopLevel = false;
            FormHandler.MainInterface.Panel_container.Controls.Clear();
            FormHandler.MainInterface.Panel_container.Controls.Add(selected);
            selected.Show();
        }

        public void AccountSettings()
        {
            selected = null;
            if (_accountSettings == null)
            {
                _accountSettings = new Form_AccountSettings();
            }
            selected = _accountSettings;
            LoadToContainer();
        }

    }
}
