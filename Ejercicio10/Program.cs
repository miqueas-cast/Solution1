static int ValidacionEntradas(string mensaje, int min, int max)
{
    int valor;
    bool esValido;
    do
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine();
        esValido = int.TryParse(entrada, out valor) && valor >= min && valor <= max;
        if (!esValido)
        {
            Console.Clear();
            Console.WriteLine($"Por favor, ingresa un número.");
        }
        if (valor < min && valor > max)
        {
            Console.WriteLine("Valor fuera del rango");
        }
    } while (!esValido);
    return valor;
}

int socursales = ValidacionEntradas("Ingrese antidad de sucursales: ", 0, int.MaxValue);
int productos = ValidacionEntradas("Ingrese cantidad de productos: ", 0, int.MaxValue);

int[,] ventas = new int[socursales, productos]; 

for (int i = 0; i < socursales; i++)
{
    for (int j = 0; j < productos; j++)
    {
        ventas[i,j] = ValidacionEntradas("Ingrese cantidad de ventas del producto No. " + (j+1) + " en la sucursal No. " + (i+1) + ": ", 0, int.MaxValue);
    }
}

int productosSocursal = ValidacionEntradas("¿De que socursal desea ver el inventario: ", 0, int.MaxValue);

for (int i = 0;i < socursales; i++)
{
    if (i == (productosSocursal-1))
    {
        for (int j = 0; j < productos; j++)
        {
            Console.WriteLine("Producto No. " + (j+1) + ": " + ventas[i, j] + " ventas");
        }
    }
}
