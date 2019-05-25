using ExamenParcialProgra3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcialProgra3
{
    public partial class Form1 : Form
    {
        // Se crea el objeto conexion para que se obtegan los datos
        Conexion con = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //llamo al metodo actualizargrid
            this.ActualizarGrid();
        }


        // Metodo para actualizar datagridview
        public void ActualizarGrid()
        {
            // Aca se hace una funcion (select) para mostrar los datos
            con.ActualizarGrid(this.dataGridView1, "Select * from DatosTBL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se crea el objeto dato


            Datos d = new Datos
           (
                Convert.ToInt32(textBox1.Text),
                textBox2.Text,
                comboBox1.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text
               
           );




            con.Conectar();

            //Se crea una consulta para insertar los datos (Guardar)
            string consulta = "insert into DatosTBL (Id,NombreEmpleado,TipodeEquipo,Marca,Procesador,DiscoDuro,SistemaOperativo) " +
                "values (" + d.id + ", '" + d.nombreempleado + "','" + d.tipodeequipo + "','" + d.marca + "','" + d.procesador + "'," + d.discoduro + ",'" + d.sistemaoperativo + "' );";

            //con esta funcion ejecuto la consulta de arriba en codigo sql
            con.EjecutarSql(consulta);
            this.ActualizarGrid();
            con.Desconectar();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            

        }
    }
}
