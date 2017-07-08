namespace ISWGestAcaApp
{
    partial class ventanaSeleccionaCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaSeleccionaCurso));
            this.button1 = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.dis_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sc_binding = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_binding)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabla
            // 
            this.tabla.AutoGenerateColumns = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dis_ID,
            this.dis_nombre,
            this.dis_descripcion,
            this.Fecha_Inicio});
            this.tabla.DataSource = this.sc_binding;
            this.tabla.Location = new System.Drawing.Point(34, 70);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(460, 296);
            this.tabla.TabIndex = 1;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dis_ID
            // 
            this.dis_ID.DataPropertyName = "sc_ID";
            this.dis_ID.HeaderText = "ID";
            this.dis_ID.Name = "dis_ID";
            // 
            // dis_nombre
            // 
            this.dis_nombre.DataPropertyName = "sc_nombre";
            this.dis_nombre.HeaderText = "Nombre";
            this.dis_nombre.Name = "dis_nombre";
            // 
            // dis_descripcion
            // 
            this.dis_descripcion.DataPropertyName = "sc_descripcion";
            this.dis_descripcion.HeaderText = "Descripcion";
            this.dis_descripcion.Name = "dis_descripcion";
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.DataPropertyName = "sc_fi";
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Selecciona";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(158, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elige uno de los cursos de la lista";
            // 
            // ventanaSeleccionaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaSeleccionaCurso";
            this.Text = "ventanaSeleccionaCurso-GestAcaMapache";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc_binding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.BindingSource sc_binding;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
    }
}