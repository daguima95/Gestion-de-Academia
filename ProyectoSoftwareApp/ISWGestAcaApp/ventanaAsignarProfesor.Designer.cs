namespace ISWGestAcaApp
{
    partial class ventanaAsignarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAsignarProfesor));
            this.profeosresComboBox = new System.Windows.Forms.ComboBox();
            this.profesorlabel = new System.Windows.Forms.Label();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoLabel = new System.Windows.Forms.Label();
            this.AsignarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profeosresComboBox
            // 
            this.profeosresComboBox.FormattingEnabled = true;
            this.profeosresComboBox.Location = new System.Drawing.Point(144, 35);
            this.profeosresComboBox.Name = "profeosresComboBox";
            this.profeosresComboBox.Size = new System.Drawing.Size(121, 21);
            this.profeosresComboBox.TabIndex = 0;
            this.profeosresComboBox.SelectedValueChanged += new System.EventHandler(this.profeosresComboBox_SelectedValueChanged);
            // 
            // profesorlabel
            // 
            this.profesorlabel.AutoSize = true;
            this.profesorlabel.Location = new System.Drawing.Point(16, 38);
            this.profesorlabel.Name = "profesorlabel";
            this.profesorlabel.Size = new System.Drawing.Size(122, 13);
            this.profesorlabel.TabIndex = 1;
            this.profesorlabel.Text = "Seleccione un profesor: ";
            // 
            // cursoDataGridView
            // 
            this.cursoDataGridView.AllowUserToAddRows = false;
            this.cursoDataGridView.AllowUserToDeleteRows = false;
            this.cursoDataGridView.AutoGenerateColumns = false;
            this.cursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.dia,
            this.inicio,
            this.duracion});
            this.cursoDataGridView.DataSource = this.profesorBindingSource;
            this.cursoDataGridView.Location = new System.Drawing.Point(19, 107);
            this.cursoDataGridView.Name = "cursoDataGridView";
            this.cursoDataGridView.ReadOnly = true;
            this.cursoDataGridView.Size = new System.Drawing.Size(543, 150);
            this.cursoDataGridView.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_prop";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre_prop";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // dia
            // 
            this.dia.DataPropertyName = "dia_prop";
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.ReadOnly = true;
            // 
            // inicio
            // 
            this.inicio.DataPropertyName = "inicio_prop";
            this.inicio.HeaderText = "Inicio";
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.DataPropertyName = "duracion_prop";
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // cursoLabel
            // 
            this.cursoLabel.AutoSize = true;
            this.cursoLabel.Location = new System.Drawing.Point(16, 78);
            this.cursoLabel.Name = "cursoLabel";
            this.cursoLabel.Size = new System.Drawing.Size(240, 13);
            this.cursoLabel.TabIndex = 3;
            this.cursoLabel.Text = "Selecione el grupo que quiere asignar al profesor:";
            // 
            // AsignarButton
            // 
            this.AsignarButton.Location = new System.Drawing.Point(425, 336);
            this.AsignarButton.Name = "AsignarButton";
            this.AsignarButton.Size = new System.Drawing.Size(75, 23);
            this.AsignarButton.TabIndex = 4;
            this.AsignarButton.Text = "Asignar";
            this.AsignarButton.UseVisualStyleBackColor = true;
            this.AsignarButton.Click += new System.EventHandler(this.AsignarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(528, 336);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(334, 38);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(0, 13);
            this.nombreLabel.TabIndex = 6;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(429, 38);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(0, 13);
            this.ssnLabel.TabIndex = 7;
            // 
            // ventanaAsignarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.AsignarButton);
            this.Controls.Add(this.cursoLabel);
            this.Controls.Add(this.cursoDataGridView);
            this.Controls.Add(this.profesorlabel);
            this.Controls.Add(this.profeosresComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaAsignarProfesor";
            this.Text = "Asignar Profesor - GestAcaMapache";
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox profeosresComboBox;
        private System.Windows.Forms.Label profesorlabel;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.DataGridView cursoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.Label cursoLabel;
        private System.Windows.Forms.Button AsignarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label ssnLabel;
    }
}