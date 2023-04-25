using EjemploCircunferenciaObjetos;

System.Console.Write("Ingrese radio circunferencia:");
double radio = Convert.ToDouble(Console.ReadLine());

Circunferencia circunferencia = new Circunferencia(radio);

var area = circunferencia.CalcularArea();

System.Console.WriteLine($"El area es: {area}");

System.Console.WriteLine($"El perimetro es: {circunferencia.CalcularPerimetro()}");