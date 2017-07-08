namespace ISWGestAcaApp
{
    partial class ventanaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaEmpleado));
            this.button1 = new System.Windows.Forms.Button();
            this.taughtCoursesListButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taughtCoursesListButton
            // 
            this.taughtCoursesListButton.Location = new System.Drawing.Point(91, 90);
            this.taughtCoursesListButton.Name = "taughtCoursesListButton";
            this.taughtCoursesListButton.Size = new System.Drawing.Size(281, 39);
            this.taughtCoursesListButton.TabIndex = 1;
            this.taughtCoursesListButton.Text = "Lista de Cursos a Impartir";
            this.taughtCoursesListButton.UseVisualStyleBackColor = true;
            this.taughtCoursesListButton.Click += new System.EventHandler(this.taughtCoursesListButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Lista de Locales (Estético)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(91, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(281, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Lista Alumnos (Estético)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ventanaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.taughtCoursesListButton);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaEmpleado";
            this.Text = "GestAcaMapache - Ventana Empleado";
            this.Load += new System.EventHandler(this.VentanaEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button taughtCoursesListButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}