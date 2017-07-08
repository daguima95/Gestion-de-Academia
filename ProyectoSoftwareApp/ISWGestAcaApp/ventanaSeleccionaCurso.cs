using GestAcaLib.BusinessLogic;
using GestAcaLib.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISWGestAcaApp
{
    public partial class ventanaSeleccionaCurso : Form
    {

        private ventanaLogin vl;
        private introducirDNI vdni;


        private TaughtCourse Tcourse;
        private int id;


        private BusinessController businessControl;

        public ventanaSeleccionaCurso(BusinessController control)
        {
            InitializeComponent();
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;
            tabla.ClearSelection();
            this.businessControl = control;
            refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vl = new ventanaLogin(businessControl);
            ventanaSeleccionaCurso.ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowCount = tabla.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                DialogResult answer = MessageBox.Show(this, "Debe seleccionar un curso", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
            }
            else
            {
                id = (int)tabla.CurrentRow.Cells["dis_ID"].Value;
                Tcourse = businessControl.findTaughtCourseById(id);
                vdni = new introducirDNI(businessControl, Tcourse);
                this.vdni.ShowDialog();
            }



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refrescar()
        {
            ICollection<Course> courses;
            courses = businessControl.findAllCourses();
            //ICollection<TaughtCourse> = Ta;


            BindingList<object> binding = new BindingList<object>();
            string nom = "";
            string fecha = "";
            int id;
            foreach (Course c in courses)
            {
                nom = c.Name;
                foreach (TaughtCourse t in c.TaughtCourses)
                {
                    id = t.Id;
                    fecha = t.StartDateTime.ToString();
                   if (t.StartDateTime > DateTime.Now)
                     {

                    binding.Add(new
                    {
                        sc_ID = t.Id,
                        sc_nombre = c.Name,
                        sc_descripcion = c.Description,
                        sc_fi = t.StartDateTime
                    });
                      }
                    //  }
                }

                sc_binding.DataSource = binding;

            }
        }
    }
}
