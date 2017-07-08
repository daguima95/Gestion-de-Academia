using GestAcaLib.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestAcaLib.Entities;
using GestAcaLib.BusinessLogic;

namespace ISWGestAcaApp
{
    public partial class ventanaAlumnoNoEncontrado : Form
    {
        private formularioMatricula formulario;
        private Student student;
        //private TaughtCourse tcurso;

        private BusinessController businessControl;

        public ventanaAlumnoNoEncontrado(BusinessController control/*, TaughtCourse tc*/)
        {
            InitializeComponent();
            this.businessControl = control;
            //this.tcurso = tc;
        }

        private void ane_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ane_Aceptar_Click(object sender, EventArgs e)
        {
            formulario = new formularioMatricula(businessControl/*, student, tcurso*/);
            this.formulario.ShowDialog();
            this.Close();
            this.Close();
        }

        private void ventanaAlumnoNoEncontrado_Load(object sender, EventArgs e)
        {

        }
    }
}
