using System;
using System.Collections;
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
using GestAcaLib.Persistence;

namespace ISWGestAcaApp
{
    public partial class datosInscripcion : Form
    {    
        private BusinessController businessControl;
        private GestAcaDAL dal;
        private Student student;
        private TaughtCourse tc;
        private Enrollment enroll;
        //private ventanaSeleccionaCurso vsc;

        private Student estudianteAnadir;
        private TaughtCourse cursoImAnadir;

        public datosInscripcion(BusinessController control, Student alumno, TaughtCourse tc, Enrollment enrollment)
        {
            InitializeComponent();
            this.businessControl = control;
             this.student = alumno;
             this.tc = tc;
            this.enroll = enrollment;
             student = alumno;
            enroll = enrollment;


            this.estudianteAnadir = alumno;
            this.cursoImAnadir = tc;
            dal = GestAcaDAL.getGestAcaDAL();

            nameLabel.Text = alumno.Name;
            infoIdLabel.Text = alumno.Id;
            infoAddressLabel.Text = alumno.Address;
            infoZipCodeLabel.Text = alumno.ZipCode.ToString();
            infoIBANLabel.Text = alumno.IBAN;

            //infoIdEnrollment.Text = enrollment.Id.ToString();

            infoCourseLabel.Text = tc.Course.Name;
            infoIDCourseLabel.Text = tc.Id.ToString();
            infoTimesLabel.Text = "During  " + tc.TeachingDay.ToString() + "  from  " + tc.StartDateTime.ToString() + "  to  " + tc.EndTime.ToString();
            infoDurationLabel.Text = tc.SessionDuration.ToString() + " minutes";
            infoQuotaLabel.Text = tc.Quota.ToString();
            infoTotalPriceLabel.Text = tc.TotalPrice.ToString();       

        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            String dni = infoIdLabel.Text;
            Student alumno = businessControl.findStudentByID(dni);
            String idAl = alumno.Id;

            int enId = Int32.Parse(idEnrollmentTextBox.Text);
           
            Enrollment enrr = new Enrollment();
            enrr.EnrollmentDate = cursoImAnadir.StartDateTime;
            enrr.CancellationDate = cursoImAnadir.EndTime;
            enrr.UniquePayment = true;
            enrr.TaughtCourse = tc;

            if (idEnrollmentTextBox.TextLength == 0 || idEnrollmentTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe rellenar la casilla", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

            }
            else
            {
                foreach (Enrollment en in tc.Enrollments)
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
                    businessControl.assignStudentToTaughtCourse(idAl, enrr);
                }
                catch (BusinessLogicException ex)
                {
                    DialogResult errorAsignar = MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                     
                /*foreach (Enrollment en in tc.Enrollments) // la lista de Enrollments es Count = 0
                {
                    if (en.Student.Id == idAl)
                    {
                        DialogResult errorAsig = MessageBox.Show(this, "El alumno ya pertenece a este curso", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    //businessControl.addEnrollment(enrr);
                    businessControl.assignStudentToTaughtCourse(idAl, enrr);
                }
                catch (BusinessLogicException ex)
                {
                    DialogResult errorAsignar = MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }*/
            }
            DialogResult exitoRotundo = MessageBox.Show(this, "Inscripción completa", "Inscripción realizada correctamente",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Asterisk
                     );
            this.Close();
            //this.Close();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {      
            this.Close();
        }

// Lo de abajo, no tocar
        private void nameLabel_Click(object sender, EventArgs e)
        {         
        }

        private void infoIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoZipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoIBANLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoCourseLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoIDCourseLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoTimesLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoDurationLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoQuotaLabel_Click(object sender, EventArgs e)
        {

        }

        private void infoTotalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombreApellidos_Click(object sender, EventArgs e)
        {

        }

        private void dniLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void zipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ibanLabel_Click(object sender, EventArgs e)
        {

        }

        private void courseLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void horarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void sessionDuration_Click(object sender, EventArgs e)
        {

        }

        private void quotaLabel_Click(object sender, EventArgs e)
        {

        }

        private void precioTotal_Click(object sender, EventArgs e)
        {

        }

        private void datosInscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}
