using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Txt_edad_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string nombres = txt_nombre.Text, apellidos = txt_apellidos.Text, 
                edad = txt_edad.Text, estatura = txt_estatura.Text, telefono = txt_telefono.Text,
                genero = "";
            if (rd_Hombre.Checked)
            {
                genero = "Hombre";
            } else if (rd_mujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres :{nombres}\r\nApellidos:{apellidos}\r\nTelefono:{telefono}\r\nEstatura:{estatura}\r\nEdad:{edad}";
            string rutaArchivo = "C:/Users/ed231/Documents/Unach/3 M/Programacion Avanzada/datos.txt";

            bool archivoExiste = File.Exists(rutaArchivo);

            if (!archivoExiste)
            {
                File.WriteAllText(rutaArchivo, datos);
            } else
            {
                using (StreamWriter wirter = new StreamWriter(rutaArchivo, true)) 
                {
                    if (archivoExiste)
                    {
                        wirter.WriteLine();
                    }
                    wirter.WriteLine(datos);
                }
            }
            MessageBox.Show("Datos guardados con éxito:\n\n" +  datos, "Información ", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_apellidos.Text = "";
            txt_edad.Text = "";
            txt_estatura.Text = "";
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            rd_Hombre.Checked = false;
            rd_mujer.Checked = false;

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {            
        }
    }
}
