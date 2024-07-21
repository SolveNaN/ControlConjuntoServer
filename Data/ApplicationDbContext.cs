using ControlConjuntoServer.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net.Sockets;

namespace ControlConjuntoServer.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


         public DbSet<Anuncio> Anuncios { get; set; }
         public DbSet<AreaComun> AreaComuns { get; set; }
         public DbSet<Comentario> Comentarios { get; set; }
         public DbSet<Conjunto> Conjuntos { get; set; }
         public DbSet<Documento> Documentos { get; set; }
         public DbSet<Ejemplo> Ejemplos { get; set; }
         public DbSet<Encuesta> Encuestas { get; set; }
         public DbSet<EncuestaUsuario> EncuestaUsuarios { get; set; }
         public DbSet<HistorialModuloParqueo> HistorialModuloParqueos { get; set; }
         public DbSet<HistorialParqueaderoPublico> HistorialParqueaderoPublicos { get; set; }
         public DbSet<ModuloParqueaderoPublico> ModuloParqueaderoPublicos { get; set; }
         public DbSet<ModuloParqueo> ModuloParqueos { get; set; }
         public DbSet<ModuloParqueoAsignado> ModuloParqueoAsignados { get; set; }
         public DbSet<Pago> Pagos { get; set; }
         public DbSet<PagoUsuario> PagoUsuarios { get; set; }
         public DbSet<Parqueadero> Parqueaderos { get; set; }
         public DbSet<ParqueaderoPublico> ParqueaderoPublicos { get; set; }
         public DbSet<Proveedor> Proveedors { get; set; }
         public DbSet<ProveedorServicio> ProveedorServicios { get; set; }
         public DbSet<ReporteAdmin> ReporteAdmins { get; set; }
         public DbSet<Reserva> Reservas { get; set; }
         public DbSet<Servicio> Servicios { get; set; }
         public DbSet<Ticket> Tickets { get; set; }
         public DbSet<Torre> Torres { get; set; }
         public DbSet<Unidad> Unidads { get; set; }
         public DbSet<UploadResult> UploadResults { get; set; }
         public DbSet<Usuario> Usuarios { get; set; }
         public DbSet<UsuarioPideServicio> UsuarioPideServicios { get; set; }
         public DbSet<UsuarioUnidad> UsuarioUnidads { get; set; }
         public DbSet<Visitante> Visitantes { get; set; }
         public DbSet<VisitanteUnidad> VisitanteUnidads { get; set; }



    }
}

