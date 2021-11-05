using SMD_Water_Station.Frontend;
using SMD_Water_Station.Views;

using System.Windows.Forms;

namespace SMD_Water_Station.Helpers
{
    public class PageHandler
    {
        UserControl currentView;
        public static HomeView homeView;
        public static ProductsView productsView;
        public static SuppliersView suppliersView;
        public static SalesView salesView;
        public static AccountView accountView;

        public void Home()
        {
            if (homeView == null)
            {
                homeView = new HomeView();
            }
            currentView = homeView;
            LoadToContainer();
        }

        public void Products()
        {
            currentView = null;
            if (productsView == null)
            {
                productsView = new ProductsView();
            }
            currentView = productsView;
            LoadToContainer();
        }

        public void Suppliers()
        {
            currentView = null;
            if(suppliersView == null)
            {
                suppliersView = new SuppliersView();
            }
            currentView = suppliersView;
            LoadToContainer();
        }

        public void Sales()
        {
            currentView = null;
            if (salesView == null)
            {
                salesView = new SalesView();
            }
            currentView = salesView;
            LoadToContainer();
        }

        public void AccountSettings()
        {
            currentView = null;
            if (accountView == null)
            {
                accountView = new AccountView();
            }
            currentView = accountView;
            LoadToContainer();
        }


        public void LoadToContainer()
        {
            FormHandler.MainWindow.Panel_Content.Controls.Clear();
            FormHandler.MainWindow.Panel_Content.Controls.Add(currentView);
            currentView.Show();
        }


    }
}
