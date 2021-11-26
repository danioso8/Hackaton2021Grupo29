namespace E_migrantes.Entidades{

    public class MigrantesServicios{
        public id solicitud {set;get;}
        public id persona{set;get;}
        public id servicio{set;get;}
        public DateTime fechaSolicitud{set;get;}
        public DateTime fechaRespuesta{set;get;}
        public enum EstadoSolicitud{
            activo,
            cerrado,
            concupo,
            sincupo
        }
        public enum evaluacion{
            malo,
            regular,
            bueno,
            muy_bueno,
            excelente

        }
    }
}