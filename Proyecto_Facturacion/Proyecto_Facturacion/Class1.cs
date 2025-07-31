using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion
{
    internal class Clientes
    {
        private string _idCliente;
        private string _nombreEmpresa;
        private string _nif;
        private string _direccion;
        private string _ciudad;
        private string _provincia;
        private string _codigoPostal;
        private string _telefono;
        private string _correoElectronico;


        public Clientes(string idCliente, string nombreEmpresa, string nif, string direccion, string ciudad, string provincia, string codigoPostal, string telefono, string correoElectronico)
        {
            _idCliente = idCliente;
            _nombreEmpresa = nombreEmpresa;
            _nif = nif;
            _direccion = direccion;
            _ciudad = ciudad;
            _provincia = provincia;
            _codigoPostal = codigoPostal;
            _telefono = telefono;
            _correoElectronico = correoElectronico;
        }

        public string IdCliente { get { return _idCliente; } }
        public string NombreEmpresa { get { return _nombreEmpresa; } }
        public string Nif { get { return _nif; } }
        public string Direccion { get { return _direccion; } }
        public string Ciudad { get { return _ciudad; } }
        public string Provincia { get { return _provincia; } }
        public string CodigoPostal { get { return _codigoPostal; } }
        public string Telefono { get { return _telefono; } }
        public string CorreoElectronico { get { return _correoElectronico; } }

        public override string ToString()
        {
            return _nombreEmpresa;
        }

    }
    internal class Facturas
    {
        private string _idFactura;
        private string _nombreEmpresa;
        private string _fechaFactura;
        private string _importeFinal;

        public Facturas(string idFactura, string nombreEmpresa, string fechaFactura, string importeFinal)
        {
            _idFactura = idFactura;
            _nombreEmpresa = nombreEmpresa;
            _fechaFactura = fechaFactura;
            _importeFinal = importeFinal;
        }
        public string IdFactura { get { return _idFactura; } }
        public string NombreEmpresa { get { return _nombreEmpresa; } }
        public string FechaFactura { get { return _fechaFactura; } }
        public string ImporteFinal { get { return _importeFinal; } }

        public override string ToString()
        {
            return _fechaFactura + " " + _nombreEmpresa;
        }
    }
    internal class Mes
    {
        private string _nonbreMes;
        private string _idMes;

        public Mes(string nonbreMes, string idMes)
        {
            _nonbreMes = nonbreMes;
            _idMes = idMes;
        }
        public string NombreMes {get {return _nonbreMes; } }
        public string IdMes { get { return _idMes; } }

        public override string ToString()
        {
            return _nonbreMes;
        }
    }
}
