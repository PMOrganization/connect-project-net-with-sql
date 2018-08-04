using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.entities;

namespace upc.order.business
{
    public interface ICliente
    {
        DataTable ReaderByDni(int dni);
        bool Create(Cliente c);
        DataTable Reader();
    }
}
