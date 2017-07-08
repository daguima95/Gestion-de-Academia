namespace ISWGestAcaApp
{
    partial class ventanaAltaCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAltaCurso));
            this.altaCursoEnlace = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonNuevoCurso = new System.Windows.Forms.Button();
            this.botonAtrAltaCurso = new System.Windows.Forms.Button();
            this.botonTC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.altaCursoEnlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombreCurso,
            this.descripcionCurso});
            this.dataGridView1.DataSource = this.altaCursoEnlace;
            this.dataGridView1.Location = new System.Drawing.Point(22, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_prop";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // nombreCurso
            // 
            this.nombreCurso.DataPropertyName = "nombre_prop";
            this.nombreCurso.HeaderText = "Nombre";
            this.nombreCurso.Name = "nombreCurso";
            // 
            // descripcionCurso
            // 
            this.descripcionCurso.DataPropertyName = "descripcion_prop";
            this.descripcionCurso.HeaderText = "Descripción";
            this.descripcionCurso.Name = "descripcionCurso";
            // 
            // botonNuevoCurso
            // 
            this.botonNuevoCurso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonNuevoCurso.Location = new System.Drawing.Point(380, 158);
            this.botonNuevoCurso.Name = "botonNuevoCurso";
            this.botonNuevoCurso.Size = new System.Drawing.Size(109, 38);
            this.botonNuevoCurso.TabIndex = 2;
            this.botonNuevoCurso.Text = "Añadir Curso";
            this.botonNuevoCurso.UseVisualStyleBackColor = false;
            this.botonNuevoCurso.Click += new System.EventHandler(this.botonNuevoCurso_Click);
            // 
            // botonAtrAltaCurso
            // 
            this.botonAtrAltaCurso.Location = new System.Drawing.Point(433, 368);
            this.botonAtrAltaCurso.Name = "botonAtrAltaCurso";
            this.botonAtrAltaCurso.Size = new System.Drawing.Size(66, 32);
            this.botonAtrAltaCurso.TabIndex = 3;
            this.botonAtrAltaCurso.Text = "Atrás";
            this.botonAtrAltaCurso.UseVisualStyleBackColor = true;
            this.botonAtrAltaCurso.Click += new System.EventHandler(this.botonAtrAltaCurso_Click);
            // 
            // botonTC
            // 
            this.botonTC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botonTC.Location = new System.Drawing.Point(380, 73);
            this.botonTC.Name = "botonTC";
            this.botonTC.Size = new System.Drawing.Size(109, 38);
            this.botonTC.TabIndex = 4;
            this.botonTC.Text = "Seleccionar curso";
            this.botonTC.UseVisualStyleBackColor = false;
            this.botonTC.Click += new System.EventHandler(this.botonTC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione un curso";
            // 
            // ventanaAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonTC);
            this.Controls.Add(this.botonAtrAltaCurso);
            this.Controls.Add(this.botonNuevoCurso);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaAltaCurso";
            this.Text = "ventanaAltaCurso-GestAcaMapache";
            ((System.ComponentModel.ISupportInitialize)(this.altaCursoEnlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource altaCursoEnlace;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCurso;
        private System.Windows.Forms.Button botonNuevoCurso;
        private System.Windows.Forms.Button botonAtrAltaCurso;
        private System.Windows.Forms.Button botonTC;
        private System.Windows.Forms.Label label1;
    }
}