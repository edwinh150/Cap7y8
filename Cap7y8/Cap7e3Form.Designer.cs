namespace Cap7y8
{
    partial class Cap7e3Form
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
            this.Clientlabel = new System.Windows.Forms.Label();
            this.Clilabel = new System.Windows.Forms.Label();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.LlegadatextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Atenderbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clientlabel
            // 
            this.Clientlabel.AutoSize = true;
            this.Clientlabel.Location = new System.Drawing.Point(153, 37);
            this.Clientlabel.Name = "Clientlabel";
            this.Clientlabel.Size = new System.Drawing.Size(44, 13);
            this.Clientlabel.TabIndex = 12;
            this.Clientlabel.Text = "Clientes";
            // 
            // Clilabel
            // 
            this.Clilabel.AutoSize = true;
            this.Clilabel.Location = new System.Drawing.Point(52, 71);
            this.Clilabel.Name = "Clilabel";
            this.Clilabel.Size = new System.Drawing.Size(84, 13);
            this.Clilabel.TabIndex = 11;
            this.Clilabel.Text = "Agregar Clientes";
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Items.AddRange(new object[] {
            "Fila de Clientes:"});
            this.ResultadolistBox.Location = new System.Drawing.Point(51, 162);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(268, 160);
            this.ResultadolistBox.TabIndex = 10;
            // 
            // LlegadatextBox
            // 
            this.LlegadatextBox.Location = new System.Drawing.Point(52, 87);
            this.LlegadatextBox.Name = "LlegadatextBox";
            this.LlegadatextBox.Size = new System.Drawing.Size(171, 20);
            this.LlegadatextBox.TabIndex = 9;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(244, 84);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Atenderbutton
            // 
            this.Atenderbutton.Location = new System.Drawing.Point(244, 122);
            this.Atenderbutton.Name = "Atenderbutton";
            this.Atenderbutton.Size = new System.Drawing.Size(75, 23);
            this.Atenderbutton.TabIndex = 8;
            this.Atenderbutton.Text = "Atender";
            this.Atenderbutton.UseVisualStyleBackColor = true;
            this.Atenderbutton.Click += new System.EventHandler(this.Atenderbutton_Click);
            // 
            // Cap7e3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 358);
            this.Controls.Add(this.Clientlabel);
            this.Controls.Add(this.Clilabel);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.LlegadatextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Atenderbutton);
            this.Name = "Cap7e3Form";
            this.Text = "Cap7e3Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clientlabel;
        private System.Windows.Forms.Label Clilabel;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.TextBox LlegadatextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Atenderbutton;
    }
}