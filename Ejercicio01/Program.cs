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

int filas = ValidacionEntradas("Ingrese la cantidad de zonas: ", 0, int.MaxValue);
int columnas = ValidacionEntradas("Ingrese la cantidad de días: ", 0, 31);

int[,] matriz = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        matriz[i, j] = ValidacionEntradas($"Ingrese el valor:", 0, int.MaxValue);
    }
}
for (int k = 0; k < filas; k++)
{
    for (int l = 0; l < columnas; l++)
    {
        Console.Write(matriz[k,l]+ " ");
    }
    Console.WriteLine();
}