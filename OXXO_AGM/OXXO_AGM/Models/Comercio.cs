using System;
using System.Collections.Generic;

namespace OXXO_AGM.Models
{
    public partial class Comercio
    {
        public Comercio()
        {
            BitacoraComercios = new HashSet<BitacoraComercio>();
            Documentos = new HashSet<Documento>();
            Referencia = new HashSet<Referencium>();
            Transaccions = new HashSet<Transaccion>();
        }

        public int IdComercio { get; set; }
        public int? IdEmisor { get; set; }
        public string Rfc { get; set; } = null!;
        public string? NombreCompleto { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? CuentaDeposito { get; set; }
        public int IdBanco { get; set; }
        public string? RazonSocial { get; set; }
        public string? NombreComercial { get; set; }
        public int? IdGiroComercio { get; set; }
        public string? Portal { get; set; }
        public int PersonaMoral { get; set; }
        public int PersonaFisica { get; set; }
        public int IdEstatus { get; set; }
        public int IdCompania { get; set; }
        public int? IdTipoDeposito { get; set; }
        public int? IdCluster { get; set; }
        public int? EmailConfirmado { get; set; }
        public int? IdMerchant { get; set; }
        public bool? Activo { get; set; }
        public int? UsuarioFai { get; set; }
        public DateTime? Fai { get; set; }
        public int? UsuarioFum { get; set; }
        public DateTime? Fum { get; set; }

        public virtual Banco IdBancoNavigation { get; set; } = null!;
        public virtual Cluster? IdClusterNavigation { get; set; }
        public virtual Compania IdCompaniaNavigation { get; set; } = null!;
        public virtual Estatus IdEstatusNavigation { get; set; } = null!;
        public virtual GiroComercio? IdGiroComercioNavigation { get; set; }
        public virtual TipoDeposito? IdTipoDepositoNavigation { get; set; }
        public virtual ICollection<BitacoraComercio> BitacoraComercios { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Referencium> Referencia { get; set; }
        public virtual ICollection<Transaccion> Transaccions { get; set; }
    }
}
