using capa_entidad;
using System.Collections.Generic;
using System.Linq;

namespace capa_datos
{
    public class ExistenciasD
    {
        private readonly todayEntities3 db = new todayEntities3();

        public List<existenciasXalmacen> List_Existencias()
        {
            return db.existenciasXalmacen.ToList();
        }
        public void Add_Existencia(existenciasXalmacen ext)
        {
            db.existenciasXalmacen.Add(ext);
            db.SaveChanges();
        }
        public void Drop_Existencia(existenciasXalmacen ext)
        {
            var Eentidad = db.existenciasXalmacen.FirstOrDefault(a => a.IDarticulo == ext.IDarticulo);

            db.existenciasXalmacen.Remove(Eentidad);
            db.SaveChanges();
        }
    }
}
