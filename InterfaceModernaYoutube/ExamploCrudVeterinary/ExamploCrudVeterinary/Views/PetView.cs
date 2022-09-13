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
        #region Variables

        private bool isEdit;
        private bool isSuccessful;
        private string message;

        #endregion Variables

        #region Constructor

        public frmPetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabPetsOptions.TabPages.Remove(tpPetDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //btnSearchPet.Click += new EventHandler();
            btnSearchPet.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnSearchPet.KeyDown += (s, e) =>
             {
                 if (e.KeyCode == Keys.Enter)
                     SearchEvent?.Invoke(this, EventArgs.Empty);
             };
            //Other

        }

        #endregion Constructor

        #region Properties

        public string PetId
        {
            get { return txtPetId.Text; }
            set { txtPetId.Text = value; }
        }

        public string PetName
        {
            get { return txtPetName.Text; }
            set { txtPetName.Text = value; }
        }

        public string PetType
        {
            get { return txtPetType.Text; }
            set { txtPetType.Text = value; }
        }

        public string PetColour
        {
            get { return txtPetColour.Text; }
            set { txtPetColour.Text = value; }
        }

        public string SearchValue
        {
            get { return txtSearchPet.Text; }
            set { txtSearchPet.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
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
