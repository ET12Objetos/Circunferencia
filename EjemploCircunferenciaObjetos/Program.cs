using EjemploCircunferenciaObjetos;

Console.Write("Ingrese radio circunferencia:");
double radio = Convert.ToDouble(Console.ReadLine());

Circunferencia circunferencia = new Circunferencia(radio);

var area = circunferencia.CalcularArea();

Console.WriteLine($"El area es: {area}");
Console.WriteLine($"El perimetro es: {circunferencia.CalcularPerimetro()}");

circunferencia.Radio = 1000;

area = circunferencia.CalcularArea();

Console.WriteLine($"El radio es: {circunferencia.GetRadio()}");
Console.WriteLine($"El radio es: {circunferencia.Radio}");
Console.WriteLine($"El area es: {area}");
Console.WriteLine($"El perimetro es: {circunferencia.CalcularPerimetro()}");
