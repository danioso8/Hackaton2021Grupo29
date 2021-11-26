namespace E_migrantes.Entidades{
    public class Necesidades{
        public id persona{set;get;}
        public enum necesidades{
            salud,
            alimentacion,
            empleo,
            alojamiento_temporal,
            alojamiento_permanente,
            educacion,
            ayuda_legal
        }
        public string descripcion{set;get;}
        public enum prioridad{}
    }

}