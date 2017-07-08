namespace ISWGestAcaApp
{
    partial class ventanaAlumnoNoEncontrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAlumnoNoEncontrado));
            this.label1 = new System.Windows.Forms.Label();
            this.ane_Aceptar = new System.Windows.Forms.Button();
            this.ane_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "El alumno no ha sido encontrado en la base de datos \r\n¿desea darlo de alta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ane_Aceptar
            // 
            this.ane_Aceptar.Location = new System.Drawing.Point(48, 127);
            this.ane_Aceptar.Name = "ane_Aceptar";
            this.ane_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.ane_Aceptar.TabIndex = 1;
            this.ane_Aceptar.Text = "Aceptar";
            this.ane_Aceptar.UseVisualStyleBackColor = true;
            this.ane_Aceptar.Click += new System.EventHandler(this.ane_Aceptar_Click);
            // 
            // ane_Cancelar
            // 
            this.ane_Cancelar.Location = new System.Drawing.Point(195, 127);
            this.ane_Cancelar.Name = "ane_Cancelar";
            this.ane_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.ane_Cancelar.TabIndex = 2;
            this.ane_Cancelar.Text = "Cancelar";
            this.ane_Cancelar.UseVisualStyleBackColor = true;
            this.ane_Cancelar.Click += new System.EventHandler(this.ane_Cancelar_Click);
            // 
            // ventanaAlumnoNoEncontrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 180);
            this.Controls.Add(this.ane_Cancelar);
            this.Controls.Add(this.ane_Aceptar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaAlumnoNoEncontrado";
            this.Text = "Alumno no encontrado";
            this.Load += new System.EventHandler(this.ventanaAlumnoNoEncontrado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ane_Aceptar;
        private System.Windows.Forms.Button ane_Cancelar;
    }
}