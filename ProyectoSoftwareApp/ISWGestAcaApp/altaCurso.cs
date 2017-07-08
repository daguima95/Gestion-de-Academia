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
    public partial class ventanaAltaCurso : Form
    {
        private BusinessController businessControl;
        private addCourseForm addCourse;
        private Course course;
        private ventanaCursoImpartido cursoImp;
        private int id;
        public ventanaAltaCurso(BusinessController control)
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();
            this.businessControl = control;
            refrescar();


        }

        private void botonNuevoCurso_Click(object sender, EventArgs e)
        {
            addCourse = new addCourseForm(businessControl);
            this.addCourse.ShowDialog();
            refrescar();
        }

        private void botonAtrAltaCurso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void refrescar() {
            ICollection<Course> cursos;
            cursos = businessControl.findAllCourses();
            BindingList<object> bindingList = new BindingList<object>();
            foreach (Course c in cursos)
            {
                bindingList.Add(new
                {
                    id_prop = c.Id,
                    nombre_prop = c.Name,
                    descripcion_prop = c.Description

                });
            }
            altaCursoEnlace.DataSource = bindingList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void botonTC_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                DialogResult answer = MessageBox.Show(this, "Debe seleccionar un curso", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            else
            {
                id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                course = businessControl.findCourseByID(id);
                cursoImp = new ventanaCursoImpartido(businessControl, course);
                this.cursoImp.ShowDialog();
            }
        }
    }
}
