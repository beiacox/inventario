using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;

namespace capa_negocios
{
    public class ArticulosN
    {
        private readonly ArticulosD obj = new ArticulosD();
        private readonly Random RNG = new Random();

        public List<articulos> GetArticulos()
        {
            return obj.List_Articulos();
        }

        public void SetArticulo(articulos art)
        {
            art.ID = RNG.Next();

            obj.Add_Articulo(art);
        }

        public void DeleteArticulo(articulos art)
        {
            obj.Drop_Articulo(art);
        }

    }
}
