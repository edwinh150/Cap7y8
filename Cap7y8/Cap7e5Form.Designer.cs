namespace Cap7y8
{
    partial class Cap7e5Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Numerolabel = new System.Windows.Forms.Label();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ContactosdataGridView = new System.Windows.Forms.DataGridView();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 352);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Numerolabel);
            this.tabPage1.Controls.Add(this.NumerotextBox);
            this.tabPage1.Controls.Add(this.Agelabel);
            this.tabPage1.Controls.Add(this.Nombrelabel);
            this.tabPage1.Controls.Add(this.NombretextBox);
            this.tabPage1.Controls.Add(this.Guardarbutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Numerolabel
            // 
            this.Numerolabel.AutoSize = true;
            this.Numerolabel.Location = new System.Drawing.Point(89, 144);
            this.Numerolabel.Name = "Numerolabel";
            this.Numerolabel.Size = new System.Drawing.Size(44, 13);
            this.Numerolabel.TabIndex = 33;
            this.Numerolabel.Text = "Numero";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(89, 165);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(172, 20);
            this.NumerotextBox.TabIndex = 32;
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(153, 54);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(44, 13);
            this.Agelabel.TabIndex = 31;
            this.Agelabel.Text = "Agenda";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(89, 88);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 30;
            this.Nombrelabel.Text = "Nombre";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(89, 104);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(171, 20);
            this.NombretextBox.TabIndex = 29;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(142, 224);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 28;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Mostrarbutton);
            this.tabPage2.Controls.Add(this.ContactosdataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(360, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ContactosdataGridView
            // 
            this.ContactosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombres,
            this.Telefono});
            this.ContactosdataGridView.Location = new System.Drawing.Point(3, 28);
            this.ContactosdataGridView.Name = "ContactosdataGridView";
            this.ContactosdataGridView.Size = new System.Drawing.Size(351, 296);
            this.ContactosdataGridView.TabIndex = 1;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(221, 3);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(133, 23);
            this.Mostrarbutton.TabIndex = 2;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 130;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 180;
            // 
            // Cap7e5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 376);
            this.Controls.Add(this.tabControl1);
            this.Name = "Cap7e5Form";
            this.Text = "AgregarForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactosdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label Numerolabel;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ContactosdataGridView;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}