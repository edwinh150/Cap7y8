namespace Cap7y8
{
    partial class Cap7e1Form
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
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.CalificacionestextBox = new System.Windows.Forms.TextBox();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Calilabel = new System.Windows.Forms.Label();
            this.Prolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(232, 115);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 0;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // CalificacionestextBox
            // 
            this.CalificacionestextBox.Location = new System.Drawing.Point(40, 80);
            this.CalificacionestextBox.Name = "CalificacionestextBox";
            this.CalificacionestextBox.Size = new System.Drawing.Size(171, 20);
            this.CalificacionestextBox.TabIndex = 2;
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Items.AddRange(new object[] {
            "Agregar los Datos:"});
            this.ResultadolistBox.Location = new System.Drawing.Point(39, 155);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(268, 160);
            this.ResultadolistBox.TabIndex = 3;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(232, 77);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Calilabel
            // 
            this.Calilabel.AutoSize = true;
            this.Calilabel.Location = new System.Drawing.Point(40, 64);
            this.Calilabel.Name = "Calilabel";
            this.Calilabel.Size = new System.Drawing.Size(72, 13);
            this.Calilabel.TabIndex = 5;
            this.Calilabel.Text = "Calificaciones";
            // 
            // Prolabel
            // 
            this.Prolabel.AutoSize = true;
            this.Prolabel.Location = new System.Drawing.Point(141, 30);
            this.Prolabel.Name = "Prolabel";
            this.Prolabel.Size = new System.Drawing.Size(51, 13);
            this.Prolabel.TabIndex = 6;
            this.Prolabel.Text = "Promedio";
            // 
            // Cap7e1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 346);
            this.Controls.Add(this.Prolabel);
            this.Controls.Add(this.Calilabel);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.CalificacionestextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Mostrarbutton);
            this.Name = "Cap7e1Form";
            this.Text = "Cap7e1";
            this.Load += new System.EventHandler(this.Cap7e1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.TextBox CalificacionestextBox;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label Calilabel;
        private System.Windows.Forms.Label Prolabel;
    }
}