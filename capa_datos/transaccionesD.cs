using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capa_entidad;
using System.Threading.Tasks;

namespace capa_datos
{
    public class transaccionesD
    {
        private readonly todayEntities3 db = new todayEntities3();

        public List<transacciones> List_Transacciones()
        {
            return db.transacciones.ToList();
        }
        public void Add_Tracsaccion(transacciones trans)
        {
            db.transacciones.Add(trans);
            db.SaveChanges();
        }
        public void Drop_transaccion(transacciones trans)
        {
            var Tentidad = db.transacciones.FirstOrDefault(a => a.ID == trans.ID);

            db.transacciones.Remove(Tentidad);
            db.SaveChanges();
        }
    }
}
