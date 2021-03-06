using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLibreria;
using System.Threading;

namespace AppLibreria
{
    public partial class Form2 : Form
    {

        List<Libro> listaLibros = new List<Libro>() {

            new Libro(){sNombreLibro= "Yo Antes de ti", sNombreAutor= "Yoyo Moyes", dPrecio= 250.00,nc=4  },
            new Libro(){sNombreLibro= "Harry Potter la Piedra Filosofal", sNombreAutor="J.K Rowling", dPrecio= 300.00,nc=1 },
            new Libro(){sNombreLibro= "El Senor de los anillos", sNombreAutor="J.R.R Tokien", dPrecio= 325.00,nc=2 },
            new Libro(){sNombreLibro= "El Diario de Ana Frank", sNombreAutor="Anna Frank", dPrecio= 150.00,nc=2 },
            new Libro(){sNombreLibro= "El Alquimista", sNombreAutor="Paulo Coelho", dPrecio= 150.00,nc=10 },
            new Libro(){sNombreLibro= "Historia de dos Ciudades", sNombreAutor="Charles Dickens", dPrecio= 355.00,nc=4 },
            new Libro(){sNombreLibro= "El Principito", sNombreAutor="Antonie de SaintExupery", dPrecio=250.00,nc=5 },
            new Libro(){sNombreLibro= "Alicia en el Pais de las Maravillas", sNombreAutor="Lewis Carroll", dPrecio=250.50,nc=10 },
            new Libro(){sNombreLibro= "Cien anios de Soledad", sNombreAutor="Gabriel Garcia Marquez", dPrecio=199.99,nc=12 },
            new Libro(){sNombreLibro= "El Conde de MonteCristo", sNombreAutor="Alexandre Dumas", dPrecio=299.99,nc=2 },
            };

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            foreach (Libro book in listaLibros)
            {
                string strmin = book.sNombreLibro;
                string strminus = strmin.ToLower();
                Console.WriteLine(strminus);


                string txtmin = txtNombreLibro.Text;
                string min = txtmin.ToLower();

                if (min != strminus)
                {
                    lblDisponible.Text = ("No se encuentra el libro");
                    lblCopias.Text = "0";
                }
                else
                {
                    lblDisponible.Text = ("Libro disponible");
                    lblCopias.Text = Convert.ToString(book.nc);

                    lblDatos.Text =("Nombre del Libro: "+book.sNombreLibro+"\nAutor: "+ book.sNombreAutor + "\nPrecio: $" + Convert.ToString(book.dPrecio)); 
                     break;
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreLibro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago Realizado Exitosamente");
            Thread.Sleep(3000);
            MessageBox.Show("Pedido Empacado");
            Thread.Sleep(3000);
            MessageBox.Show("Pedido Enviado");
        }
    }
}
