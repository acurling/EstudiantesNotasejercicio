// See https://aka.ms/new-console-template for more information

byte i =1; int cont = 0; float acumulador=0; float notas = 0;

while (i<=5)
{
    Console.Write("Ingrese la nota:");
    // ingresar las notas
    float.TryParse(Console.ReadLine(), out notas);
    //acumulador
    acumulador += notas;  // acumulador = acumulador + notas
    i++;
}

float promedio = acumulador / 5;

Console.WriteLine( $"El promedio de {promedio}");
i = 1; int cantidad = 0;
while (i<=5)
{
    Console.Write("Ingrese la nota:");
    // ingresar las notas
    float.TryParse(Console.ReadLine(), out notas);
    if (notas > promedio)
        cantidad++;

    i++;
}
Console.WriteLine($"La cantidad de estudiante {cantidad}");