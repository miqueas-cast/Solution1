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

int filas = ValidacionEntradas("Ingrese cantidad filas de la matriz: ", 0, int.MaxValue);
int columnas = ValidacionEntradas("Ingres cantidad de columnas: ", 0, int.MaxValue);

int[,] ubicacionError = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        ubicacionError[i, j] = ValidacionEntradas($"Ingrese valor de la {j + 1} en la fila No. {i+1}: ", 0, int.MaxValue);
    }
}

int errorBuscar = ValidacionEntradas($"Ingrese codigo de error a buscar: ", 0, int.MaxValue);

bool valor = false;
for (int i = 0;i < filas; i++)
{

    for (int j = 0;j < columnas; j++)
    {
        if (ubicacionError[i,j] == errorBuscar)
        {
            Console.WriteLine($"Codigo de error encontrado en la fila{i + 1} columna {j + 1}");
            valor = true;
        }
    }
}
if (valor != true)
{
    Console.WriteLine("Codigo de error no encontrado");
}