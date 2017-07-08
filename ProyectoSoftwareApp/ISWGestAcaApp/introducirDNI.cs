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
   
    public partial class introducirDNI : Form
    {
        private ventanaAlumnoNoEncontrado vane;
        //private formularioMatricula formulario;
        private datosInscripcion datos;
        private introducirEnrollmentId inEn;

        private TaughtCourse Tcurso;
        private Enrollment enroll;

        private Boolean encontrado = false;

        private BusinessController businessControl;
        

        public introducirDNI(BusinessController control, TaughtCourse Tc)
        {
            InitializeComponent();
            this.businessControl = control;
            this.Tcurso = Tc;
           
        }               

        private void botonA_Click(object sender, EventArgs e)
        {
            String dni = textBoxDNI.Text;
            
            Student alumno = businessControl.findStudentByID(dni);

             //textBoxDNI as 

            if (textBoxDNI.TextLength < 8)
            {
                MessageBox.Show("Debe rellenar correctamente el DNI", "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk
                                    );
            }

            else
            {

                //Boolean encontrado;

                if (alumno != null)
                {

                    foreach (Enrollment en in alumno.Enrollments)
                    {
                        if (en.TaughtCourse.Id == Tcurso.Id)
                        {                            
                                encontrado = true;
                                break;                           
                        }
                        else encontrado = false;
                    }

                    if (encontrado)
                    {
                        MessageBox.Show("Alumno ya asignado a ese curso", "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                        );
                    }
                    else
                    {            
                                datos = new datosInscripcion(businessControl, alumno, Tcurso, enroll);
                                this.datos.ShowDialog();
                                this.Close();                                                    
                    }
                }

                else
                {
                    vane = new ventanaAlumnoNoEncontrado(businessControl);
                    this.vane.ShowDialog();
                    this.Close();
                }
            }
        }
        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void introducirDNI_Load(object sender, EventArgs e)
        {
            label_vacio.Text = "ID: " + Tcurso.Id.ToString() + " Nombre: " + Tcurso.Course.Name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
