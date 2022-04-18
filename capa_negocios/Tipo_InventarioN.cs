using System;
using System.Collections.Generic;
using System.Linq;
using capa_datos;
using capa_entidad;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocios
{
    public class Tipo_InventarioN
    {
        private readonly Tipo_InventarioD obj = new Tipo_InventarioD();
        private readonly Random RNG = new Random();

        public List<TPinventario> GetPinventarios()
        {
            return obj.List_Inventarios();
        }
        public void SetInventario(TPinventario tpi)
        {
            obj.Add_TPinventario(tpi);
        }
        public void DeleteInventario(TPinventario tpi)
        {
            obj.Drop_TPinventario(tpi);
        }
    }
}
