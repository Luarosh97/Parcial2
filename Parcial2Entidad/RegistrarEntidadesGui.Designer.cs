namespace Parcial2Entidad
{
    partial class RegistrarEntidadesGui
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
            this.label3 = new System.Windows.Forms.Label();
            this.valorPagadotxt = new System.Windows.Forms.TextBox();
            this.NumeroRegistrotxt = new System.Windows.Forms.TextBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NumeroRegistro";
            // 
            // valorPagadotxt
            // 
            this.valorPagadotxt.Location = new System.Drawing.Point(161, 203);
            this.valorPagadotxt.Name = "valorPagadotxt";
            this.valorPagadotxt.Size = new System.Drawing.Size(100, 20);
            this.valorPagadotxt.TabIndex = 7;
            // 
            // NumeroRegistrotxt
            // 
            this.NumeroRegistrotxt.Location = new System.Drawing.Point(181, 142);
            this.NumeroRegistrotxt.Name = "NumeroRegistrotxt";
            this.NumeroRegistrotxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroRegistrotxt.TabIndex = 8;
            // 
            // DtFecha
            // 
            this.DtFecha.Location = new System.Drawing.Point(181, 82);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(200, 20);
            this.DtFecha.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ValorPagado";
            // 
            // TipoCombo
            // 
            this.TipoCombo.FormattingEnabled = true;
            this.TipoCombo.Items.AddRange(new object[] {
            "Electricaribe",
            "Emdupar",
            "GasCaribe"});
            this.TipoCombo.Location = new System.Drawing.Point(152, 37);
            this.TipoCombo.Name = "TipoCombo";
            this.TipoCombo.Size = new System.Drawing.Size(121, 21);
            this.TipoCombo.TabIndex = 12;
            // 
            // RegistrarEntidadesGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 409);
            this.Controls.Add(this.TipoCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.NumeroRegistrotxt);
            this.Controls.Add(this.valorPagadotxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarEntidadesGui";
            this.Text = "RegistrarEntidadesGui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valorPagadotxt;
        private System.Windows.Forms.TextBox NumeroRegistrotxt;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoCombo;
    }
}