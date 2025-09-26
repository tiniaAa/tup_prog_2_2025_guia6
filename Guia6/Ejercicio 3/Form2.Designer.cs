namespace Ejercicio_3
{
    partial class Form2
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
            tbCUIT = new TextBox();
            tbNombre = new TextBox();
            CUIT = new Label();
            Nombre = new Label();
            rdbnFisica = new RadioButton();
            rdbnJuridica = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(124, 12);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(125, 27);
            tbCUIT.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(124, 102);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 1;
            // 
            // CUIT
            // 
            CUIT.AutoSize = true;
            CUIT.Location = new Point(12, 12);
            CUIT.Name = "CUIT";
            CUIT.Size = new Size(40, 20);
            CUIT.TabIndex = 2;
            CUIT.Text = "CUIT";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(3, 102);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(68, 20);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre ";
            // 
            // rdbnFisica
            // 
            rdbnFisica.AutoSize = true;
            rdbnFisica.Location = new Point(23, 203);
            rdbnFisica.Name = "rdbnFisica";
            rdbnFisica.Size = new Size(66, 24);
            rdbnFisica.TabIndex = 4;
            rdbnFisica.TabStop = true;
            rdbnFisica.Text = "Fisica";
            rdbnFisica.UseVisualStyleBackColor = true;
            // 
            // rdbnJuridica
            // 
            rdbnJuridica.AutoSize = true;
            rdbnJuridica.Location = new Point(137, 203);
            rdbnJuridica.Name = "rdbnJuridica";
            rdbnJuridica.Size = new Size(80, 24);
            rdbnJuridica.TabIndex = 5;
            rdbnJuridica.TabStop = true;
            rdbnJuridica.Text = "Juridica";
            rdbnJuridica.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(6, 233);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(155, 233);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(237, 53);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(237, 53);
            label2.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 280);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rdbnJuridica);
            Controls.Add(rdbnFisica);
            Controls.Add(Nombre);
            Controls.Add(CUIT);
            Controls.Add(tbNombre);
            Controls.Add(tbCUIT);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbCUIT;
        public TextBox tbNombre;
        public Label CUIT;
        public Label Nombre;
        public RadioButton rdbnFisica;
        public RadioButton rdbnJuridica;
        public Button button1;
        public Button button2;
        public Label label1;
        public Label label2;
    }
}