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
        private readonly transaccionesD obj2 = new transaccionesD();
        private readonly transacciones trans2 = new transacciones();

        public List<articulos> GetArticulos()
        {
            return obj.List_Articulos();
        }
        public void SetArticulo(articulos art)
        {

            art.ID = RNG.Next();
            trans2.ID = RNG.Next();
            trans2.IDarticulo = art.ID;
            trans2.Tipo = "entrada";
            trans2.fecha = DateTime.Now;

            obj.Add_Articulo(art);
            obj2.Add_Tracsaccion(trans2);
        }
        public void DeleteArticulo(articulos art)
        {
            obj.Drop_Articulo(art);
        }

    }
}
