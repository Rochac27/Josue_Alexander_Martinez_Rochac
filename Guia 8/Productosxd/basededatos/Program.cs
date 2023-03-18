// See https://aka.ms/new-console-template for more information
using basededatos.Models;

Console.WriteLine("Hello, World!");

using (ProductosContext db = new ProductosContext())
{
    Productosxd productosxd = new Productosxd();

    Console.WriteLine("Ingrese el nombre");
    productosxd.Nombre = (Console.ReadLine());

    Console.WriteLine("Ingrese una descripcion");
    productosxd.Descripcion = (Console.ReadLine());

    Console.WriteLine("Ingrese el precio");
    productosxd.Precio = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese los stocks");
    productosxd.Stock = int.Parse(Console.ReadLine());

    db.Productosxds.Add(productosxd);
    db.SaveChanges();


    var ListProductosxd = db.Productosxds.ToList();

    foreach (var usu in ListProductosxd)
    {
        Console.WriteLine(usu.Nombre);
    }
}