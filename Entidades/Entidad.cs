namespace E_migrantes.Entidades
{
    public class Entidad
    {
        public id entidad{set;get;}
        public string razonSocial{set;get;}
        public string nit{set;get;}
        public string direccion{set;get;}
        public string ciudad {set;get;}
        public string elefono{set;get;}
        public string correoElectronico{set;get;}
        public string paginaWeb{set;get;}
        public enum sector{
            publico,
            privado,
            sin_animo_de_lucro,
            no_gubernamental,
            otro
        }
        public enum servicios{
            salud,
            juridicos,
            vivieres,
            comida_preparada,
            empleo,
            alojamiento_temporal,
            alojamiento_permanente,
            educacion,
            otros

        }

    }
}