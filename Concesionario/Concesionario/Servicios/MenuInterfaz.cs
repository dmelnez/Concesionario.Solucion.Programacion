using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar el menu principal
        /// <author>DMN - 01/02/2024</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public int MenuPrincipla();

        /// <summary>
        /// Metodo encargado de mostrar el menu de los campos a modificar del cliente
        /// <author>DMN - 01/02/2024</author>
        /// </summary>
        /// <param name="listaClientes"></param>
        public int modMenuCliente();
    }
}
