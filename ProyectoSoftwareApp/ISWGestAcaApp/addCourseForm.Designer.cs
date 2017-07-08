namespace ISWGestAcaApp
{
    partial class addCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCourseForm));
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IdErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(197, 237);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 0;
            this.cancelarBtn.Tag = "cancelarBtn";
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(91, 237);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 1;
            this.aceptarBtn.Tag = "aceptarBtn";
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(35, 72);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(50, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "Nombre :";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(63, 38);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(22, 13);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "Id :";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(16, 100);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(69, 13);
            this.descripcionLabel.TabIndex = 4;
            this.descripcionLabel.Text = "Descripcion :";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(91, 35);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(181, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(91, 68);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(181, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // descripcionRichTextBox
            // 
            this.descripcionRichTextBox.Location = new System.Drawing.Point(92, 100);
            this.descripcionRichTextBox.Name = "descripcionRichTextBox";
            this.descripcionRichTextBox.Size = new System.Drawing.Size(180, 96);
            this.descripcionRichTextBox.TabIndex = 7;
            this.descripcionRichTextBox.Text = "";
            // 
            // IdErrorLabel
            // 
            this.IdErrorLabel.AutoSize = true;
            this.IdErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.IdErrorLabel.Location = new System.Drawing.Point(63, 13);
            this.IdErrorLabel.Name = "IdErrorLabel";
            this.IdErrorLabel.Size = new System.Drawing.Size(197, 13);
            this.IdErrorLabel.TabIndex = 8;
            this.IdErrorLabel.Text = "*El campo Id debe ser un número entero";
            this.IdErrorLabel.Visible = false;
            // 
            // addCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 283);
            this.Controls.Add(this.IdErrorLabel);
            this.Controls.Add(this.descripcionRichTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.cancelarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addCourseForm";
            this.Text = "addCourseForm - GestAcaMapache";
            this.Load += new System.EventHandler(this.addCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.RichTextBox descripcionRichTextBox;
        private System.Windows.Forms.Label IdErrorLabel;
    }
}