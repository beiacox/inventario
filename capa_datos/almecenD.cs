using capa_entidad;
using System.Collections.Generic;
using System.Linq;

namespace capa_datos
{
    public class almecenD
    {
        private readonly todayEntities3 db = new todayEntities3();

        public List<Almacen> List_Almecen()
        {
            return db.Almacen.ToList();
        }
        public void Add_Almacen(Almacen alm)
        {
            db.Almacen.Add(alm);
            db.SaveChanges();
        }
        public void Drop_Alnecen(Almacen alm)
        {
            var Aentidad = db.Almacen.FirstOrDefault(a => a.ID == alm.ID);

            db.Almacen.Remove(Aentidad);
            db.SaveChanges();
        }
    }
}
