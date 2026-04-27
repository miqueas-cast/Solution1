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

int apartamentos = ValidacionEntradas("Por favor ingrese el número de apartamentos: ", 0, int.MaxValue);
int dias = ValidacionEntradas("Ingrese el número de días: ", 0 , int.MaxValue);

int[,] matriz = new int[apartamentos, dias];

int sumatotal = 0;

for (int i = 0; i < apartamentos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        matriz[i, j] = ValidacionEntradas("Ingrese el valor:", 0, int.MaxValue);

        sumatotal += matriz[i, j];
    }
}
Console.WriteLine(sumatotal);