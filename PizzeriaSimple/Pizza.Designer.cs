namespace PizzeriaSimple
{
    partial class Pizza
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
            this.chkPimiento = new System.Windows.Forms.CheckBox();
            this.chkAceituna = new System.Windows.Forms.CheckBox();
            this.chkChampiñon = new System.Windows.Forms.CheckBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkPimiento
            // 
            this.chkPimiento.AutoSize = true;
            this.chkPimiento.Location = new System.Drawing.Point(90, 97);
            this.chkPimiento.Name = "chkPimiento";
            this.chkPimiento.Size = new System.Drawing.Size(66, 17);
            this.chkPimiento.TabIndex = 0;
            this.chkPimiento.Text = "Pimiento";
            this.chkPimiento.UseVisualStyleBackColor = true;
            // 
            // chkAceituna
            // 
            this.chkAceituna.AutoSize = true;
            this.chkAceituna.Location = new System.Drawing.Point(90, 120);
            this.chkAceituna.Name = "chkAceituna";
            this.chkAceituna.Size = new System.Drawing.Size(73, 17);
            this.chkAceituna.TabIndex = 1;
            this.chkAceituna.Text = "Aceitunas";
            this.chkAceituna.UseVisualStyleBackColor = true;
            // 
            // chkChampiñon
            // 
            this.chkChampiñon.AutoSize = true;
            this.chkChampiñon.Location = new System.Drawing.Point(90, 143);
            this.chkChampiñon.Name = "chkChampiñon";
            this.chkChampiñon.Size = new System.Drawing.Size(90, 17);
            this.chkChampiñon.TabIndex = 2;
            this.chkChampiñon.Text = "Champiñones";
            this.chkChampiñon.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "En Molde",
            "A la Piedra",
            "A la Parrilla"});
            this.cmbTipo.Location = new System.Drawing.Point(90, 32);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(80, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "FinalizarPedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.chkChampiñon);
            this.Controls.Add(this.chkAceituna);
            this.Controls.Add(this.chkPimiento);
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPimiento;
        private System.Windows.Forms.CheckBox chkAceituna;
        private System.Windows.Forms.CheckBox chkChampiñon;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}