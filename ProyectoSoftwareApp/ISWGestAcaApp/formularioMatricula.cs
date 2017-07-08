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
    public partial class formularioMatricula : Form
    {
        private BusinessController businessControl;
        private ventanaSeleccionaCurso vsc;
        //private datosInscripcion datosIns;
        private introducirDNI vdni;
        private Student student;
        private TaughtCourse Tc;



        public formularioMatricula(BusinessController control, Student alumno/*, TaughtCourse tc*/)
        {
            InitializeComponent();
            this.businessControl = control;
            this.student = alumno;
            //this.tc = this.tc;
        }

        public formularioMatricula(BusinessController control)
        {
            InitializeComponent();
            this.businessControl = control;
            

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {           
            String id = idTextBox.Text;
            String name = nameTextBox.Text;
            String address = addressTextBox.Text;
            int zipcode = Int32.Parse(zipCodeTextBox.Text);
            String IBAN = iBANTextBox.Text;




            //businessControl.addTaughtCourse(tc);
            //vdni = new introducirDNI(businessControl, tc);
            //this.vdni.ShowDialog();
            //this.Close();

            if (idTextBox.TextLength == 0 || nameTextBox.TextLength == 0 || addressTextBox.TextLength == 0 || iBANTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

            }
            else
            {



                Student alumno = new Student(id, name, address, zipcode, IBAN);
                businessControl.addStudent(alumno);

                DialogResult conseguido = MessageBox.Show(this, "Matrícula formalizada correctamente. Bienvenido, por favor introduzca su dni otra vez.", "Matricula completa",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Asterisk
                           );

                this.Close();

            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //vsc = new ventanaSeleccionaCurso(businessControl);
            //this.vsc.ShowDialog();
            this.Close();
            //this.Close();

        }

        // Lo de abajo no tocar, caca
        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }     
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iBANTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void formularioInscripcion_Load(object sender, EventArgs e)
        {

        }
        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void zipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void iBANLabel_Click(object sender, EventArgs e)
        {

        }

        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, introduce un valor válido");
            }
        }
    }
}
