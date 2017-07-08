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
    public partial class ventanaCursoImpartido : Form
    {
        private BusinessController businessControl;
        private TaughtCourse cursoT = new TaughtCourse();
        private Course curso;
        int quota;
        int duracionMin;
        DateTime inicio;
        int precio;
        String dias;
        DateTime final;
        int id;
        int idaux;
        ICollection<Office> clases;
        ICollection<Teacher> profesores;
        public ventanaCursoImpartido(BusinessController control, Course course)
        {
            this.businessControl = control;
            this.curso = course;
            InitializeComponent();
            clases = businessControl.findAllOffices();
            profesores = businessControl.findAllTeachers();
            foreach (Office of in clases)
            {
                comboClase.Items.Add(of.Id);
            }
            foreach (Teacher te in profesores)
            {
                comboTeach.Items.Add(te.Id);
            }
            datosCursoLabel.Text = "ID: " + course.Id.ToString() + " Nombre: " + course.Name;
        }

        private void botonAceptTC_Click(object sender, EventArgs e)
        {


            cursoT.Course = curso;
            if (Int32.TryParse(datosQuota.Text, out quota))
            { cursoT.Quota = quota; }
            else
            {
                DialogResult msgQuota = MessageBox.Show(this, "Quota debe ser un entero", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            if (Int32.TryParse(textBox2.Text, out duracionMin))
            { cursoT.SessionDuration = duracionMin; }
            else
            {
                DialogResult msgDuración = MessageBox.Show(this, "Inserte los segundos que dura la clase", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

           
            inicio = dateTimePicker1.Value;
            cursoT.StartDateTime = inicio;
            if (Int32.TryParse(precioTotalbox.Text, out precio))
            { cursoT.TotalPrice = precio; }
            else
            {
                DialogResult msgprecioTotal = MessageBox.Show(this, "Inserte el precio como un numero", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            dias = despDias.Text;
            cursoT.TeachingDay = dias;
            final = dateFinal.Value;
            cursoT.EndTime = final;


            if (Int32.TryParse(txtId.Text, out id))
            {
                if (businessControl.findTaughtCourseById(id) != null)
                {
                    DialogResult msgID2 = MessageBox.Show(this, "El curso impartido ya existe", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }
                else
                { cursoT.Id = id;         }
            }
            else
            {
                DialogResult msgID = MessageBox.Show(this, "El id debe ser un entero", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            try
            {
                businessControl.addTaughtCourse(cursoT);
            }
            catch (BusinessLogicException ex)
            {
                DialogResult msgID = MessageBox.Show(this, ex.Message, "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return;
            }

            if (int.TryParse(comboTeach.Text, out idaux))
            {
                try
                {
                    businessControl.assignTeacherToTaughtCourse(comboTeach.Text, cursoT.Id);
                }
                catch (BusinessLogicException ex)
                {
                    DialogResult msgID = MessageBox.Show(this, ex.Message, "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                }

            }

            int idOffice;
            if (int.TryParse(comboClase.Text, out idOffice))
            {
                try
                {
                    businessControl.assignOfficeToTaughtCourse(idOffice, id);
                }
                catch (BusinessLogicException ex)
                {
                    DialogResult msgOffice = MessageBox.Show(this, ex.Message, "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                }
            }

            DialogResult exitoRotundo = MessageBox.Show(this, "Añadido correctamente", "Añadido correctamente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk
                        );

            this.Close();

        }

        private void botonCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ventanaCursoImpartido_Load(object sender, EventArgs e)
        {

        }

        private void datosQuota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
