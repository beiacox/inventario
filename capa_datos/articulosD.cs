using System;
using capa_datos;
using capa_entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class articulosD
    {
        todayEntities2 db = new todayEntities2();

        public List<articulos> list_articulos()
        {
            return db.articulos.ToList();
        }


        public void add_articulo(articulos art)
        {
            db.articulos.Add(art);
            db.SaveChanges();
        }
    }
}
