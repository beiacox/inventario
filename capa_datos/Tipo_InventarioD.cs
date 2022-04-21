using System;
using System.Collections.Generic;
using System.Linq;
using capa_entidad;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class Tipo_InventarioD
    {
        private readonly todayEntities3 db = new todayEntities3();
        public List<TPinventario> List_Inventarios()
        {
            return db.TPinventario.ToList();
        }
        public void Add_TPinventario(TPinventario tpi)
        {
            db.TPinventario.Add(tpi);
            db.SaveChanges();
        }
        public void Drop_TPinventario(TPinventario tpi)
        {
            var Tentidad = db.TPinventario.FirstOrDefault(a => a.ID == tpi.ID);

            db.TPinventario.Remove(Tentidad);
            db.SaveChanges();
        }
    }
}
