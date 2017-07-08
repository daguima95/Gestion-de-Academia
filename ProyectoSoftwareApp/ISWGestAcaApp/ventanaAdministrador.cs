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
    public partial class ventanaAdministrador : Form
    {
        private ventanaAltaCurso altaCurso;
        private ventanaAsignarProfesor asignProfe;
        private ventanaLogin ventLog;
        private BusinessController businessControl;
        public ventanaAdministrador(BusinessController control)
        {
            InitializeComponent();
            this.businessControl = control;          
        }

        private void botonAltaCurso_Click(object sender, EventArgs e)
        {
            altaCurso = new ventanaAltaCurso(businessControl);
            this.altaCurso.ShowDialog();
            

        }

        private void botonAsignarProfe_Click(object sender, EventArgs e)
        {
             asignProfe = new ventanaAsignarProfesor(businessControl);
             this.asignProfe.ShowDialog();
        }

        private void botonAtrAdmin_Click(object sender, EventArgs e)
        {
            ventLog = new ventanaLogin(businessControl);
            ventanaAdministrador.ActiveForm.Close();
        }
    }
}
