using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.App.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string password { get; set; }//modificar a privado
        public string Nombre { get; set; }
        //CEDULA debe ser un int para que funcione bien IRepositorios
        public int Cedula { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        

    }
}