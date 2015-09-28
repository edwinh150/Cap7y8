namespace Cap7y8
{
    partial class Cap8e5Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cadena1textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cadena2textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadenas Ordenacion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Cadena1textBox
            // 
            this.Cadena1textBox.Location = new System.Drawing.Point(23, 85);
            this.Cadena1textBox.Name = "Cadena1textBox";
            this.Cadena1textBox.Size = new System.Drawing.Size(136, 20);
            this.Cadena1textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Primera Cadena";
            // 
            // Cadena2textBox
            // 
            this.Cadena2textBox.Location = new System.Drawing.Point(195, 85);
            this.Cadena2textBox.Name = "Cadena2textBox";
            this.Cadena2textBox.Size = new System.Drawing.Size(136, 20);
            this.Cadena2textBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Segunda Cadena";
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Location = new System.Drawing.Point(23, 166);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(308, 147);
            this.ResultadolistBox.TabIndex = 2;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(140, 137);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 3;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // Cap8e5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 325);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.Cadena1textBox);
            this.Controls.Add(this.Cadena2textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Cap8e5Form";
            this.Text = "Cap8e5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Cadena1textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cadena2textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.Button Mostrarbutton;
    }
}