namespace ISWGestAcaApp
{
    partial class ventanaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAdministrador));
            this.botonAltaCurso = new System.Windows.Forms.Button();
            this.botonAsignarProfe = new System.Windows.Forms.Button();
            this.labelVentanaAdmin = new System.Windows.Forms.Label();
            this.botonAtrAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAltaCurso
            // 
            this.botonAltaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAltaCurso.Location = new System.Drawing.Point(96, 182);
            this.botonAltaCurso.Name = "botonAltaCurso";
            this.botonAltaCurso.Size = new System.Drawing.Size(181, 83);
            this.botonAltaCurso.TabIndex = 0;
            this.botonAltaCurso.Text = "Dar de alta curso a impartir";
            this.botonAltaCurso.UseVisualStyleBackColor = true;
            this.botonAltaCurso.Click += new System.EventHandler(this.botonAltaCurso_Click);
            // 
            // botonAsignarProfe
            // 
            this.botonAsignarProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAsignarProfe.Location = new System.Drawing.Point(305, 182);
            this.botonAsignarProfe.Name = "botonAsignarProfe";
            this.botonAsignarProfe.Size = new System.Drawing.Size(181, 83);
            this.botonAsignarProfe.TabIndex = 1;
            this.botonAsignarProfe.Text = "Asignar profesor a un curso";
            this.botonAsignarProfe.UseVisualStyleBackColor = true;
            this.botonAsignarProfe.Click += new System.EventHandler(this.botonAsignarProfe_Click);
            // 
            // labelVentanaAdmin
            // 
            this.labelVentanaAdmin.AutoSize = true;
            this.labelVentanaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVentanaAdmin.Location = new System.Drawing.Point(169, 117);
            this.labelVentanaAdmin.Name = "labelVentanaAdmin";
            this.labelVentanaAdmin.Size = new System.Drawing.Size(242, 20);
            this.labelVentanaAdmin.TabIndex = 2;
            this.labelVentanaAdmin.Text = "Elija la acción que desea realizar:";
            // 
            // botonAtrAdmin
            // 
            this.botonAtrAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonAtrAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAtrAdmin.Location = new System.Drawing.Point(470, 418);
            this.botonAtrAdmin.Name = "botonAtrAdmin";
            this.botonAtrAdmin.Size = new System.Drawing.Size(102, 31);
            this.botonAtrAdmin.TabIndex = 3;
            this.botonAtrAdmin.Text = "Atrás";
            this.botonAtrAdmin.UseVisualStyleBackColor = true;
            this.botonAtrAdmin.Click += new System.EventHandler(this.botonAtrAdmin_Click);
            // 
            // ventanaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.botonAtrAdmin);
            this.Controls.Add(this.labelVentanaAdmin);
            this.Controls.Add(this.botonAsignarProfe);
            this.Controls.Add(this.botonAltaCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ventanaAdministrador";
            this.Text = "ventanaAdministrador-GestAcaMapache";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAltaCurso;
        private System.Windows.Forms.Button botonAsignarProfe;
        private System.Windows.Forms.Label labelVentanaAdmin;
        private System.Windows.Forms.Button botonAtrAdmin;
    }
}