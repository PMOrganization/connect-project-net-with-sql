using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.entities;

namespace upc.orden.repositorio
{
    public interface IClienteRepository
    {
        bool Create(Cliente c);
        DataTable Reader();
        DataTable ReaderByDni(int dni);
    }
}
