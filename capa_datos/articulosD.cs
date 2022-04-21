using capa_entidad;
using System.Collections.Generic;
using System.Linq;

namespace capa_datos
{
    public class ArticulosD
    {
        private readonly todayEntities3 db = new todayEntities3();

        public List<articulos> List_Articulos()
        {
            return db.articulos.ToList();
        }
        public void Add_Articulo(articulos art)
        {
            db.articulos.Add(art);
            db.SaveChanges();
        }
        public void Drop_Articulo(articulos art)
        {
            var Aentidad = db.articulos.FirstOrDefault(a => a.ID == art.ID);
            
            db.articulos.Remove(Aentidad);
            db.SaveChanges();


        }
    }
}
