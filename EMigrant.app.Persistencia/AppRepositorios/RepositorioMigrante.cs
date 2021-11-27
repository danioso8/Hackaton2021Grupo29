/*using System.Collections.Generic;
using EMigrant.app.Dominio;

namespace EMigrant.app.Persistencia
{
    public class RepositorioMigrante : IRepositorioMigrante
    {
        private readonly AppContext _appContext;

        public RepositorioMigrante(AppContext appContext)
        {
            _appContext = appContext;
        }

        //Agregar Migrante
        public Migrante AddMigrante(Migrante migrante)
        {
            var migranteAdicionado = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }

        //Eliminar Migrante
        public void DeleteMigrante(int id)
        {
            var migranteEncontrado = _appContext.Migrantes.Find(id);
            if (migranteEncontrado == null)
                return;
            _appContext.Migrantes.Remove(migranteEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los Migrantes
        public IEnumerable<Migrante> GetAllMigrantes()
        {
            return _appContext.Migrantes;
        }

        //Mostrar un Migrante
        public Migrante GetMigrante(int id)
        {
            return _appContext.Migrantes.Find(id);
        }

        //Actualizar Migrante
        public Migrante UpdateMigrante(Migrante migrante, Grupo grupo)
        {
            var migranteEncontrado = _appContext.Migrantes.Find(migrante.id);
            var idGrupo = _appContext.Grupos.Find(grupo.id);
    
            if (migranteEncontrado != null)
            {
                migranteEncontrado.Nombre = migrante.Nombre;
                migranteEncontrado.Apellidos = migrante.Apellidos;
                migranteEncontrado.TipoDocumento = migrante.TipoDocumento;
                migranteEncontrado.NumeroDocumento = migrante.NumeroDocumento;
                migranteEncontrado.PaisOrigen = migrante.PaisOrigen;
                migranteEncontrado.FechaNacimiento = migrante.FechaNacimiento;
                migranteEncontrado.CorreoElectronico = migrante.CorreoElectronico;
                migranteEncontrado.Telefono = migrante.Telefono;
                migranteEncontrado.DireccionActual = migrante.DireccionActual;
                migranteEncontrado.Ciudad = migrante.Ciudad;
                migranteEncontrado.SituacionLaboral = migrante.SituacionLaboral;

                idGrupo.id = grupo.id;
                _appContext.SaveChanges();
            }
            return migranteEncontrado;
        }
    }
}*/