using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OXXO_AGM.Models
{
    public partial class AGM_NUEVAContext : DbContext
    {
        public AGM_NUEVAContext()
        {
        }

        public AGM_NUEVAContext(DbContextOptions<AGM_NUEVAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccionControlador> AccionControladores { get; set; } = null!;
        public virtual DbSet<Banco> Bancos { get; set; } = null!;
        public virtual DbSet<BitacoraComercio> BitacoraComercios { get; set; } = null!;
        public virtual DbSet<Cluster> Clusters { get; set; } = null!;
        public virtual DbSet<Comercio> Comercios { get; set; } = null!;
        public virtual DbSet<Compania> Companias { get; set; } = null!;
        public virtual DbSet<Controlador> Controladores { get; set; } = null!;
        public virtual DbSet<Documento> Documentos { get; set; } = null!;
        public virtual DbSet<Estatus> Estatus { get; set; } = null!;
        public virtual DbSet<EstatusPago> EstatusPagos { get; set; } = null!;
        public virtual DbSet<GiroComercio> GiroComercios { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Perfil> Perfils { get; set; } = null!;
        public virtual DbSet<Referencium> Referencia { get; set; } = null!;
        public virtual DbSet<RolControlador> RolControladores { get; set; } = null!;
        public virtual DbSet<TipoDeposito> TipoDepositos { get; set; } = null!;
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<TipoOperacion> TipoOperacions { get; set; } = null!;
        public virtual DbSet<Transaccion> Transaccions { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=192.168.1.244; Database=AGM_NUEVA; User ID=Desarrollo;Password=C0nsulting;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccionControlador>(entity =>
            {
                entity.HasKey(e => e.IdAccion)
                    .HasName("PK__AccionCo__9845169B6015FC25");

                entity.ToTable("AccionControlador");

                entity.Property(e => e.Encabezado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreAccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdControladorNavigation)
                    .WithMany(p => p.AccionControladors)
                    .HasForeignKey(d => d.IdControlador)
                    .HasConstraintName("FK__AccionCon__IdCon__76969D2E");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.IdBanco)
                    .HasName("PK__Banco__2D3F553E06C9AA12");

                entity.ToTable("Banco");

                entity.Property(e => e.Banco1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Banco");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<BitacoraComercio>(entity =>
            {
                entity.HasKey(e => e.IdBitacoraComercio)
                    .HasName("PK__Bitacora__EE3514A80BA8D126");

                entity.ToTable("Bitacora_Comercio");

                entity.Property(e => e.Comentarios)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.IdEmisor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.BitacoraComercios)
                    .HasForeignKey(d => d.IdComercio)
                    .HasConstraintName("FK__Bitacora___IdCom__72C60C4A");
            });

            modelBuilder.Entity<Cluster>(entity =>
            {
                entity.HasKey(e => e.IdCluster)
                    .HasName("PK__Cluster__001C9028D170A514");

                entity.ToTable("Cluster");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreCluster)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<Comercio>(entity =>
            {
                entity.HasKey(e => e.IdComercio)
                    .HasName("PK__Comercio__CAFFA85F98AB2B30");

                entity.ToTable("Comercio");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDeposito)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreComercial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Portal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("RFC");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comercio__IdBanc__7D439ABD");

                entity.HasOne(d => d.IdClusterNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdCluster)
                    .HasConstraintName("FK__Comercio__IdClus__71D1E811");

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdCompania)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comercio__IdComp__7B5B524B");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Comercio__IdEsta__04E4BC85");

                entity.HasOne(d => d.IdGiroComercioNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdGiroComercio)
                    .HasConstraintName("FK__Comercio__IdGiro__7C4F7684");

                entity.HasOne(d => d.IdTipoDepositoNavigation)
                    .WithMany(p => p.Comercios)
                    .HasForeignKey(d => d.IdTipoDeposito)
                    .HasConstraintName("FK__Comercio__IdTipo__03F0984C");
            });

            modelBuilder.Entity<Compania>(entity =>
            {
                entity.HasKey(e => e.IdCompania)
                    .HasName("PK__Compania__12C8F03332ECE36B");

                entity.Property(e => e.Compania1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<Controlador>(entity =>
            {
                entity.HasKey(e => e.IdControlador)
                    .HasName("PK__Controla__1344D62B0C40BECA");

                entity.ToTable("Controlador");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreControlador)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Texto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdMenuPadreNavigation)
                    .WithMany(p => p.Controladors)
                    .HasForeignKey(d => d.IdMenuPadre)
                    .HasConstraintName("FK__Controlad__IdMen__75A278F5");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdArchivo)
                    .HasName("PK__Document__26B9211159FA4BDD");

                entity.ToTable("Documento");

                entity.Property(e => e.Archivo).HasColumnName("archivo");

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdComercio)
                    .HasConstraintName("FK__Documento__IdCom__02FC7413");

                entity.HasOne(d => d.IdTipoDocumentoNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Documento__IdTip__7E37BEF6");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.HasKey(e => e.IdEstatus)
                    .HasName("PK__Estatus__B32BA1C7550909BE");

                entity.ToTable("Estatus");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Estatus");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<EstatusPago>(entity =>
            {
                entity.HasKey(e => e.IdEstatusPago)
                    .HasName("PK__EstatusP__6F16D2FFDEBD6E0D");

                entity.ToTable("EstatusPago");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreEstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<GiroComercio>(entity =>
            {
                entity.HasKey(e => e.IdGiroComercio)
                    .HasName("PK__GiroCome__0DD7D346DD746D12");

                entity.ToTable("GiroComercio");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.GiroComercial)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tasa).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PK__Menu__4D7EA8E165D8BD3C");

                entity.ToTable("Menu");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK__Perfil__C7BD5CC1DF7CBD28");

                entity.ToTable("Perfil");

                entity.Property(e => e.Aprobacion).HasColumnName("aprobacion");

                entity.Property(e => e.Carga).HasColumnName("carga");

                entity.Property(e => e.Categorizacion).HasColumnName("categorizacion");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edicion).HasColumnName("edicion");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<Referencium>(entity =>
            {
                entity.HasKey(e => e.IdReferencia)
                    .HasName("PK__Referenc__D6CD6A7DEBBCED61");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.IdServicio)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaCliente)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaMerchant)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Referencia)
                    .HasForeignKey(d => d.IdComercio)
                    .HasConstraintName("FK__Referenci__IdCom__656C112C");
            });

            modelBuilder.Entity<RolControlador>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__RolContr__2A49584CCBEE3A25");

                entity.ToTable("RolControlador");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdControladorNavigation)
                    .WithMany(p => p.RolControladors)
                    .HasForeignKey(d => d.IdControlador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RolContro__IdCon__778AC167");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.RolControladors)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK__RolContro__IdPer__787EE5A0");
            });

            modelBuilder.Entity<TipoDeposito>(entity =>
            {
                entity.HasKey(e => e.IdTipoDeposito)
                    .HasName("PK__TipoDepo__FA4F2115A9744AB0");

                entity.ToTable("TipoDeposito");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.TipoDeposito1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TipoDeposito");

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocumento)
                    .HasName("PK__TipoDocu__3AB3332FC0D8A9D9");

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreDocumento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoArchivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<TipoOperacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoOperacion)
                    .HasName("PK__TipoOper__9F3069930DD70E00");

                entity.ToTable("TipoOperacion");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.NombreOperacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");
            });

            modelBuilder.Entity<Transaccion>(entity =>
            {
                entity.HasKey(e => e.IdTransaccion)
                    .HasName("PK__Transacc__334B1F77DD9F3A66");

                entity.ToTable("Transaccion");

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaAlta).HasColumnType("smalldatetime");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.Hora)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdServicio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaMerchant)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tienda)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.HasOne(d => d.IdComercioNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.IdComercio)
                    .HasConstraintName("FK__Transacci__IdCom__6E01572D");

                entity.HasOne(d => d.IdEstatusPagoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.IdEstatusPago)
                    .HasConstraintName("FK__Transacci__IdEst__6B24EA82");

                entity.HasOne(d => d.IdTipoOperacionNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.IdTipoOperacion)
                    .HasConstraintName("FK__Transacci__IdTip__74AE54BC");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97976306A4");

                entity.ToTable("Usuario");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena).HasMaxLength(32);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fai)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FAI");

                entity.Property(e => e.Fum)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FUM");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioFai).HasColumnName("Usuario_FAI");

                entity.Property(e => e.UsuarioFum).HasColumnName("Usuario_FUM");

                entity.Property(e => e.Vigencia).HasColumnType("smalldatetime");

                entity.HasOne(d => d.IdCompaniaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdCompania)
                    .HasConstraintName("FK__Usuario__IdCompa__7A672E12");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK__Usuario__IdPerfi__797309D9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
