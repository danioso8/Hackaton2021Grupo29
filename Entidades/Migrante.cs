using System;

namespace Emigrant.App.Dominio
{
    public class Migrante
    {
            
            public id grupo {set;get; }
            public id persona { get; set; }            
            public string Nombre { get; set; }            
            public string Apellidos { get; set; }            
            public string TipoDocumento { get; set; }         
            public string PaisOrigen { get; set; }         
            public DateTime FechaNacimiento { get; set; }        
            public string CorreoElectronico { get; set; }    
            public string Telefono { get; set; }
            public string DireccionActual { get; set; }
            public string Ciudad { get; set; }
            public enum SituacionLaboral {
                empleado,
                desempleado,
                independiente
            }
            public int numeroDocumento{set;get;}
    }
}