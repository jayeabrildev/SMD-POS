
using SMD_Water_Station.Frontend;

namespace SMD_Water_Station.Helpers
{
    class FormHandler
    {
        private static Signin signin;

        public static MainWindow MainWindow;

        public static Signin signIn
        {
            get
            {
                if (signin == null)
                {
                    signin = new Signin();
                }
                return signin;
            }
        }

        public static void ShowMaininterface()
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}
