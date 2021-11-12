using SMD_Water_Station.Frontend;
using SMD_Water_Station.Views;

using System.Windows.Forms;

namespace SMD_Water_Station.Helpers
{
    public class PageHandler
    {
        public HomeView homeView = new HomeView();
        public ProductsView productsView;
        public MaterialsView suppliersView;
        public SalesView salesView;
        public AccountView accountView;

        public MainWindow mainwindow;

        public void Home()
        {
            UserControl currentView = new UserControl();
            if (homeView == null)
            {
                homeView = new HomeView();
            }
            currentView = homeView;
            LoadToContainer(mainwindow, currentView);
        }

        public void Products()
        {
            UserControl currentView = new UserControl();
            currentView = null;
            if (productsView == null)
            {
                productsView = new ProductsView();
            }
            currentView = productsView;
            LoadToContainer(mainwindow, currentView);
        }

        public void Suppliers()
        {
            UserControl currentView = new UserControl();
            currentView = null;
            if(suppliersView == null)
            {
                suppliersView = new MaterialsView();
            }
            currentView = suppliersView;
            LoadToContainer(mainwindow, currentView);
        }

        public void Sales()
        {
            UserControl currentView = new UserControl();
            currentView = null;
            if (salesView == null)
            {
                salesView = new SalesView();
            }
            currentView = salesView;
            LoadToContainer(mainwindow, currentView);
        }

        public void AccountSettings()
        {
            UserControl currentView = new UserControl();
            currentView = null;
            if (accountView == null)
            {
                accountView = new AccountView();
            }
            currentView = accountView;
            LoadToContainer(mainwindow, currentView);
        }


        public void LoadToContainer(MainWindow mainwindow, UserControl currentView)
        {
            mainwindow.Panel_Content.Controls.Clear();
            mainwindow.Panel_Content.Controls.Add(currentView);
            currentView.Show();
        }


    }
}
