namespace Formulario
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lb_apellidos = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_estatura = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_estatura = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.gpbx_genero = new System.Windows.Forms.GroupBox();
            this.rd_mujer = new System.Windows.Forms.RadioButton();
            this.rd_Hombre = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.gpbx_genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(50, 28);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(122, 20);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(199, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lb_apellidos
            // 
            this.lb_apellidos.AutoSize = true;
            this.lb_apellidos.Location = new System.Drawing.Point(50, 56);
            this.lb_apellidos.Name = "lb_apellidos";
            this.lb_apellidos.Size = new System.Drawing.Size(49, 13);
            this.lb_apellidos.TabIndex = 2;
            this.lb_apellidos.Text = "Apellidos";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(50, 91);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefono.TabIndex = 3;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // lbl_estatura
            // 
            this.lbl_estatura.AutoSize = true;
            this.lbl_estatura.Location = new System.Drawing.Point(50, 124);
            this.lbl_estatura.Name = "lbl_estatura";
            this.lbl_estatura.Size = new System.Drawing.Size(46, 13);
            this.lbl_estatura.TabIndex = 4;
            this.lbl_estatura.Text = "Estatura";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(122, 53);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(199, 20);
            this.txt_apellidos.TabIndex = 5;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(122, 84);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(199, 20);
            this.txt_telefono.TabIndex = 6;
            // 
            // txt_estatura
            // 
            this.txt_estatura.Location = new System.Drawing.Point(122, 121);
            this.txt_estatura.Name = "txt_estatura";
            this.txt_estatura.Size = new System.Drawing.Size(199, 20);
            this.txt_estatura.TabIndex = 7;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(122, 157);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(199, 20);
            this.txt_edad.TabIndex = 9;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(50, 160);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(32, 13);
            this.lbl_edad.TabIndex = 8;
            this.lbl_edad.Text = "Edad";
            // 
            // gpbx_genero
            // 
            this.gpbx_genero.Controls.Add(this.rd_mujer);
            this.gpbx_genero.Controls.Add(this.rd_Hombre);
            this.gpbx_genero.Location = new System.Drawing.Point(122, 195);
            this.gpbx_genero.Name = "gpbx_genero";
            this.gpbx_genero.Size = new System.Drawing.Size(200, 60);
            this.gpbx_genero.TabIndex = 10;
            this.gpbx_genero.TabStop = false;
            this.gpbx_genero.Text = "Género";
            // 
            // rd_mujer
            // 
            this.rd_mujer.AutoSize = true;
            this.rd_mujer.Location = new System.Drawing.Point(98, 34);
            this.rd_mujer.Name = "rd_mujer";
            this.rd_mujer.Size = new System.Drawing.Size(51, 17);
            this.rd_mujer.TabIndex = 1;
            this.rd_mujer.TabStop = true;
            this.rd_mujer.Text = "Mujer";
            this.rd_mujer.UseVisualStyleBackColor = true;
            // 
            // rd_Hombre
            // 
            this.rd_Hombre.AutoSize = true;
            this.rd_Hombre.Location = new System.Drawing.Point(7, 34);
            this.rd_Hombre.Name = "rd_Hombre";
            this.rd_Hombre.Size = new System.Drawing.Size(62, 17);
            this.rd_Hombre.TabIndex = 0;
            this.rd_Hombre.TabStop = true;
            this.rd_Hombre.Text = "Hombre";
            this.rd_Hombre.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(122, 293);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(199, 42);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(122, 354);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(199, 42);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(327, 293);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(79, 42);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.gpbx_genero);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.txt_estatura);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lbl_estatura);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lb_apellidos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbx_genero.ResumeLayout(false);
            this.gpbx_genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lb_apellidos;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_estatura;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_estatura;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.GroupBox gpbx_genero;
        private System.Windows.Forms.RadioButton rd_mujer;
        private System.Windows.Forms.RadioButton rd_Hombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_limpiar;
    }
}

