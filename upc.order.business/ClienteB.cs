using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.orden.repositorio;
using upc.order.entities;

namespace upc.order.business
{
    public class ClienteB : ICliente
    {
        IClienteRepository CRepository;

        public ClienteB()
        {
            CRepository = new ClienteRepository();
        }

        public DataTable ReaderByDni(int dni)
        {
            return CRepository.ReaderByDni(dni);
        }

        public bool Create(Cliente c)
        {
            return CRepository.Create(c);
        }

        public DataTable Reader()
        {
            return CRepository.Reader();
        }
    }
}
