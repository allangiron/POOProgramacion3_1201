using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOProgramacion3_1201
{
    public partial class POOClaseUno : Form
    {
        public POOClaseUno()
        {
            InitializeComponent();
        }

        private void Btn_probar_Click(object sender, EventArgs e)
        {
            //Persona Norma = new Persona();

            //Norma.Nombre = Txt_nombre.Text;
            //Norma.Apellido = Txt_apellido.Text;
            //Norma.Edad = Convert.ToInt32(Txt_edad.Text);
            //Norma.Direccion = Txt_direccion.Text;

            //MessageBox.Show(" Nombre Completo: " + Norma.DevolverNombreCompleto());
            //MessageBox.Show(" Edad y Dirección: " + Norma.DevolverDireccion());

            Persona Allan = new Persona(Txt_nombre.Text, Txt_apellido.Text, Convert.ToInt32(Txt_edad.Text), Txt_direccion.Text);
            MessageBox.Show(Allan.DevolverNombreCompleto());
            MessageBox.Show(Allan.DevolverDireccion());
        }
    }
}
