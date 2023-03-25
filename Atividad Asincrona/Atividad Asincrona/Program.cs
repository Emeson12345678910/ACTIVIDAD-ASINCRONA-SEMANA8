using Atividad_Asincrona.Moldels
using Atividad_Asincrona.DAO

Console.WriteLine();

Console.WriteLine("            · · · · ·· · · ·  ··  ··  · · ·  · ·  · · · · · ·  · · ·  · ·  ·       ");
Console.WriteLine("             BIENVENIDO HA INSERTAR PRODUCTOS EN LA BASE DE DATOS <ALMACEN>        ");
Console.WriteLine("           ###################################################################       ");

CrudProductos crudProductos = new CrudProductos();
Producto producto = new Producto();

Console.WriteLine("Menu");
Console.WriteLine("=> Pulse la tecla  1 para insertar productos en la base de datos ");
Console.WriteLine("=> Pulse la tecla  2 para recibir un regalo inesperado ");
Console.WriteLine();
var Menu = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.Write("- Ingresa El nombre de el producto:  ");
            producto.Nombre = Console.ReadLine();
            Console.Write("- Ingresa la descripcion de el producto:  ");
            producto.Descripcion = Console.ReadLine();
            Console.Write("- Ingresa el precio de el producto ingresado: ");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("- Ingrese la cantidad de productos: ");
            producto.Stock = Convert.ToInt32(Console.ReadLine());
            crudProductos.AgregarProductos(producto);
            Console.WriteLine();
            Console.WriteLine("EL PRODUCTO SE REGISTRO CORRECTAMENTE, GRACIAS POR INGRESAR SUS DATOS");
            Console.WriteLine();
            Console.WriteLine("=> Pulsa 1 para continuar insertando usuarios");
            Console.WriteLine("=> Pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;

        Console.WriteLine();

    case 2:
        Console.WriteLine("¡Gracias por utilizar esté programa!");

        Console.WriteLine();
        Console.WriteLine("=> Pulsa 0 para salir");
        Console.WriteLine();
        bucle = Convert.ToInt32(Console.ReadLine());




        break;


}


