namespace Cap7y8
{
    partial class Cap7e2Form
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
            this.Diclabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.DefiniciontextBox = new System.Windows.Forms.TextBox();
            this.Deflabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Diclabel
            // 
            this.Diclabel.AutoSize = true;
            this.Diclabel.Location = new System.Drawing.Point(137, 28);
            this.Diclabel.Name = "Diclabel";
            this.Diclabel.Size = new System.Drawing.Size(60, 13);
            this.Diclabel.TabIndex = 12;
            this.Diclabel.Text = "Diccionario";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(36, 62);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 11;
            this.Nombrelabel.Text = "Nombre";
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Items.AddRange(new object[] {
            "Agregar los Datos:"});
            this.ResultadolistBox.Location = new System.Drawing.Point(35, 180);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(268, 160);
            this.ResultadolistBox.TabIndex = 10;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(36, 78);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(171, 20);
            this.NombretextBox.TabIndex = 9;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(228, 108);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // DefiniciontextBox
            // 
            this.DefiniciontextBox.Location = new System.Drawing.Point(36, 139);
            this.DefiniciontextBox.Name = "DefiniciontextBox";
            this.DefiniciontextBox.Size = new System.Drawing.Size(172, 20);
            this.DefiniciontextBox.TabIndex = 13;
            // 
            // Deflabel
            // 
            this.Deflabel.AutoSize = true;
            this.Deflabel.Location = new System.Drawing.Point(36, 118);
            this.Deflabel.Name = "Deflabel";
            this.Deflabel.Size = new System.Drawing.Size(54, 13);
            this.Deflabel.TabIndex = 14;
            this.Deflabel.Text = "Definicion";
            // 
            // Cap7e2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 359);
            this.Controls.Add(this.Deflabel);
            this.Controls.Add(this.DefiniciontextBox);
            this.Controls.Add(this.Diclabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "Cap7e2Form";
            this.Text = "Cap7e2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Diclabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox DefiniciontextBox;
        private System.Windows.Forms.Label Deflabel;
    }
}