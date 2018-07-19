namespace PizzeriaSimple
{
    partial class Menu
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
            this.label2 = new System.Windows.Forms.Label();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtCuatro = new System.Windows.Forms.RadioButton();
            this.grbTamaño = new System.Windows.Forms.GroupBox();
            this.rbtDoce = new System.Windows.Forms.RadioButton();
            this.rbtDiez = new System.Windows.Forms.RadioButton();
            this.rbtOcho = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVariedad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.grbTamaño.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Pizzas";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(115, 51);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(92, 20);
            this.nupCantidad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tamaño";
            // 
            // rbtCuatro
            // 
            this.rbtCuatro.AutoSize = true;
            this.rbtCuatro.Location = new System.Drawing.Point(6, 19);
            this.rbtCuatro.Name = "rbtCuatro";
            this.rbtCuatro.Size = new System.Drawing.Size(80, 17);
            this.rbtCuatro.TabIndex = 4;
            this.rbtCuatro.TabStop = true;
            this.rbtCuatro.Text = "4 porciones";
            this.rbtCuatro.UseVisualStyleBackColor = true;
            // 
            // grbTamaño
            // 
            this.grbTamaño.Controls.Add(this.rbtDoce);
            this.grbTamaño.Controls.Add(this.rbtDiez);
            this.grbTamaño.Controls.Add(this.rbtOcho);
            this.grbTamaño.Controls.Add(this.rbtCuatro);
            this.grbTamaño.ImeMode = System.Windows.Forms.ImeMode.On;
            this.grbTamaño.Location = new System.Drawing.Point(115, 82);
            this.grbTamaño.Name = "grbTamaño";
            this.grbTamaño.Size = new System.Drawing.Size(135, 120);
            this.grbTamaño.TabIndex = 5;
            this.grbTamaño.TabStop = false;
            this.grbTamaño.Text = "Selecione";
            // 
            // rbtDoce
            // 
            this.rbtDoce.AutoSize = true;
            this.rbtDoce.Location = new System.Drawing.Point(6, 88);
            this.rbtDoce.Name = "rbtDoce";
            this.rbtDoce.Size = new System.Drawing.Size(86, 17);
            this.rbtDoce.TabIndex = 6;
            this.rbtDoce.TabStop = true;
            this.rbtDoce.Text = "12 porciones";
            this.rbtDoce.UseVisualStyleBackColor = true;
            // 
            // rbtDiez
            // 
            this.rbtDiez.AutoSize = true;
            this.rbtDiez.Location = new System.Drawing.Point(6, 65);
            this.rbtDiez.Name = "rbtDiez";
            this.rbtDiez.Size = new System.Drawing.Size(86, 17);
            this.rbtDiez.TabIndex = 6;
            this.rbtDiez.TabStop = true;
            this.rbtDiez.Text = "10 porciones";
            this.rbtDiez.UseVisualStyleBackColor = true;
            this.rbtDiez.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbtOcho
            // 
            this.rbtOcho.AutoSize = true;
            this.rbtOcho.Location = new System.Drawing.Point(6, 42);
            this.rbtOcho.Name = "rbtOcho";
            this.rbtOcho.Size = new System.Drawing.Size(80, 17);
            this.rbtOcho.TabIndex = 5;
            this.rbtOcho.TabStop = true;
            this.rbtOcho.Text = "8 porciones";
            this.rbtOcho.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Variedad";
            // 
            // cmbVariedad
            // 
            this.cmbVariedad.FormattingEnabled = true;
            this.cmbVariedad.Items.AddRange(new object[] {
            "Jamon y Palmitos",
            "4 Quesos",
            "Napolitana"});
            this.cmbVariedad.Location = new System.Drawing.Point(115, 210);
            this.cmbVariedad.Name = "cmbVariedad";
            this.cmbVariedad.Size = new System.Drawing.Size(121, 21);
            this.cmbVariedad.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(115, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(157, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 330);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbVariedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbTamaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.grbTamaño.ResumeLayout(false);
            this.grbTamaño.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtCuatro;
        private System.Windows.Forms.GroupBox grbTamaño;
        private System.Windows.Forms.RadioButton rbtDoce;
        private System.Windows.Forms.RadioButton rbtDiez;
        private System.Windows.Forms.RadioButton rbtOcho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVariedad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCliente;
    }
}