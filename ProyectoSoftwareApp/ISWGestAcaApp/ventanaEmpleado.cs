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
    public partial class ventanaEmpleado : Form
    {
       
        private BusinessController businessControl;
        private ventanaSeleccionaCurso vsc;

        public ventanaEmpleado(BusinessController control)
        {
            InitializeComponent();
            this.businessControl = control;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taughtCoursesListButton_Click(object sender, EventArgs e)
        {
            vsc = new ventanaSeleccionaCurso(businessControl);
            this.vsc.ShowDialog();
        }
        private void VentanaEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
