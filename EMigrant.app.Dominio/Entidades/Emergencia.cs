namespace E_migrantes.Entidades
{
    public class Emergencia
    {
        public int id{set;get;}
        public Migrante migrante {set; get;}
        public string descripcion {set;get;}
        public boolean estado{set;get;}
    }
}