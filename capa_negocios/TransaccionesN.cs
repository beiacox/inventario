using System;
using System.Collections.Generic;
using System.Linq;
using capa_datos;
using capa_entidad;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocios
{
    class TransaccionesN
    {
        private readonly transaccionesD obj = new transaccionesD();
        private readonly Random RNG = new Random();

        public List<transacciones> GetTransacciones()
        {
            return obj.List_Transacciones();
        }
        public void SetTransaccion(transacciones trans)
        {
            obj.Add_Tracsaccion(trans);
        }
        public void DeleteTransacccion(transacciones trans)
        {
            obj.Add_Tracsaccion(trans);
        }

    }
}
