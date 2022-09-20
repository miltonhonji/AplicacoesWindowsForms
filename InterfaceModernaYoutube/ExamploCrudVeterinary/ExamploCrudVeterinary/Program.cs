using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamploCrudVeterinary.Models;
using ExamploCrudVeterinary.Presenters;
using ExamploCrudVeterinary._Repositories;
using ExamploCrudVeterinary.Views;
using System.Configuration;

namespace ExamploCrudVeterinary
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
            string sqlServerConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainPetView petMainView = new frmMainPetView();
            new MainPetPresenter(petMainView, sqlServerConnectionString);
            Application.Run((Form)petMainView);
            //Application.Run(new Views.frmPetView());
        }
    }
}
