using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;

namespace capa_negocios
{
    public class ExistenciasN
    {
        private readonly ExistenciasD obj = new ExistenciasD();
        private readonly Random RNG = new Random();

        public List<existenciasXalmacen> GetExistencias()
        {
            return obj.List_Existencias();
        }
        public void SetExistencias(existenciasXalmacen ext)
        {
            obj.Add_Existencia(ext);
        }
        public void DeleteExistencia(existenciasXalmacen ext)
        {
            obj.Drop_Existencia(ext);
        }
    }
}
