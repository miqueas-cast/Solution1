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

int estantes = ValidacionEntradas("Por favor ingrese la cantidad de estantes:", 0, int.MaxValue);
int niveles = ValidacionEntradas("Ingrese la cantidad niveles: ", 0, int.MaxValue);

int[,] matriz = new int[estantes, niveles];


for (int i = 0; i < estantes; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        matriz[i, j] = ValidacionEntradas("Ingrese el valor:", 0, int.MaxValue);
     
    }
}
int valorBuscar = ValidacionEntradas("Ingrese el valor a busar: ", 0, int.MaxValue);

for (int i = 0; i < estantes; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        if (valorBuscar == matriz[i,j])
        {
            Console.WriteLine($"Valor encontrado en la fila {i} y columna {j}");
        }
    }
}