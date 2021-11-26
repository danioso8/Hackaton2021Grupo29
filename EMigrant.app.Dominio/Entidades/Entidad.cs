using System;

namespace EMigrant.App.Dominio
{
    public class Entidad
    {
        public int id{set;get;}
        public string razonSocial{set;get;}
        public string nit{set;get;}
        public string direccion{set;get;}
        public string ciudad {set;get;}
        public string telefono{set;get;}
        public string correoElectronico{set;get;}
        public string paginaWeb{set;get;}
        public SectorEntidad sectorEntidad {get; set;}
        public ServiciosEntidad serviciosEntidad {get; set;}
    }
}