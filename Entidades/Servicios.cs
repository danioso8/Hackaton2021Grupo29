using System;

namespace Emigrant.App.Dominio
{
    public class Servicios{
    public id servicios{set;get;}
    public string nombreServicios{set;get;}
    //maximo numero de migrantes = MNDM
    public int MNDM{set;get;}
    public DateTime fechaFinalizacion{set;get;}
    public DateTime fechaDeInicio{set;get;}

    public enum EstadoDeServicio
    {
       activo,
       cerrado,
       con_cupo,
       sin_cupo

    }
    public string descripcion{set;get;}

    public id entidad{set;get;}
}
}