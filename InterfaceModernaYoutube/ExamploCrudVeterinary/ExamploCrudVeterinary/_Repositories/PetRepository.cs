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
            var petList = new List<PetModel>();
            using(var sqlServerConnection = new SqlConnection(connectionString))
            using (var sqlServerCommand = new SqlCommand())
            {

            }

            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}
