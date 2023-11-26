using BUS.Services;
using DAL.DBContexs;
using DAL.Repositories;
using PRL.View;

namespace PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);


            GymDBContext gymDBContext = new GymDBContext();


            UserRepository userRepository = new UserRepository(gymDBContext);
            UserService userService = new UserService(userRepository, gymDBContext);

            ApplicationConfiguration.Initialize();
            
            //---------------------------------------------------------------------------------------
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            Application.Run(new DangNhap(userService));
        }
    }
}