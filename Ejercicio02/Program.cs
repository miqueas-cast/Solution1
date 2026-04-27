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
    } while (!esValido);
    return valor;
}


int filas = ValidacionEntradas("Ingrese el numero de productos:", 0, int.MaxValue);

int columnas = ValidacionEntradas("Ingrese la cantidad de días:", 0, int.MaxValue);

int[,] matriz = new int[filas, columnas];


for (int i = 0; i < filas; i++)
{
    for(int j = 0; i < columnas; j++)
    {
        matriz[i, j] = ValidacionEntradas("Ingrese el primer valor: ", 0, int.MaxValue);
    }
}
int producto = ValidacionEntradas("Ingrese el producto a buscar: ", 0, filas);


for (int a = 0; a < filas; a++)
{
    if (producto == a)
    {
        for (int j= 0;  j < columnas; j++)
        {
            Console.WriteLine(matriz[a,j] + " ");
        }
        Console.WriteLine("");
    }
}