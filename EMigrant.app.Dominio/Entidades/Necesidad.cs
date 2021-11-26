namespace EMigrantes.Entidades{
    public class Necesidad{
        public Migrante migrante {set;get;}
        public TipoNecesidad tipoNecesidad {get; set;}
        public string descripcion{set;get;}
        public PrioridadNecesidad prioridadNecesidad {get; set;}
    }

}