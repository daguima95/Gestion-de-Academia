namespace ISWGestAcaApp
{
    partial class formularioMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioMatricula));
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.iBANLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.iBANTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(26, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(60, 26);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Nombre \r\ny Apellidos:";
            this.lastNameLabel.Click += new System.EventHandler(this.lastNameLabel_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(26, 55);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(29, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "DNI:";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(26, 124);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(55, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Dirección:";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(26, 158);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(75, 13);
            this.zipCodeLabel.TabIndex = 4;
            this.zipCodeLabel.Text = "Código Postal:";
            this.zipCodeLabel.Click += new System.EventHandler(this.zipCodeLabel_Click);
            // 
            // iBANLabel
            // 
            this.iBANLabel.AutoSize = true;
            this.iBANLabel.Location = new System.Drawing.Point(26, 191);
            this.iBANLabel.Name = "iBANLabel";
            this.iBANLabel.Size = new System.Drawing.Size(35, 13);
            this.iBANLabel.TabIndex = 5;
            this.iBANLabel.Text = "IBAN:";
            this.iBANLabel.Click += new System.EventHandler(this.iBANLabel_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(86, 238);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Aceptar";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(226, 238);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(102, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(256, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(102, 52);
            this.idTextBox.MaxLength = 9;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 10;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(102, 121);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(224, 20);
            this.addressTextBox.TabIndex = 11;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(102, 155);
            this.zipCodeTextBox.MaxLength = 300;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(75, 20);
            this.zipCodeTextBox.TabIndex = 12;
            this.zipCodeTextBox.Text = "00000";
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.zipCodeTextBox_TextChanged);
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCodeTextBox_KeyPress);
            // 
            // iBANTextBox
            // 
            this.iBANTextBox.Location = new System.Drawing.Point(102, 188);
            this.iBANTextBox.MaxLength = 24;
            this.iBANTextBox.Name = "iBANTextBox";
            this.iBANTextBox.Size = new System.Drawing.Size(199, 20);
            this.iBANTextBox.TabIndex = 13;
            this.iBANTextBox.TextChanged += new System.EventHandler(this.iBANTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Por favor rellene toda la información a continuación:";
            // 
            // formularioMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 290);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iBANTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.iBANLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formularioMatricula";
            this.Text = "GestAcaMapache - Formulario Mátricula";
            this.Load += new System.EventHandler(this.formularioInscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label iBANLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox iBANTextBox;
        private System.Windows.Forms.Label label7;
    }
}