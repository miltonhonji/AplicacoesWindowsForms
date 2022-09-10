using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamploCrudVeterinary.Views
{
    public partial class frmPetView : Form, IPetView
    {
        private string message;
        private bool isSuccessful;

        public frmPetView()
        {
            InitializeComponent();
        }
        
        #region Properties

        public string PetId
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string PetName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string PetType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string PetColour
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string SearchValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsEdit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        #endregion Properties

        #region Events

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        #endregion Events

        #region Methods

        public void SetPetListBindingSource(BindingSource petList)
        {
            dgvPetsList.DataSource = petList;
        }

        #endregion Methods
    }
}
