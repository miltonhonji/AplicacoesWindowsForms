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
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //btnSearchPet.Click += new EventHandler();
            btnSearchPet.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchPet.KeyDown += (s, e) =>
             {
                 if (e.KeyCode == Keys.Enter)
                     SearchEvent?.Invoke(this, EventArgs.Empty);
             };

            btnAddNewPet.Click += delegate 
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabPetsOptions.TabPages.Remove(tpPetList);
                tabPetsOptions.TabPages.Add(tpPetDetail);
                tpPetDetail.Text = "Add New Pet";
            };

            btnEditPet.Click += delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabPetsOptions.TabPages.Remove(tpPetList);
                tabPetsOptions.TabPages.Add(tpPetDetail);
                tpPetDetail.Text = "Edit Pet";
            };

            btnDeletePet.Click += delegate 
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            btnSaveDetail.Click += delegate 
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                
                if(isSuccessful)
                {
                    tabPetsOptions.TabPages.Remove(tpPetDetail);
                    tabPetsOptions.TabPages.Add(tpPetList);
                }

                MessageBox.Show(Message);
            };

            btnCancelDetail.Click += delegate 
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                if(isSuccessful)
                {
                    tabPetsOptions.TabPages.Remove(tpPetDetail);
                    tabPetsOptions.TabPages.Add(tpPetList);
                }
            };
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

        //Singleton Pattern
        private static frmPetView instancePetView;

        public static frmPetView GetInstance(Form parentContainer)
        {
            if (instancePetView == null || instancePetView.IsDisposed)
            {
                instancePetView = new frmPetView();
                instancePetView.MdiParent = parentContainer;
                instancePetView.FormBorderStyle = FormBorderStyle.None;
                instancePetView.Dock = DockStyle.Fill;
            }
            else
            { 
                if (instancePetView.WindowState == FormWindowState.Minimized)
                    instancePetView.WindowState = FormWindowState.Normal;

                    instancePetView.BringToFront();
            }
            return instancePetView;
        }
        #endregion Methods
    }
}
