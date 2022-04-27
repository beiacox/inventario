using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;

namespace capa_negocios
{
    public class AlmacenN
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
