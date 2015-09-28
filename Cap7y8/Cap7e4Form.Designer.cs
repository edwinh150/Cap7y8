namespace Cap7y8
{
    partial class Cap7e4Form
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
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.CuentastextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultadolistBox = new System.Windows.Forms.ListBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(260, 70);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // CuentastextBox
            // 
            this.CuentastextBox.Location = new System.Drawing.Point(55, 72);
            this.CuentastextBox.Name = "CuentastextBox";
            this.CuentastextBox.Size = new System.Drawing.Size(189, 20);
            this.CuentastextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrar cuentas del mes";
            // 
            // ResultadolistBox
            // 
            this.ResultadolistBox.FormattingEnabled = true;
            this.ResultadolistBox.Location = new System.Drawing.Point(55, 142);
            this.ResultadolistBox.Name = "ResultadolistBox";
            this.ResultadolistBox.Size = new System.Drawing.Size(280, 212);
            this.ResultadolistBox.TabIndex = 3;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(155, 113);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 4;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Orden Cronologico";
            // 
            // Cap7e4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.ResultadolistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuentastextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "Cap7e4Form";
            this.Text = "Cap7e4Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox CuentastextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ResultadolistBox;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.Label label2;
    }
}