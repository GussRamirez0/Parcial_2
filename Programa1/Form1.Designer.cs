namespace Programa1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtint = new System.Windows.Forms.TextBox();
            this.txtperi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcap = new System.Windows.Forms.TextBox();
            this.txtacu = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(15, 53);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(100, 20);
            this.txtmonto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto Inicial";
            // 
            // txtint
            // 
            this.txtint.Location = new System.Drawing.Point(15, 126);
            this.txtint.Name = "txtint";
            this.txtint.Size = new System.Drawing.Size(100, 20);
            this.txtint.TabIndex = 2;
            // 
            // txtperi
            // 
            this.txtperi.Location = new System.Drawing.Point(15, 191);
            this.txtperi.Name = "txtperi";
            this.txtperi.Size = new System.Drawing.Size(100, 20);
            this.txtperi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasa interes Anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Periodo de tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capital Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Intereses acumulados";
            // 
            // txtcap
            // 
            this.txtcap.Location = new System.Drawing.Point(221, 126);
            this.txtcap.Name = "txtcap";
            this.txtcap.Size = new System.Drawing.Size(100, 20);
            this.txtcap.TabIndex = 8;
            // 
            // txtacu
            // 
            this.txtacu.Location = new System.Drawing.Point(221, 190);
            this.txtacu.Name = "txtacu";
            this.txtacu.Size = new System.Drawing.Size(100, 20);
            this.txtacu.TabIndex = 9;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(348, 122);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(152, 89);
            this.btncalc.TabIndex = 10;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 277);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtacu);
            this.Controls.Add(this.txtcap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtperi);
            this.Controls.Add(this.txtint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmonto);
            this.Name = "Form1";
            this.Text = "Programa 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtint;
        private System.Windows.Forms.TextBox txtperi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcap;
        private System.Windows.Forms.TextBox txtacu;
        private System.Windows.Forms.Button btncalc;
    }
}

