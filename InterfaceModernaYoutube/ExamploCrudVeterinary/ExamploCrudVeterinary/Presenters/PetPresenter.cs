using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamploCrudVeterinary.Models;
using ExamploCrudVeterinary.Views;

namespace ExamploCrudVeterinary.Presenters
{
    public class PetPresenter
    {
        private IPetView petViewInterface;
        private IPetRepository petRepositoryInterface;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        public PetPresenter(IPetView petViewInterface, IPetRepository petRepositoryInterface)
        {
            this.petsBindingSource = new BindingSource();
            this.petViewInterface = petViewInterface;
            this.petRepositoryInterface = petRepositoryInterface;
            this.petViewInterface.SearchEvent += SearchPet;
            this.petViewInterface.AddNewEvent += AddNewPet;
            this.petViewInterface.CancelEvent += CancelAction;
            this.petViewInterface.DeleteEvent += DeleteSelectedPet;
            this.petViewInterface.EditEvent += LoadSelectedPetToEdit;
            this.petViewInterface.SaveEvent += SavePet;
            this.petViewInterface.SetPetListBindingSource(petsBindingSource);
            LoadAllPetList();
            this.petViewInterface.Show();
        }

        private void LoadAllPetList()
        {
            petList = petRepositoryInterface.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.petViewInterface.SearchValue);

            if (emptyValue == false)
                petList = petRepositoryInterface.GetByValue(this.petViewInterface.SearchValue);
            else
                petList = petRepositoryInterface.GetAll();

            petsBindingSource.DataSource = petList;
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            petViewInterface.IsEdit = false;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var loadSelectedPet = (PetModel)petsBindingSource.Current;
                petRepositoryInterface.Delete(loadSelectedPet.Id);
                petViewInterface.IsSuccessful = true;
                petViewInterface.Message = "Pet Deleted Sucessfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                petViewInterface.IsSuccessful = false;
                petViewInterface.Message = "An error ocurred, could not delete pet";
            }
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var loadSelectedPet = (PetModel)petsBindingSource.Current;
            petViewInterface.PetId = loadSelectedPet.Id.ToString();
            petViewInterface.PetName = loadSelectedPet.Name;
            petViewInterface.PetType = loadSelectedPet.Type;
            petViewInterface.PetColour = loadSelectedPet.Colour;
            petViewInterface.IsEdit = true;
        }

        private void SavePet(object sender, EventArgs e)
        {
            var petModel = new PetModel();

            petModel.Id = Convert.ToInt32(petViewInterface.PetId);
            petModel.Name = petViewInterface.PetName;
            petModel.Type = petViewInterface.PetType;
            petModel.Colour = petViewInterface.PetColour;

            try
            {
                new Common.ModelDataValidation().ValidateData(petModel);

                if(petViewInterface.IsEdit)
                {
                    petRepositoryInterface.Edit(petModel);
                    petViewInterface.Message = "Pet Edited Successfully";
                }
                else
                {
                    petRepositoryInterface.Add(petModel);
                    petViewInterface.Message = "Pet Added Successfully";
                }

                petViewInterface.IsSuccessful = true;
                LoadAllPetList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                petViewInterface.IsSuccessful = false;
                petViewInterface.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            petViewInterface.PetId = "0";
            petViewInterface.PetName = String.Empty;
            petViewInterface.PetType = String.Empty;
            petViewInterface.PetColour = String.Empty;

        }
    }
}
