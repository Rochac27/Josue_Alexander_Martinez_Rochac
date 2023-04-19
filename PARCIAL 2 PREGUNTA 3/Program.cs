int numero1 = 10;
string numero2 = "5";
int resultado = 0;

try
{
    resultado = numero1 + Convert.ToInt32(numero2);
    Console.WriteLine("El resultado de la operación es: " + resultado);
}
catch
{
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}