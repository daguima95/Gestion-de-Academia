namespace ISWGestAcaApp
{
    partial class introducirDNI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introducirDNI));
            this.botonA = new System.Windows.Forms.Button();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_vacio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonA
            // 
            this.botonA.Location = new System.Drawing.Point(97, 234);
            this.botonA.Name = "botonA";
            this.botonA.Size = new System.Drawing.Size(75, 23);
            this.botonA.TabIndex = 0;
            this.botonA.Text = "Aceptar";
            this.botonA.UseVisualStyleBackColor = true;
            this.botonA.Click += new System.EventHandler(this.botonA_Click);
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(74, 171);
            this.textBoxDNI.MaxLength = 9;
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(125, 20);
            this.textBoxDNI.TabIndex = 1;
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ahora introduce DNI del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(206, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "El curso seleccionado es:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_vacio
            // 
            this.label_vacio.AutoSize = true;
            this.label_vacio.BackColor = System.Drawing.SystemColors.Control;
            this.label_vacio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_vacio.Location = new System.Drawing.Point(12, 59);
            this.label_vacio.Name = "label_vacio";
            this.label_vacio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.label_vacio.Size = new System.Drawing.Size(35, 13);
            this.label_vacio.TabIndex = 4;
            // 
            // introducirDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 311);
            this.Controls.Add(this.label_vacio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.botonA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "introducirDNI";
            this.Text = "Introducir DNI";
            this.Load += new System.EventHandler(this.introducirDNI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonA;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_vacio;
    }
}