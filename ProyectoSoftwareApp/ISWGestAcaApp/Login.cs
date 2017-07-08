using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;
namespace ISWGestAcaApp
{
    public partial class ventanaLogin : Form
    {
        private BusinessController businessControl;
        private ventanaAdministrador ventanaAdmin;
        private ventanaEmpleado ventanaEmp;

        public ventanaLogin(BusinessController control)
        {
            InitializeComponent();
            this.businessControl = control;                      
        }
        public ventanaLogin() {
            InitializeComponent();
            this.businessControl = BusinessController.getBusinessController();
        }
        private void botonAdmin_Click(object sender, EventArgs e)
        {
            ventanaAdmin = new ventanaAdministrador(businessControl);
            this.ventanaAdmin.ShowDialog();
            
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonEmple_Click_1(object sender, EventArgs e)
        {
            ventanaEmp = new ventanaEmpleado(businessControl);
            this.ventanaEmp.ShowDialog();

        }

        private void ventanaLogin_Load(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }
    }
}