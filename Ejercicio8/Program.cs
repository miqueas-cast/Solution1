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

int jugadores = ValidacionEntradas("Ingrese cantidad de jugadores: ", 0, int.MaxValue);
int niveles = ValidacionEntradas("Ingres cantidad de niveles: ", 0, int.MaxValue);

int[,] controlPuntajes = new int[jugadores, niveles];

int puntajeAlto = 0;
for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        controlPuntajes[i, j] = ValidacionEntradas($"Ingrese puntaje del jugador No.{i+1}: ",0, int.MaxValue);
        if (controlPuntajes[i,j] > puntajeAlto)
        {
            puntajeAlto = controlPuntajes[i, j];
        }
    }
}

Console.WriteLine($"El puntaje mas alto fue: {puntajeAlto}");