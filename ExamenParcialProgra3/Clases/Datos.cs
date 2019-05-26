using ExamenParcialProgra3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcialProgra3.Clases
{
    public class Datos : IOperaciones
    {

         

        //encapsulamiento
        private int Id;
        private string NombreEmpleado;
        private string TipodeEquipo;
        private string Marca;
        private string Procesador;
        private string DiscoDuro;
        private string SistemaOperativo;


        //constructor
        public Datos(int Id, string NombreEmpleado, string TipodeEquipo, string Marca, string Procesador, string DiscoDuro, string SistemaOperativo)
        {
            this.Id = Id;
            this.NombreEmpleado = NombreEmpleado;
            this.TipodeEquipo = TipodeEquipo;
            this.Marca = Marca;
            this.Procesador = Procesador;
            this.DiscoDuro = DiscoDuro;
            this.SistemaOperativo = SistemaOperativo;
        }

        public int id 
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string nombreempleado
        {
            get
            {
                return NombreEmpleado;
            }

            set
            {
                NombreEmpleado = value;
            }
        }

        public string tipodeequipo
        {
            get
            {
                return TipodeEquipo;
            }

            set
            {
                TipodeEquipo = value;
            }
        }
        public string marca
        {
            get
            {
                return Marca;
            }

            set
            {
                Marca = value;
            }
        }
        public string procesador
        {
            get
            {
                return Procesador;
            }

            set
            {
                Procesador = value;
            }
        }
        public string discoduro
        {
            get
            {
                return DiscoDuro;
            }

            set
            {
                DiscoDuro = value;
            }
        }
        public string sistemaoperativo
        {
            get
            {
                return SistemaOperativo;
            }

            set
            {
                SistemaOperativo = value;
            }
        }

        public string busqueda(string consulta)
        {
            
            return consulta;
        }

       
       
    }
}
