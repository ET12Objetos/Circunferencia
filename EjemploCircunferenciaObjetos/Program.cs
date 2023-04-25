using EjemploCircunferenciaObjetos;

Console.Write("Ingrese radio circunferencia:");
double radio = Convert.ToDouble(Console.ReadLine());

Circunferencia circunferencia = new Circunferencia(radio);

var area = circunferencia.CalcularArea();

Console.WriteLine($"El area es: {area}");
Console.WriteLine($"El perimetro es: {circunferencia.CalcularPerimetro()}");

//circunferencia.radio = -1000;
//NO DEBE PASAR !!!! porque no se realizar ninguna validacion del radio

//circunferencia.radio = 1000; porque atributo radio es privado
//circunferencia.SetRadio(-1000);
circunferencia.Radio = 1000;

area = circunferencia.CalcularArea();

Console.WriteLine($"El area es: {area}");
Console.WriteLine($"El perimetro es: {circunferencia.CalcularPerimetro()}");
