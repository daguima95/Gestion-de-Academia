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
using GestAcaLib.Persistence;


namespace ISWGestAcaApp
{
    public partial class introducirEnrollmentId : Form
    {
        private BusinessController businessControl;
        private datosInscripcion datos;
        private Student student;
        private TaughtCourse Tc;
        private GestAcaDAL dal;
        private Student estudianteAnadir;
        private TaughtCourse cursoImAnadir;
        private Enrollment enrollment;

        public introducirEnrollmentId(BusinessController control, Student alumno, TaughtCourse tcourse)
        {
            InitializeComponent();
            this.businessControl = control;
            this.student = alumno;
            this.Tc = tcourse;
            student = alumno;

            this.estudianteAnadir = alumno;
            this.cursoImAnadir = tcourse;
            dal = GestAcaDAL.getGestAcaDAL();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            int enId = Int32.Parse(enIdTextBox.Text);

            Enrollment enrr = new Enrollment();
            enrr.EnrollmentDate = cursoImAnadir.StartDateTime;
            enrr.CancellationDate = cursoImAnadir.EndTime;
            enrr.UniquePayment = true;
            enrr.TaughtCourse = Tc;

            if (enIdTextBox.TextLength == 0 || enIdTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe rellenar la casilla", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

            }
            else
            {
                foreach(Enrollment en in Tc.Enrollments)
                {
                    if (en.TaughtCourse.Id == enrr.Id)
                        {
                            DialogResult errorAsig = MessageBox.Show(this, "El ID introducido ya se está usando", "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            return;
                        }
                }
                try
                {
                    enrr = new Enrollment(enId, cursoImAnadir.StartDateTime, cursoImAnadir.EndTime, true, estudianteAnadir, cursoImAnadir);
                    businessControl.addEnrollment(enrr);
                }
                catch (BusinessLogicException ex)
                {
                    DialogResult errorAsignar = MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
            }

            //datos = new datosInscripcion(businessControl, student, Tc, enrollment);
            //this.datos.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, introduce un valor válido");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
