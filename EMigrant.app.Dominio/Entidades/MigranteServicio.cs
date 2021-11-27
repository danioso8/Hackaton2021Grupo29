using System;

namespace Emigrant.App.Dominio
{
        public class MigranteServicio{
        public int id {set;get;}
        public Migrante migrante {set;get;}
        public Servicio servicio{set;get;}
        public DateTime fechaSolicitud{set;get;}
        public DateTime fechaRespuesta{set;get;}
        public EstadoSolicitud estadoSolicitud {get; set;}
        public EvaluacionServicio evaluacionServicio {get; set;}
    }
}