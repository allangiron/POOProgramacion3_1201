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

        List<Persona> persoLista = new List<Persona>();

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

        private void Btn_lista_Click(object sender, EventArgs e)
        {
            List<string> personas = new List<string>();

            personas.Add("Allan");
            personas.Add("Norma");
            personas.Add("Gustavo");
            personas.Add("Adita");
            personas.Add("Ana");

            foreach (var item in personas)
            {
                MessageBox.Show(item);
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            //Agregar al dataGridView
            Persona persona = new Persona(Txt_nombre.Text, Txt_apellido.Text, Convert.ToInt32(Txt_edad.Text),Txt_direccion.Text);

            persoLista.Add(persona);

            DGV_listaPersonas.DataSource = null;
            DGV_listaPersonas.DataSource = persoLista;

            //Limpiar TextBox
            Txt_nombre.Clear();
            Txt_apellido.Clear();
            Txt_edad.Clear();
            Txt_direccion.Clear();

        }


        //LINQ
        private void btn_mayoresEdad_Click(object sender, EventArgs e)
        {
            var ListaTemporal = persoLista.Where(a => a.Edad >= 18).ToList();

            foreach (var item in ListaTemporal)
            {
                CB_mayoresEdad.Items.Add(item.Nombre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ListaTemporal = persoLista.Where(a => a.Edad <= 18).ToList();

            foreach (var item in ListaTemporal)
            {
                CB_menoresEdad.Items.Add(item.Nombre);
            }
        }
    }
}
