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
        if(valor < min && valor > max)
        {
            Console.WriteLine("Valor fuera del rango");
        }
    } while (!esValido);
    return valor;
}
int estudiantes = ValidacionEntradas("Ingrese la cantidad de estudianes:", 0, int.MaxValue);

int dias = ValidacionEntradas("Ingrese cantidad de días: ", 0, int.MaxValue);

int[,] asistencia = new int[estudiantes, dias];

for (int i = 0; i< estudiantes; i++)
{
    for (int j= 0; j< dias; j++)
    {
        asistencia[i, j] = ValidacionEntradas($"Ingrese asistencia del estudiante {i+1} en el día {j+1}:\n1. Asistio\n0. No asistio\n >", 0, 1);
    }
}

int buscarEstudiante = ValidacionEntradas("¿Cual estudiante desea buscar?: ",0, estudiantes);

for(int i = 0;i< estudiantes; i++)
{
    if (i == (buscarEstudiante-1))
    {
        for (int j = 0;  j< dias; j++)
        {
            Console.Write(asistencia[i, j]+" ");
        }
        Console.WriteLine("\n1 = asisitio\n2 = no asistio");
    }
}