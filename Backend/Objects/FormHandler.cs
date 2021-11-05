
using SMD_Water_Station.Views;

namespace SMD_Water_Station
{
    class FormHandler
    {
        private static Signin signin;

        public static MainInterfaceView MainInterface;

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
            MainInterface = new MainInterfaceView();
            MainInterface.Show();
        }
    }
}
