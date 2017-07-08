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
    public partial class ventanaAsignarProfesor : Form
    {
        private BusinessController businessControl;
        public ventanaAsignarProfesor(BusinessController control)
        {
            InitializeComponent();
            this.businessControl = control;
            pintaProfesores();
            pintaCursos();
            cursoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cursoDataGridView.MultiSelect = false;
        }

        private void pintaProfesores()
        {
            ICollection<Teacher> profesores = businessControl.findAllTeachers();
            foreach (Teacher profesor in profesores)
            {
                profeosresComboBox.Items.Add(profesor.Id);
            }
        }

        private void pintaCursos()
        {
            ICollection<TaughtCourse> tcs = businessControl.findAllTaughtCourses();
            BindingList<object> bindingList = new BindingList<object>();
            foreach (TaughtCourse tc in tcs)
            {
                bindingList.Add(new
                {
                    id_prop = tc.Id,
                    nombre_prop = tc.Course.Name,
                    dia_prop = tc.TeachingDay,
                    inicio_prop = tc.StartDateTime.ToShortTimeString(),
                    duracion_prop = tc.SessionDuration
                    
                });
            }
            profesorBindingSource.DataSource = bindingList;
        }

        private void AsignarButton_Click(object sender, EventArgs e)
        {
            String dni = (String)profeosresComboBox.SelectedItem;
            int idTc;
            int selectedRowCount = cursoDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (dni==null)
            {
                DialogResult noHaySeleccion = MessageBox.Show(this, "No ha seleccionado ningún profesor", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (selectedRowCount == 0)
            {
                DialogResult noHaySeleccion = MessageBox.Show(this, "No ha seleccionado ningún grupo", "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else
            {
                idTc=(int)cursoDataGridView.CurrentRow.Cells["id"].Value;
                try
                {
                    businessControl.assignTeacherToTaughtCourse(dni, idTc);
                }
                catch (BusinessLogicException ex) {
                    DialogResult errorAsignar = MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                DialogResult answer = MessageBox.Show(this, "La operacion se ha realizado con exito", "Exito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }

        }

        private void profeosresComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            String dni = (String)profeosresComboBox.SelectedItem;
            Teacher profe = businessControl.findTeacherByID(dni);

            nombreLabel.Text = profe.Name;
            ssnLabel.Text = profe.Ssn;

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
