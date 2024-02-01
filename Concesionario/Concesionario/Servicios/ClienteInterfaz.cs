using Concesionario.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Servicios
{
    internal interface ClienteInterfaz
    {
        /// <summary>
        /// Metodo encargado de solicitar al cliente todos los datos que lo compondran al mismo
        /// <author>DMN - 01/02/2024</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void altaCliente(List<Cliente> listaClientes);

        /// <summary>
        /// Metodo encargado de idntificar al client en base al dni, y validarlo
        /// <author>DMN - 01/02/2024</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void validarCliente(List<Cliente> clientes);

        /// <summary>
        /// Metodo encargado de modificar identificar al cliente en base al dni, y modificar el campo especificado
        /// <author>DMN - 01/02/2024</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public void modificarCliente(List<Cliente> listaClientes, int seleccioMenu);
    }
}
