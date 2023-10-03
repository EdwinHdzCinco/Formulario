namespace Practica2
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
            this.txt_F = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.btn_FC = new System.Windows.Forms.Button();
            this.btn_CF = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_F
            // 
            this.txt_F.Location = new System.Drawing.Point(79, 55);
            this.txt_F.Name = "txt_F";
            this.txt_F.Size = new System.Drawing.Size(100, 20);
            this.txt_F.TabIndex = 0;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(328, 55);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(100, 20);
            this.txt_C.TabIndex = 1;
            // 
            // btn_FC
            // 
            this.btn_FC.Location = new System.Drawing.Point(217, 55);
            this.btn_FC.Name = "btn_FC";
            this.btn_FC.Size = new System.Drawing.Size(75, 23);
            this.btn_FC.TabIndex = 2;
            this.btn_FC.Text = "F ---> C";
            this.btn_FC.UseVisualStyleBackColor = true;
            this.btn_FC.Click += new System.EventHandler(this.btn_FC_Click);
            // 
            // btn_CF
            // 
            this.btn_CF.Location = new System.Drawing.Point(217, 84);
            this.btn_CF.Name = "btn_CF";
            this.btn_CF.Size = new System.Drawing.Size(75, 23);
            this.btn_CF.TabIndex = 3;
            this.btn_CF.Text = "C ----> F";
            this.btn_CF.UseVisualStyleBackColor = true;
            this.btn_CF.Click += new System.EventHandler(this.btn_CF_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(217, 113);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_CF);
            this.Controls.Add(this.btn_FC);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_F;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.Button btn_FC;
        private System.Windows.Forms.Button btn_CF;
        private System.Windows.Forms.Button btn_clear;
    }
}

