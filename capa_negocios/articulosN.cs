using System;
using capa_datos;
using capa_entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocios
{
    public class articulosN
    {
        articulosD obj = new articulosD();

        Random RNG = new Random();
        public List<articulos> GetArticulos()
        {
            return obj.list_articulos();
        }

        public void setarticulo(articulos art)
        {
            art.ID = RNG.Next();
            
            obj.add_articulo(art);
        }

    }
}
