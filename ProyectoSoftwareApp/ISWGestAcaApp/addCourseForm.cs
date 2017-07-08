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
    public partial class addCourseForm : Form
    {
        private BusinessController businessControl;

        public addCourseForm(BusinessController control)
        {
            InitializeComponent();
            this.businessControl = control;
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (Int32.TryParse(IdTextBox.Text, out id))
            {
                    IdErrorLabel.Visible = false;
                    String nombre = nombreTextBox.Text;
                    String descripcion = descripcionRichTextBox.Text;

                    Course curso = new Course(id, nombre, descripcion);
                try
                {
                    businessControl.addCourse(curso);
                }
                catch (BusinessLogicException ex)
                {
                    DialogResult answer = MessageBox.Show(this, ex.Message, "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                }
                DialogResult exito = MessageBox.Show(this, "Agregado con exito", "Exito",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Asterisk
                         );


            }
            else { IdErrorLabel.Visible = true; }

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
