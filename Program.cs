using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Test User
            User user = new User();
            user.firstName = "yash";
            user.lastName = "w";
            user.rewardBalance = 0;
            //Application.Run(new UserLandingPage(user));
            Application.Run(new Login());
        }
    }
}
