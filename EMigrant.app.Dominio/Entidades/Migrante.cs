using System;

namespace EMigrant.App.Dominio
{
    public class Migrante
    {                  
        public int id { get; set; }            
        public string nombre { get; set; }   
        public string apellidos { get; set; }            
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }       
        public string paisOrigen { get; set; }
        public DateTime fechaNacimiento { get; set; }        
        public string correoElectronico { get; set; }        
        public string telefono { get; set; }
        public string DireccionActual { get; set; }           
        public string Ciudad { get; set; }
        public SituacionLaboral SituacionLaboral { get; set; }
    }
}