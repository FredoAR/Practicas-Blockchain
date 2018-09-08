using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fred_BlockChain_2
{
    
    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/3", IsNullable = false)]
    public partial class Comprobante
    {
        private ComprobanteEmisor emisorField;        
        private ComprobanteReceptor receptorField;
        private ComprobanteConceptos conceptosField;
        private ComprobanteComplemento complementoField;

        private decimal versionField;
        private string serieField;
        private byte folioField;
        private System.DateTime fechaField;
        private string selloField;
        private byte formaPagoField;
        private ulong noCertificadoField;
        private string certificadoField;
        private decimal subTotalField;
        private decimal descuentoField;
        private string monedaField;
        private decimal totalField;
        private string tipoDeComprobanteField;
        private string metodoPagoField;
        private ushort lugarExpedicionField;

        /// <remarks/>
        public ComprobanteEmisor Emisor
        {
            get
            {
                return this.emisorField;
            }
            set
            {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        public ComprobanteReceptor Receptor
        {
            get
            {
                return this.receptorField;
            }
            set
            {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        public ComprobanteConceptos Conceptos
        {
            get
            {
                return this.conceptosField;
            }
            set
            {
                this.conceptosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteComplemento Complemento
        {
            get
            {
                return this.complementoField;
            }
            set
            {
                this.complementoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Folio
        {
            get
            {
                return this.folioField;
            }
            set
            {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime Fecha
        {
            get
            {
                return this.fechaField;
            }
            set
            {
                this.fechaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sello
        {
            get
            {
                return this.selloField;
            }
            set
            {
                this.selloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FormaPago
        {
            get
            {
                return this.formaPagoField;
            }
            set
            {
                this.formaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong NoCertificado
        {
            get
            {
                return this.noCertificadoField;
            }
            set
            {
                this.noCertificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Certificado
        {
            get
            {
                return this.certificadoField;
            }
            set
            {
                this.certificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Descuento
        {
            get
            {
                return this.descuentoField;
            }
            set
            {
                this.descuentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda
        {
            get
            {
                return this.monedaField;
            }
            set
            {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDeComprobante
        {
            get
            {
                return this.tipoDeComprobanteField;
            }
            set
            {
                this.tipoDeComprobanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetodoPago
        {
            get
            {
                return this.metodoPagoField;
            }
            set
            {
                this.metodoPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort LugarExpedicion
        {
            get
            {
                return this.lugarExpedicionField;
            }
            set
            {
                this.lugarExpedicionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteEmisor
    {

        private string rfcField;

        private string nombreField;

        private ushort regimenFiscalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return this.rfcField;
            }
            set
            {
                this.rfcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort RegimenFiscal
        {
            get
            {
                return this.regimenFiscalField;
            }
            set
            {
                this.regimenFiscalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteReceptor
    {

        private string rfcField;

        private string nombreField;

        private string usoCFDIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rfc
        {
            get
            {
                return this.rfcField;
            }
            set
            {
                this.rfcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsoCFDI
        {
            get
            {
                return this.usoCFDIField;
            }
            set
            {
                this.usoCFDIField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptos
    {

        private ComprobanteConceptosConcepto conceptoField;

        /// <remarks/>
        public ComprobanteConceptosConcepto Concepto
        {
            get
            {
                return this.conceptoField;
            }
            set
            {
                this.conceptoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptosConcepto
    {

        private uint claveProdServField;

        private byte cantidadField;

        private string claveUnidadField;

        private string descripcionField;

        private decimal importeField;

        private decimal valorUnitarioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint ClaveProdServ
        {
            get
            {
                return this.claveProdServField;
            }
            set
            {
                this.claveProdServField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Cantidad
        {
            get
            {
                return this.cantidadField;
            }
            set
            {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveUnidad
        {
            get
            {
                return this.claveUnidadField;
            }
            set
            {
                this.claveUnidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion
        {
            get
            {
                return this.descripcionField;
            }
            set
            {
                this.descripcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importeField;
            }
            set
            {
                this.importeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitario
        {
            get
            {
                return this.valorUnitarioField;
            }
            set
            {
                this.valorUnitarioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteComplemento
    {

        private Nomina nominaField;

        private TimbreFiscalDigital timbreFiscalDigitalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sat.gob.mx/nomina12")]
        public Nomina Nomina
        {
            get
            {
                return this.nominaField;
            }
            set
            {
                this.nominaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
        public TimbreFiscalDigital TimbreFiscalDigital
        {
            get
            {
                return this.timbreFiscalDigitalField;
            }
            set
            {
                this.timbreFiscalDigitalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/nomina12", IsNullable = false)]
    public partial class Nomina
    {

        private NominaEmisor emisorField;

        private NominaReceptor receptorField;

        private NominaPercepciones percepcionesField;

        private NominaDeducciones deduccionesField;

        private decimal versionField;

        private string tipoNominaField;

        private System.DateTime fechaPagoField;

        private System.DateTime fechaInicialPagoField;

        private System.DateTime fechaFinalPagoField;

        private byte numDiasPagadosField;

        private decimal totalPercepcionesField;

        private decimal totalDeduccionesField;

        /// <remarks/>
        public NominaEmisor Emisor
        {
            get
            {
                return this.emisorField;
            }
            set
            {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        public NominaReceptor Receptor
        {
            get
            {
                return this.receptorField;
            }
            set
            {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        public NominaPercepciones Percepciones
        {
            get
            {
                return this.percepcionesField;
            }
            set
            {
                this.percepcionesField = value;
            }
        }

        /// <remarks/>
        public NominaDeducciones Deducciones
        {
            get
            {
                return this.deduccionesField;
            }
            set
            {
                this.deduccionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoNomina
        {
            get
            {
                return this.tipoNominaField;
            }
            set
            {
                this.tipoNominaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime FechaPago
        {
            get
            {
                return this.fechaPagoField;
            }
            set
            {
                this.fechaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime FechaInicialPago
        {
            get
            {
                return this.fechaInicialPagoField;
            }
            set
            {
                this.fechaInicialPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime FechaFinalPago
        {
            get
            {
                return this.fechaFinalPagoField;
            }
            set
            {
                this.fechaFinalPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NumDiasPagados
        {
            get
            {
                return this.numDiasPagadosField;
            }
            set
            {
                this.numDiasPagadosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalPercepciones
        {
            get
            {
                return this.totalPercepcionesField;
            }
            set
            {
                this.totalPercepcionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalDeducciones
        {
            get
            {
                return this.totalDeduccionesField;
            }
            set
            {
                this.totalDeduccionesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaEmisor
    {

        private string registroPatronalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegistroPatronal
        {
            get
            {
                return this.registroPatronalField;
            }
            set
            {
                this.registroPatronalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaReceptor
    {

        private string curpField;

        private ulong numSeguridadSocialField;

        private System.DateTime fechaInicioRelLaboralField;

        private string antigüedadField;

        private byte tipoContratoField;

        private string sindicalizadoField;

        private byte tipoJornadaField;

        private byte tipoRegimenField;

        private ushort numEmpleadoField;

        private string departamentoField;

        private string puestoField;

        private byte riesgoPuestoField;

        private byte periodicidadPagoField;

        private byte bancoField;

        private uint cuentaBancariaField;

        private decimal salarioBaseCotAporField;

        private decimal salarioDiarioIntegradoField;

        private string claveEntFedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Curp
        {
            get
            {
                return this.curpField;
            }
            set
            {
                this.curpField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong NumSeguridadSocial
        {
            get
            {
                return this.numSeguridadSocialField;
            }
            set
            {
                this.numSeguridadSocialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime FechaInicioRelLaboral
        {
            get
            {
                return this.fechaInicioRelLaboralField;
            }
            set
            {
                this.fechaInicioRelLaboralField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Antigüedad
        {
            get
            {
                return this.antigüedadField;
            }
            set
            {
                this.antigüedadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TipoContrato
        {
            get
            {
                return this.tipoContratoField;
            }
            set
            {
                this.tipoContratoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sindicalizado
        {
            get
            {
                return this.sindicalizadoField;
            }
            set
            {
                this.sindicalizadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TipoJornada
        {
            get
            {
                return this.tipoJornadaField;
            }
            set
            {
                this.tipoJornadaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TipoRegimen
        {
            get
            {
                return this.tipoRegimenField;
            }
            set
            {
                this.tipoRegimenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort NumEmpleado
        {
            get
            {
                return this.numEmpleadoField;
            }
            set
            {
                this.numEmpleadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Departamento
        {
            get
            {
                return this.departamentoField;
            }
            set
            {
                this.departamentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Puesto
        {
            get
            {
                return this.puestoField;
            }
            set
            {
                this.puestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RiesgoPuesto
        {
            get
            {
                return this.riesgoPuestoField;
            }
            set
            {
                this.riesgoPuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PeriodicidadPago
        {
            get
            {
                return this.periodicidadPagoField;
            }
            set
            {
                this.periodicidadPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Banco
        {
            get
            {
                return this.bancoField;
            }
            set
            {
                this.bancoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint CuentaBancaria
        {
            get
            {
                return this.cuentaBancariaField;
            }
            set
            {
                this.cuentaBancariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SalarioBaseCotApor
        {
            get
            {
                return this.salarioBaseCotAporField;
            }
            set
            {
                this.salarioBaseCotAporField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SalarioDiarioIntegrado
        {
            get
            {
                return this.salarioDiarioIntegradoField;
            }
            set
            {
                this.salarioDiarioIntegradoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveEntFed
        {
            get
            {
                return this.claveEntFedField;
            }
            set
            {
                this.claveEntFedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepciones
    {

        private NominaPercepcionesPercepcion percepcionField;

        private decimal totalSueldosField;

        private decimal totalGravadoField;

        private decimal totalExentoField;

        /// <remarks/>
        public NominaPercepcionesPercepcion Percepcion
        {
            get
            {
                return this.percepcionField;
            }
            set
            {
                this.percepcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalSueldos
        {
            get
            {
                return this.totalSueldosField;
            }
            set
            {
                this.totalSueldosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalGravado
        {
            get
            {
                return this.totalGravadoField;
            }
            set
            {
                this.totalGravadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalExento
        {
            get
            {
                return this.totalExentoField;
            }
            set
            {
                this.totalExentoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaPercepcionesPercepcion
    {

        private byte tipoPercepcionField;

        private byte claveField;

        private string conceptoField;

        private decimal importeGravadoField;

        private decimal importeExentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TipoPercepcion
        {
            get
            {
                return this.tipoPercepcionField;
            }
            set
            {
                this.tipoPercepcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Clave
        {
            get
            {
                return this.claveField;
            }
            set
            {
                this.claveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto
        {
            get
            {
                return this.conceptoField;
            }
            set
            {
                this.conceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteGravado
        {
            get
            {
                return this.importeGravadoField;
            }
            set
            {
                this.importeGravadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImporteExento
        {
            get
            {
                return this.importeExentoField;
            }
            set
            {
                this.importeExentoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaDeducciones
    {

        private NominaDeduccionesDeduccion[] deduccionField;

        private decimal totalOtrasDeduccionesField;

        private decimal totalImpuestosRetenidosField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Deduccion")]
        public NominaDeduccionesDeduccion[] Deduccion
        {
            get
            {
                return this.deduccionField;
            }
            set
            {
                this.deduccionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalOtrasDeducciones
        {
            get
            {
                return this.totalOtrasDeduccionesField;
            }
            set
            {
                this.totalOtrasDeduccionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalImpuestosRetenidos
        {
            get
            {
                return this.totalImpuestosRetenidosField;
            }
            set
            {
                this.totalImpuestosRetenidosField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/nomina12")]
    public partial class NominaDeduccionesDeduccion
    {

        private byte tipoDeduccionField;

        private ushort claveField;

        private string conceptoField;

        private decimal importeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TipoDeduccion
        {
            get
            {
                return this.tipoDeduccionField;
            }
            set
            {
                this.tipoDeduccionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Clave
        {
            get
            {
                return this.claveField;
            }
            set
            {
                this.claveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto
        {
            get
            {
                return this.conceptoField;
            }
            set
            {
                this.conceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe
        {
            get
            {
                return this.importeField;
            }
            set
            {
                this.importeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/TimbreFiscalDigital", IsNullable = false)]
    public partial class TimbreFiscalDigital
    {

        private decimal versionField;

        private string rfcProvCertifField;

        private string selloSATField;

        private ulong noCertificadoSATField;

        private System.DateTime fechaTimbradoField;

        private string uUIDField;

        private string selloCFDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcProvCertif
        {
            get
            {
                return this.rfcProvCertifField;
            }
            set
            {
                this.rfcProvCertifField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelloSAT
        {
            get
            {
                return this.selloSATField;
            }
            set
            {
                this.selloSATField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong NoCertificadoSAT
        {
            get
            {
                return this.noCertificadoSATField;
            }
            set
            {
                this.noCertificadoSATField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaTimbrado
        {
            get
            {
                return this.fechaTimbradoField;
            }
            set
            {
                this.fechaTimbradoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SelloCFD
        {
            get
            {
                return this.selloCFDField;
            }
            set
            {
                this.selloCFDField = value;
            }
        }
    }
}
