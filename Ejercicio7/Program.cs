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

int maquinas = ValidacionEntradas("Ingrese la cantidad de maquinas: ", 0, int.MaxValue);
int turnos = ValidacionEntradas("Ingrese cantidad de turnos: ", 0, int.MaxValue);

int[,] produccionFabrica = new int[maquinas, turnos];

int cantidadTurnos = 0;

for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        produccionFabrica[i, j] = ValidacionEntradas($"Ingrese turnos de la maquina {i + 1}: ", 0, 100);
        cantidadTurnos += produccionFabrica[i, j];
    }
}

Console.WriteLine($"Cantidad de turnos totales:{cantidadTurnos}");