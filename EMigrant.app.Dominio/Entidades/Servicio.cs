using System;

namespace EMigrant.App.Dominio
{
    public class Servicios{
    public int id {set;get;}
    public string nombreServicios{set;get;}
    //maximo numero de migrantes = MNDM
    public int MNDM{set;get;}
    public DateTime fechaFinalizacion{set;get;}
    public DateTime fechaDeInicio{set;get;}
    public SectorEntidad sectorEntidad {get; set;}
    public string descripcion{set;get;}
    public Entidad entidad {set;get;}
}
}