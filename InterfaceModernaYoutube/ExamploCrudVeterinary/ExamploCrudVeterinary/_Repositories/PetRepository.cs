using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ExamploCrudVeterinary.Models;

namespace ExamploCrudVeterinary._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        #region Constructor

        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        #endregion Constructor

        #region Methods

        public void Add(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PetModel petModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PetModel> GetAll()
        {
            string sqlServerLineCommand = String.Empty;
            var petList = new List<PetModel>();
            using(var sqlServerConnection = new SqlConnection(connectionString))
            using (var sqlServerCommand = new SqlCommand())
            {
                sqlServerConnection.Open();
                sqlServerCommand.Connection = sqlServerConnection;

                sqlServerLineCommand = "Select ";
                sqlServerLineCommand += "Pet_Id, ";
                sqlServerLineCommand += "Pet_Name, ";
                sqlServerLineCommand += "Pet_Type, ";
                sqlServerLineCommand += "Pet_Colour ";
                sqlServerLineCommand += "From Pet ";
                sqlServerLineCommand += "Order by Pet_Id Desc ";

                sqlServerCommand.CommandText = sqlServerLineCommand;

                using (var petDataReader = sqlServerCommand.ExecuteReader())
                {
                    while (petDataReader.Read())
                    {
                        var petListModel = new PetModel();

                        petListModel.Id = (int)petDataReader[0];
                        petListModel.Name = petDataReader[1].ToString();
                        petListModel.Type = petDataReader[2].ToString();
                        petListModel.Colour = petDataReader[3].ToString();

                        petList.Add(petListModel);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            string sqlServerLineCommand = String.Empty;
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;
            var petList = new List<PetModel>();
            using (var sqlServerConnection = new SqlConnection(connectionString))
            using (var sqlServerCommand = new SqlCommand())
            {
                sqlServerConnection.Open();
                sqlServerCommand.Connection = sqlServerConnection;

                sqlServerLineCommand = "Select ";
                sqlServerLineCommand += "Pet_Id, ";
                sqlServerLineCommand += "Pet_Name, ";
                sqlServerLineCommand += "Pet_Type, ";
                sqlServerLineCommand += "Pet_Colour ";
                sqlServerLineCommand += "From Pet ";
                sqlServerLineCommand += "Where Pet_Id = @Pet_Id Or ";
                sqlServerLineCommand += "Pet_Name Like @Pet_Name+'%' ";
                sqlServerLineCommand += "Order by Pet_Id Desc ";

                sqlServerCommand.CommandText = sqlServerLineCommand;

                sqlServerCommand.Parameters.Add("@Pet_Id", SqlDbType.Int).Value = petId;
                sqlServerCommand.Parameters.Add("@Pet_Name", SqlDbType.NVarChar).Value = petName;

                using (var petDataReader = sqlServerCommand.ExecuteReader())
                {
                    while(petDataReader.Read())
                    {
                        var petListModel = new PetModel();

                        petListModel.Id = (int)petDataReader[0];
                        petListModel.Name = petDataReader[1].ToString();
                        petListModel.Type = petDataReader[2].ToString();
                        petListModel.Colour = petDataReader[3].ToString();

                        petList.Add(petListModel);
                    }
                }
            }
            return petList;
        }

        #endregion Methods
    }
}
