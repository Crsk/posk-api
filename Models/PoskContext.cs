using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PoskApi;

namespace PoskApi.Models
{
    public partial class PoskContext : DbContext
    {
        public PoskContext()
        {
        }

        public PoskContext(DbContextOptions<PoskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agregados> Agregados { get; set; }
        public virtual DbSet<BodegaMovimiento> BodegaMovimiento { get; set; }
        public virtual DbSet<BodegaStock> BodegaStock { get; set; }
        public virtual DbSet<BoletaMediopago> BoletaMediopago { get; set; }
        public virtual DbSet<Boletas> Boletas { get; set; }
        public virtual DbSet<Cantidadesvendidas> Cantidadesvendidas { get; set; }
        public virtual DbSet<CantidadesvendidasJornada> CantidadesvendidasJornada { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CategoriaSector> CategoriaSector { get; set; }
        public virtual DbSet<CategoriaSubcategoria> CategoriaSubcategoria { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Compras> Compras { get; set; }
        public virtual DbSet<Configs> Configs { get; set; }
        public virtual DbSet<DatosNegocio> DatosNegocio { get; set; }
        public virtual DbSet<DeliveryItem> DeliveryItem { get; set; }
        public virtual DbSet<DetalleBoleta> DetalleBoleta { get; set; }
        public virtual DbSet<Deudas> Deudas { get; set; }
        public virtual DbSet<Devolucion> Devolucion { get; set; }
        public virtual DbSet<Direcciones> Direcciones { get; set; }
        public virtual DbSet<Envolturas> Envolturas { get; set; }
        public virtual DbSet<Fiados> Fiados { get; set; }
        public virtual DbSet<Gastos> Gastos { get; set; }
        public virtual DbSet<Ingredientes> Ingredientes { get; set; }
        public virtual DbSet<Ingresos> Ingresos { get; set; }
        public virtual DbSet<Jornadas> Jornadas { get; set; }
        public virtual DbSet<LineasFiado> LineasFiado { get; set; }
        public virtual DbSet<Materiasprimas> Materiasprimas { get; set; }
        public virtual DbSet<MedioPago> MedioPago { get; set; }
        public virtual DbSet<Mermas> Mermas { get; set; }
        public virtual DbSet<Mesas> Mesas { get; set; }
        public virtual DbSet<Opcionales> Opcionales { get; set; }
        public virtual DbSet<OpcionalesIngredientes> OpcionalesIngredientes { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<PedidosAgregados> PedidosAgregados { get; set; }
        public virtual DbSet<PedidosPreparaciones> PedidosPreparaciones { get; set; }
        public virtual DbSet<PedidosProductos> PedidosProductos { get; set; }
        public virtual DbSet<Pendientes> Pendientes { get; set; }
        public virtual DbSet<Preparaciones> Preparaciones { get; set; }
        public virtual DbSet<PrestamoEnvases> PrestamoEnvases { get; set; }
        public virtual DbSet<ProductoCompra> ProductoCompra { get; set; }
        public virtual DbSet<ProductoMateriaprima> ProductoMateriaprima { get; set; }
        public virtual DbSet<ProductoPreparacion> ProductoPreparacion { get; set; }
        public virtual DbSet<ProductoProductocomplejo> ProductoProductocomplejo { get; set; }
        public virtual DbSet<ProductoPromocion> ProductoPromocion { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Productoscomplejos> Productoscomplejos { get; set; }
        public virtual DbSet<Promociones> Promociones { get; set; }
        public virtual DbSet<Puntos> Puntos { get; set; }
        public virtual DbSet<Registros> Registros { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Salsa> Salsa { get; set; }
        public virtual DbSet<Sectores> Sectores { get; set; }
        public virtual DbSet<SectorImpresion> SectorImpresion { get; set; }
        public virtual DbSet<Sectormesas> Sectormesas { get; set; }
        public virtual DbSet<ServirLlevar> ServirLlevar { get; set; }
        public virtual DbSet<StockMp> StockMp { get; set; }
        public virtual DbSet<StockPr> StockPr { get; set; }
        public virtual DbSet<Subcategorias> Subcategorias { get; set; }
        public virtual DbSet<Syncs> Syncs { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<TipoProductoOpcionales> TipoProductoOpcionales { get; set; }
        public virtual DbSet<UnidadesMedida> UnidadesMedida { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<VentasJornada> VentasJornada { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql($"Server=localhost;Database=posk_db;User=root;Pwd={Credentials.DB_PASSWORD}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agregados>(entity =>
            {
                entity.ToTable("agregados");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CobroExtra)
                    .HasColumnName("cobro_extra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EsVegetal)
                    .HasColumnName("es_vegetal")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FontSize)
                    .HasColumnName("font_size")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'20'");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.ParaHandroll)
                    .HasColumnName("para_handroll")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BodegaMovimiento>(entity =>
            {
                entity.ToTable("bodega_movimiento");

                entity.HasIndex(e => e.JornadaId)
                    .HasName("jornada_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Entrada)
                    .HasColumnName("entrada")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.JornadaId)
                    .HasColumnName("jornada_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salida)
                    .HasColumnName("salida")
                    .HasColumnType("decimal(12,2)");

                entity.HasOne(d => d.Jornada)
                    .WithMany(p => p.BodegaMovimiento)
                    .HasForeignKey(d => d.JornadaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("bodega_movimiento_ibfk_2");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.BodegaMovimiento)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("bodega_movimiento_ibfk_1");
            });

            modelBuilder.Entity<BodegaStock>(entity =>
            {
                entity.ToTable("bodega_stock");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasColumnType("decimal(12,2)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.BodegaStock)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("bodega_stock_ibfk_1");
            });

            modelBuilder.Entity<BoletaMediopago>(entity =>
            {
                entity.ToTable("boleta_mediopago");

                entity.HasIndex(e => e.BoletaId)
                    .HasName("boletamediopago_fk_idx");

                entity.HasIndex(e => e.MediopagoId)
                    .HasName("mediopago_fk_idx");

                entity.HasIndex(e => e.VendedorId)
                    .HasName("usuario_fk_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BoletaId)
                    .HasColumnName("boleta_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ingreso)
                    .HasColumnName("ingreso")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MediopagoId)
                    .HasColumnName("mediopago_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.VendedorId)
                    .HasColumnName("vendedor_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Boleta)
                    .WithMany(p => p.BoletaMediopago)
                    .HasForeignKey(d => d.BoletaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("boletamediopago_fk");

                entity.HasOne(d => d.Mediopago)
                    .WithMany(p => p.BoletaMediopago)
                    .HasForeignKey(d => d.MediopagoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("mediopago_fk");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.BoletaMediopago)
                    .HasForeignKey(d => d.VendedorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("usuario_fk");
            });

            modelBuilder.Entity<Boletas>(entity =>
            {
                entity.ToTable("boletas");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("boletas_ibfk_1");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("boletas_ibfk_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroBoleta)
                    .HasColumnName("numero_boleta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Propina)
                    .HasColumnName("propina")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PuntosCantidad)
                    .HasColumnName("puntos_cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Boletas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("boletas_ibfk_1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Boletas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("boletas_ibfk_2");
            });

            modelBuilder.Entity<Cantidadesvendidas>(entity =>
            {
                entity.ToTable("cantidadesvendidas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(9,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Itemventa)
                    .IsRequired()
                    .HasColumnName("itemventa")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<CantidadesvendidasJornada>(entity =>
            {
                entity.ToTable("cantidadesvendidas_jornada");

                entity.HasIndex(e => e.CantidadesvendidasId)
                    .HasName("cantidadesvendidas_id");

                entity.HasIndex(e => e.JornadaId)
                    .HasName("jornada_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CantidadesvendidasId)
                    .HasColumnName("cantidadesvendidas_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JornadaId)
                    .HasColumnName("jornada_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cantidadesvendidas)
                    .WithMany(p => p.CantidadesvendidasJornada)
                    .HasForeignKey(d => d.CantidadesvendidasId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("cantidadesvendidas_jornada_ibfk_1");

                entity.HasOne(d => d.Jornada)
                    .WithMany(p => p.CantidadesvendidasJornada)
                    .HasForeignKey(d => d.JornadaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("cantidadesvendidas_jornada_ibfk_2");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.ToTable("categorias");

                entity.HasIndex(e => e.Nombre)
                    .HasName("nombre_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Seleccionable)
                    .HasColumnName("seleccionable")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CategoriaSector>(entity =>
            {
                entity.ToTable("categoria_sector");

                entity.HasIndex(e => e.CategoriaId)
                    .HasName("categoria_sector_ibfk_1");

                entity.HasIndex(e => e.SectorId)
                    .HasName("categoria_sector_ibfk_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoriaId)
                    .HasColumnName("categoria_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SectorId)
                    .HasColumnName("sector_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.CategoriaSector)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("categoria_sector_ibfk_1");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.CategoriaSector)
                    .HasForeignKey(d => d.SectorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("categoria_sector_ibfk_2");
            });

            modelBuilder.Entity<CategoriaSubcategoria>(entity =>
            {
                entity.ToTable("categoria_subcategoria");

                entity.HasIndex(e => e.CategoriaId)
                    .HasName("categoria_subcategoria_ibfk_1");

                entity.HasIndex(e => e.SubcategoriaId)
                    .HasName("categoria_subcategoria_ibfk_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoriaId)
                    .HasColumnName("categoria_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubcategoriaId)
                    .HasColumnName("subcategoria_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.CategoriaSubcategoria)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("categoria_subcategoria_ibfk_1");

                entity.HasOne(d => d.Subcategoria)
                    .WithMany(p => p.CategoriaSubcategoria)
                    .HasForeignKey(d => d.SubcategoriaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("categoria_subcategoria_ibfk_2");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.ToTable("clientes");

                entity.HasIndex(e => e.PuntosId)
                    .HasName("puntos_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Favorito)
                    .HasColumnName("favorito")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("'123'");

                entity.Property(e => e.PuntosId)
                    .HasColumnName("puntos_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rut)
                    .HasColumnName("rut")
                    .HasColumnType("varchar(12)");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Puntos)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.PuntosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_ibfk_1");
            });

            modelBuilder.Entity<Compras>(entity =>
            {
                entity.ToTable("compras");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("compras_ibfk_1");
            });

            modelBuilder.Entity<Configs>(entity =>
            {
                entity.ToTable("configs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FontSize)
                    .HasColumnName("font_size")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Theme)
                    .HasColumnName("theme")
                    .HasColumnType("varchar(15)");
            });

            modelBuilder.Entity<DatosNegocio>(entity =>
            {
                entity.ToTable("datos_negocio");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorreoPrimario)
                    .HasColumnName("correo_primario")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.CorreoSecundario)
                    .HasColumnName("correo_secundario")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.InicioJornadaDia)
                    .HasColumnName("inicio_jornada_dia")
                    .HasColumnType("char(1)");

                entity.Property(e => e.InicioJornadaHora)
                    .HasColumnName("inicio_jornada_hora")
                    .HasColumnType("time");

                entity.Property(e => e.Iva)
                    .HasColumnName("iva")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("varchar(2048)");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("mensaje")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Modo)
                    .HasColumnName("modo")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PagoInmediato)
                    .HasColumnName("pago_inmediato")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TecladoTactilIntegrado)
                    .HasColumnName("teclado_tactil_integrado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.TerminoJornadaDia)
                    .HasColumnName("termino_jornada_dia")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TerminoJornadaHora)
                    .HasColumnName("termino_jornada_hora")
                    .HasColumnType("time");
            });

            modelBuilder.Entity<DeliveryItem>(entity =>
            {
                entity.ToTable("delivery_item");

                entity.HasIndex(e => e.BoletaId)
                    .HasName("boleta_fk_idx");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_fk_idx");

                entity.HasIndex(e => e.MedioPagoId)
                    .HasName("medio_pago_fk_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BoletaId)
                    .HasColumnName("boleta_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(120)");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("fecha_entrega")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("fecha_pedido")
                    .HasColumnType("datetime");

                entity.Property(e => e.Incluye)
                    .HasColumnName("incluye")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.MedioPagoId)
                    .HasColumnName("medio_pago_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("nombre_cliente")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PagaCon)
                    .HasColumnName("paga_con")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Servir)
                    .HasColumnName("servir")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Vuelto)
                    .IsRequired()
                    .HasColumnName("vuelto")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Boleta)
                    .WithMany(p => p.DeliveryItem)
                    .HasForeignKey(d => d.BoletaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("boleta_fk");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DeliveryItem)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("cliente_fk");

                entity.HasOne(d => d.MedioPago)
                    .WithMany(p => p.DeliveryItem)
                    .HasForeignKey(d => d.MedioPagoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("medio_pago_fk");
            });

            modelBuilder.Entity<DetalleBoleta>(entity =>
            {
                entity.ToTable("detalle_boleta");

                entity.HasIndex(e => e.BoletaId)
                    .HasName("boleta_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.HasIndex(e => e.PromocionId)
                    .HasName("detalle_boleta_ibfk_3_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BoletaId)
                    .HasColumnName("boleta_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromocionId)
                    .HasColumnName("promocion_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Boleta)
                    .WithMany(p => p.DetalleBoleta)
                    .HasForeignKey(d => d.BoletaId)
                    .HasConstraintName("detalle_boleta_ibfk_1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.DetalleBoleta)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("detalle_boleta_ibfk_2");

                entity.HasOne(d => d.Promocion)
                    .WithMany(p => p.DetalleBoleta)
                    .HasForeignKey(d => d.PromocionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("detalle_boleta_ibfk_3");
            });

            modelBuilder.Entity<Deudas>(entity =>
            {
                entity.ToTable("deudas");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Saldada)
                    .HasColumnName("saldada")
                    .HasColumnType("tinyint(1)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Deudas)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("deudas_ibfk_2");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Deudas)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("deudas_ibfk_1");
            });

            modelBuilder.Entity<Devolucion>(entity =>
            {
                entity.ToTable("devolucion");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Devolucion)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("devolucion_ibfk_1");
            });

            modelBuilder.Entity<Direcciones>(entity =>
            {
                entity.ToTable("direcciones");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Direcciones)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("direcciones_ibfk_1");
            });

            modelBuilder.Entity<Envolturas>(entity =>
            {
                entity.ToTable("envolturas");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("envoltura_producto_ibfk_1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CostoAdicional)
                    .HasColumnName("costo_adicional")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.ParaHandroll)
                    .HasColumnName("para_handroll")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ParaSuperhandroll)
                    .HasColumnName("para_superhandroll")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Envolturas)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("envoltura_producto_ibfk_1");
            });

            modelBuilder.Entity<Fiados>(entity =>
            {
                entity.ToTable("fiados");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_id");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Fiados)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("fiados_ibfk_1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Fiados)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("fiados_ibfk_2");
            });

            modelBuilder.Entity<Gastos>(entity =>
            {
                entity.ToTable("gastos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(12,2)");
            });

            modelBuilder.Entity<Ingredientes>(entity =>
            {
                entity.ToTable("ingredientes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Ingresos>(entity =>
            {
                entity.ToTable("ingresos");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CajaInicialEfectivo)
                    .HasColumnName("caja_inicial_efectivo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("fecha_desde")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("fecha_hasta")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Ingresos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("ingresos_ibfk_1");
            });

            modelBuilder.Entity<Jornadas>(entity =>
            {
                entity.ToTable("jornadas");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CajaInicialEfectivo)
                    .HasColumnName("caja_inicial_efectivo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Especial)
                    .HasColumnName("especial")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FechaApertura)
                    .HasColumnName("fecha_apertura")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ingresos)
                    .HasColumnName("ingresos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("mensaje")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Jornadas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jornadas_ibfk_1");
            });

            modelBuilder.Entity<LineasFiado>(entity =>
            {
                entity.ToTable("lineas_fiado");

                entity.HasIndex(e => e.FiadoId)
                    .HasName("fiado_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FiadoId)
                    .HasColumnName("fiado_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Fiado)
                    .WithMany(p => p.LineasFiado)
                    .HasForeignKey(d => d.FiadoId)
                    .HasConstraintName("lineas_fiado_ibfk_2");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.LineasFiado)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("lineas_fiado_ibfk_1");
            });

            modelBuilder.Entity<Materiasprimas>(entity =>
            {
                entity.ToTable("materiasprimas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("nombre_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UnidadMedidaId)
                    .HasName("materiasprimas_ibfk_1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.UnidadMedidaId)
                    .HasColumnName("unidad_medida_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Materiasprimas)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("materiasprimas_ibfk_1");
            });

            modelBuilder.Entity<MedioPago>(entity =>
            {
                entity.ToTable("medio_pago");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Mermas>(entity =>
            {
                entity.ToTable("mermas");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Mermas)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("mermas_ibfk_1");
            });

            modelBuilder.Entity<Mesas>(entity =>
            {
                entity.ToTable("mesas");

                entity.HasIndex(e => e.SectorId)
                    .HasName("mesas_ibfk_1_idx");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuarios_ibfk_2_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Items)
                    .HasColumnName("items")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Libre)
                    .HasColumnName("libre")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.SectorId)
                    .HasColumnName("sector_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Mesas)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("mesas_ibfk_1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Mesas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("usuarios_ibfk_2");
            });

            modelBuilder.Entity<Opcionales>(entity =>
            {
                entity.ToTable("opcionales");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OpcionalesIngredientes>(entity =>
            {
                entity.ToTable("opcionales_ingredientes");

                entity.HasIndex(e => e.IngredienteId)
                    .HasName("ingrediente_id");

                entity.HasIndex(e => e.OpcionalId)
                    .HasName("opcional_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IngredienteId)
                    .HasColumnName("ingrediente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpcionalId)
                    .HasColumnName("opcional_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Ingrediente)
                    .WithMany(p => p.OpcionalesIngredientes)
                    .HasForeignKey(d => d.IngredienteId)
                    .HasConstraintName("opcionales_ingredientes_ibfk_2");

                entity.HasOne(d => d.Opcional)
                    .WithMany(p => p.OpcionalesIngredientes)
                    .HasForeignKey(d => d.OpcionalId)
                    .HasConstraintName("opcionales_ingredientes_ibfk_1");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.ToTable("pedidos");

                entity.HasIndex(e => e.MesaId)
                    .HasName("mesa_id");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .HasColumnName("mensaje")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.MesaId)
                    .HasColumnName("mesa_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pagado)
                    .HasColumnName("pagado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Mesa)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.MesaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_ibfk_2");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_ibfk_1");
            });

            modelBuilder.Entity<PedidosAgregados>(entity =>
            {
                entity.ToTable("pedidos_agregados");

                entity.HasIndex(e => e.AgregadoDosId)
                    .HasName("pedidos_agregados_ibfk_3_idx");

                entity.HasIndex(e => e.AgregadoUnoId)
                    .HasName("pedidos_agregados_ibfk_2_idx");

                entity.HasIndex(e => e.PedidosProductosId)
                    .HasName("pedidos_productos_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgregadoDosId)
                    .HasColumnName("agregado_dos_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgregadoUnoId)
                    .HasColumnName("agregado_uno_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PedidosProductosId)
                    .HasColumnName("pedidos_productos_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.AgregadoDos)
                    .WithMany(p => p.PedidosAgregadosAgregadoDos)
                    .HasForeignKey(d => d.AgregadoDosId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_agregados_ibfk_3");

                entity.HasOne(d => d.AgregadoUno)
                    .WithMany(p => p.PedidosAgregadosAgregadoUno)
                    .HasForeignKey(d => d.AgregadoUnoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_agregados_ibfk_2");

                entity.HasOne(d => d.PedidosProductos)
                    .WithMany(p => p.PedidosAgregados)
                    .HasForeignKey(d => d.PedidosProductosId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_agregados_ibfk_1");
            });

            modelBuilder.Entity<PedidosPreparaciones>(entity =>
            {
                entity.ToTable("pedidos_preparaciones");

                entity.HasIndex(e => e.PedidosProductosId)
                    .HasName("pedidos_productos_id");

                entity.HasIndex(e => e.PreparacionId)
                    .HasName("preparacion_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PedidosProductosId)
                    .HasColumnName("pedidos_productos_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreparacionId)
                    .HasColumnName("preparacion_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PedidosProductos)
                    .WithMany(p => p.PedidosPreparaciones)
                    .HasForeignKey(d => d.PedidosProductosId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pedidos_preparaciones_ibfk_1");

                entity.HasOne(d => d.Preparacion)
                    .WithMany(p => p.PedidosPreparaciones)
                    .HasForeignKey(d => d.PreparacionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pedidos_preparaciones_ibfk_2");
            });

            modelBuilder.Entity<PedidosProductos>(entity =>
            {
                entity.ToTable("pedidos_productos");

                entity.HasIndex(e => e.PedidoId)
                    .HasName("pedido_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.HasIndex(e => e.PromoId)
                    .HasName("pedidos_productos_ibfk_3_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.Impreso)
                    .HasColumnName("impreso")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ImpresoCantidad)
                    .HasColumnName("impreso_cantidad")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.Nota)
                    .HasColumnName("nota")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PedidoId)
                    .HasColumnName("pedido_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromoId)
                    .HasColumnName("promo_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Pedido)
                    .WithMany(p => p.PedidosProductos)
                    .HasForeignKey(d => d.PedidoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_productos_ibfk_1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.PedidosProductos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_productos_ibfk_2");

                entity.HasOne(d => d.Promo)
                    .WithMany(p => p.PedidosProductos)
                    .HasForeignKey(d => d.PromoId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pedidos_productos_ibfk_3");
            });

            modelBuilder.Entity<Pendientes>(entity =>
            {
                entity.ToTable("pendientes");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("pendientes_ibfk_1");

                entity.HasIndex(e => e.PromocionId)
                    .HasName("pendientes_ibfk_3_idx");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("pendientes_ibfk_2_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Archivado)
                    .HasColumnName("archivado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromocionId)
                    .HasColumnName("promocion_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Pendientes)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pendientes_ibfk_1");

                entity.HasOne(d => d.Promocion)
                    .WithMany(p => p.Pendientes)
                    .HasForeignKey(d => d.PromocionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pendientes_ibfk_3");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Pendientes)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pendientes_ibfk_2");
            });

            modelBuilder.Entity<Preparaciones>(entity =>
            {
                entity.ToTable("preparaciones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FontSize)
                    .HasColumnName("font_size")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'20'");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<PrestamoEnvases>(entity =>
            {
                entity.ToTable("prestamo_envases");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Envases)
                    .HasColumnName("envases")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.PrestamoEnvases)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prestamo_envases_ibfk_1");
            });

            modelBuilder.Entity<ProductoCompra>(entity =>
            {
                entity.ToTable("producto_compra");

                entity.HasIndex(e => e.CompraId)
                    .HasName("compras_producto_ibfk_2");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("compras_producto_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activa)
                    .HasColumnName("activa")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.CantidadCompra)
                    .HasColumnName("cantidad_compra")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.CantidadDisponible)
                    .HasColumnName("cantidad_disponible")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.CompraId)
                    .HasColumnName("compra_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CostoUnitario)
                    .HasColumnName("costo_unitario")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Compra)
                    .WithMany(p => p.ProductoCompra)
                    .HasForeignKey(d => d.CompraId)
                    .HasConstraintName("producto_compra_ibfk_2");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoCompra)
                    .HasForeignKey(d => d.ProductoId)
                    .HasConstraintName("producto_compra_ibfk_1");
            });

            modelBuilder.Entity<ProductoMateriaprima>(entity =>
            {
                entity.ToTable("producto_materiaprima");

                entity.HasIndex(e => e.MateriaprimaId)
                    .HasName("materiaprima_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.MateriaprimaId)
                    .HasColumnName("materiaprima_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Materiaprima)
                    .WithMany(p => p.ProductoMateriaprima)
                    .HasForeignKey(d => d.MateriaprimaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_materiaprima_ibfk_1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoMateriaprima)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_materiaprima_ibfk_2");
            });

            modelBuilder.Entity<ProductoPreparacion>(entity =>
            {
                entity.ToTable("producto_preparacion");

                entity.HasIndex(e => e.PreparacionId)
                    .HasName("preparacion_id");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_preparacion_ibfk_3");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreparacionId)
                    .HasColumnName("preparacion_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Preparacion)
                    .WithMany(p => p.ProductoPreparacion)
                    .HasForeignKey(d => d.PreparacionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_preparacion_ibfk_2");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoPreparacion)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_preparacion_ibfk_3");
            });

            modelBuilder.Entity<ProductoProductocomplejo>(entity =>
            {
                entity.ToTable("producto_productocomplejo");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.HasIndex(e => e.ProductocomplejoId)
                    .HasName("productocomplejo_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductocomplejoId)
                    .HasColumnName("productocomplejo_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoProductocomplejo)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_productocomplejo_ibfk_2");

                entity.HasOne(d => d.Productocomplejo)
                    .WithMany(p => p.ProductoProductocomplejo)
                    .HasForeignKey(d => d.ProductocomplejoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_productocomplejo_ibfk_1");
            });

            modelBuilder.Entity<ProductoPromocion>(entity =>
            {
                entity.ToTable("producto_promocion");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.HasIndex(e => e.PromocionId)
                    .HasName("promocion_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PromocionId)
                    .HasColumnName("promocion_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoPromocion)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_promocion_ibfk_1");

                entity.HasOne(d => d.Promocion)
                    .WithMany(p => p.ProductoPromocion)
                    .HasForeignKey(d => d.PromocionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("producto_promocion_ibfk_2");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.ToTable("productos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("nombre_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.SectorImpresionId)
                    .HasName("productos_ibkf_3_idx");

                entity.HasIndex(e => e.SubCategoriaId)
                    .HasName("productos_ibfk_1_idx");

                entity.HasIndex(e => e.TipoProductoId)
                    .HasName("tipo_producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoBarras)
                    .HasColumnName("codigo_barras")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Favorito)
                    .HasColumnName("favorito")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PuntosCantidad)
                    .HasColumnName("puntos_cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Retornable)
                    .HasColumnName("retornable")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.SectorImpresionId)
                    .HasColumnName("sector_impresion_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SoloCompra)
                    .HasColumnName("solo_compra")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.SoloVenta)
                    .HasColumnName("solo_venta")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.SubCategoriaId)
                    .HasColumnName("sub_categoria_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoProductoId)
                    .HasColumnName("tipo_producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ZIndex)
                    .HasColumnName("z-index")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.HasOne(d => d.SectorImpresion)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.SectorImpresionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("productos_ibkf_3");

                entity.HasOne(d => d.SubCategoria)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.SubCategoriaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("productos_ibfk_1");

                entity.HasOne(d => d.TipoProducto)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.TipoProductoId)
                    .HasConstraintName("productos_ibfk_5");
            });

            modelBuilder.Entity<Productoscomplejos>(entity =>
            {
                entity.ToTable("productoscomplejos");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Productoscomplejos)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("productoscomplejos_ibfk_1");
            });

            modelBuilder.Entity<Promociones>(entity =>
            {
                entity.ToTable("promociones");

                entity.HasIndex(e => e.SubcategoriaId)
                    .HasName("promociones_ibfk_1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Favorito)
                    .HasColumnName("favorito")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubcategoriaId)
                    .HasColumnName("subcategoria_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Subcategoria)
                    .WithMany(p => p.Promociones)
                    .HasForeignKey(d => d.SubcategoriaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("promociones_ibfk_1");
            });

            modelBuilder.Entity<Puntos>(entity =>
            {
                entity.ToTable("puntos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnName("fecha_expiracion")
                    .HasColumnType("datetime");

                entity.Property(e => e.PuntosActivos)
                    .HasColumnName("puntos_activos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PuntosExpirados)
                    .HasColumnName("puntos_expirados")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Registros>(entity =>
            {
                entity.ToTable("registros");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Registros)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("registros_ibfk_1");
            });

            modelBuilder.Entity<Reservas>(entity =>
            {
                entity.ToTable("reservas");

                entity.HasIndex(e => e.MesaId)
                    .HasName("mesa_id");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MesaId)
                    .HasColumnName("mesa_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Mesa)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.MesaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("reservas_ibfk_1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("reservas_ibfk_2");
            });

            modelBuilder.Entity<Salsa>(entity =>
            {
                entity.ToTable("salsa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Sectores>(entity =>
            {
                entity.ToTable("sectores");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Seleccionable)
                    .HasColumnName("seleccionable")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<SectorImpresion>(entity =>
            {
                entity.ToTable("sector_impresion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Impresora)
                    .HasColumnName("impresora")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Sectormesas>(entity =>
            {
                entity.ToTable("sectormesas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<ServirLlevar>(entity =>
            {
                entity.ToTable("servir_llevar");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<StockMp>(entity =>
            {
                entity.ToTable("stock_mp");

                entity.HasIndex(e => e.MateriaprimaId)
                    .HasName("materiaprima_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Entrada)
                    .HasColumnName("entrada")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.MateriaprimaId)
                    .HasColumnName("materiaprima_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salida)
                    .HasColumnName("salida")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.Materiaprima)
                    .WithMany(p => p.StockMp)
                    .HasForeignKey(d => d.MateriaprimaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stock_mp_ibfk_1");
            });

            modelBuilder.Entity<StockPr>(entity =>
            {
                entity.ToTable("stock_pr");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.Entrada)
                    .HasColumnName("entrada")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Salida)
                    .HasColumnName("salida")
                    .HasColumnType("decimal(12,2)")
                    .HasDefaultValueSql("'0.00'");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.StockPr)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stock_pr_ibfk_1");
            });

            modelBuilder.Entity<Subcategorias>(entity =>
            {
                entity.ToTable("subcategorias");

                entity.HasIndex(e => e.Nombre)
                    .HasName("nombre_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Syncs>(entity =>
            {
                entity.ToTable("syncs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SyncId)
                    .HasColumnName("sync_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.ToTable("tipo_producto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LimiteIngr)
                    .HasColumnName("limite_ingr")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'6'");

                entity.Property(e => e.MostrarOpciones)
                    .HasColumnName("mostrar_opciones")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TipoProductoOpcionales>(entity =>
            {
                entity.ToTable("tipo_producto_opcionales");

                entity.HasIndex(e => e.OpcionalId)
                    .HasName("opcional_id");

                entity.HasIndex(e => e.TipoProductoId)
                    .HasName("tipo_producto_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpcionalId)
                    .HasColumnName("opcional_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoProductoId)
                    .HasColumnName("tipo_producto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Opcional)
                    .WithMany(p => p.TipoProductoOpcionales)
                    .HasForeignKey(d => d.OpcionalId)
                    .HasConstraintName("tipo_producto_opcionales_ibfk_2");

                entity.HasOne(d => d.TipoProducto)
                    .WithMany(p => p.TipoProductoOpcionales)
                    .HasForeignKey(d => d.TipoProductoId)
                    .HasConstraintName("tipo_producto_opcionales_ibfk_1");
            });

            modelBuilder.Entity<UnidadesMedida>(entity =>
            {
                entity.ToTable("unidades_medida");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.ConfigId)
                    .HasName("config_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConfigId)
                    .HasColumnName("config_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Favorito)
                    .HasColumnName("favorito")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("varchar(2048)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("char(1)");

                entity.HasOne(d => d.Config)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.ConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuarios_ibfk_1");
            });

            modelBuilder.Entity<VentasJornada>(entity =>
            {
                entity.ToTable("ventas_jornada");

                entity.HasIndex(e => e.DetalleBoletaId)
                    .HasName("ventas_jornada_id");

                entity.HasIndex(e => e.JornadaId)
                    .HasName("jornada_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CobroExtra)
                    .HasColumnName("cobro_extra")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DetalleBoletaId)
                    .HasColumnName("detalle_boleta_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.JornadaId)
                    .HasColumnName("jornada_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Opcion)
                    .IsRequired()
                    .HasColumnName("opcion")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.DetalleBoleta)
                    .WithMany(p => p.VentasJornada)
                    .HasForeignKey(d => d.DetalleBoletaId)
                    .HasConstraintName("ventas_jornada_ibfk_4");

                entity.HasOne(d => d.Jornada)
                    .WithMany(p => p.VentasJornada)
                    .HasForeignKey(d => d.JornadaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ventas_jornada_ibfk_3");
            });
        }
    }
}
