using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamploCrudVeterinary.Views;
using ExamploCrudVeterinary.Models;
using ExamploCrudVeterinary._Repositories;

namespace ExamploCrudVeterinary.Presenters
{
    public class MainPetPresenter
    {
        private IMainPetView mainPetView;
        private readonly string sqlConnectionString;

        public MainPetPresenter(IMainPetView mainPetView, string sqlConnectionString)
        {
            this.mainPetView = mainPetView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainPetView.ShowPetView += ShowPetsView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetView petView = frmPetView.GetInstance((frmMainPetView)mainPetView);
            IPetRepository petRepository = new PetRepository(sqlConnectionString);
            new PetPresenter(petView, petRepository);
        }
    }
}
