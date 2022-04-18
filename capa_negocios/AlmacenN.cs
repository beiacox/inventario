using System;
using System.Collections.Generic;
using System.Linq;
using capa_datos;
using System.Text;
using capa_entidad;
using System.Threading.Tasks;

namespace capa_negocios
{
    class AlmacenN
    {
        private readonly almecenD obj = new almecenD();
        private readonly Random RNG = new Random();

        public List<Almacen> GetAlmecen()
        {
            return obj.List_Almecen();
        }
        public void SetAlmacen(Almacen alm)
        {
            alm.ID = RNG.Next();
            obj.Add_Almacen(alm);
        }
        public void DeleteAlmacen(Almacen alm)
        {
            obj.Drop_Alnecen(alm);
        }
    }
}
