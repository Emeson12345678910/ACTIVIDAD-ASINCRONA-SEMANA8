
using Atividad_Asinrona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividad_Asincrona.DAO
{
    public class Producto
    {

        public class CrudProductos
        {
            public void AgregarProductos(Producto ParametroosProductos)
            {
                using (AlmacenContext db = new AlmacenContext())
                {
                    Producto producto = new Producto();
                    producto.Nombre = ParametroosProductos.Nombre;
                    producto.Descripcion = ParametroosProductos.Descripcion;
                    producto.Precio = ParametroosProductos.Precio;
                    producto.Stock = ParametroosProductos.Stock;
                    db.Add(producto);
                    db.SaveChanges();
                }
            }
        }
    }
}

