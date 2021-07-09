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
    public partial class LINQ : Form
    {
        public LINQ()
        {
            InitializeComponent();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            //Lista de Valores Y obtener suma de esa Lista
            List<int> ListaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int suma = 0;

            foreach (var item in ListaDeValores)
            {
                suma += item;
            }

            MessageBox.Show(suma.ToString());

        }

        private void btn_sumaLINQ_Click(object sender, EventArgs e)
        {
            List<int> ListaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int suma = ListaDeValores.Sum();

            MessageBox.Show(suma.ToString());
        }

        private void btn_NumPares_Click(object sender, EventArgs e)
        {
            List<int> ListaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> ListaDeValores2 = new List<int> { 2, 14, 13, 28, 15, 11, 22, 34, 77, 90 };

            foreach (var item in ListaDeValores2)
            {
                if(item % 2 == 0)
                {
                    CB_valores.Items.Add(item);
                }
            }
        }

        private void btn_NumParesLINQ_Click(object sender, EventArgs e)
        {
            List<int> ListaDeValores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> ListaDeValores2 = new List<int> { 2, 14, 13, 28, 15, 11, 22, 34, 77, 90 };

            CB_valores.DataSource = ListaDeValores.Where(a => a % 2 == 0).ToList();
        }
    }
}
