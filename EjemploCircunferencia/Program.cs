System.Console.Write("Ingrese radio circunferencia:");
double radio = Convert.ToDouble(Console.ReadLine());

double area, perimetro;

area = Math.PI * radio * radio;
perimetro = Math.PI * 2 * radio;

System.Console.WriteLine($"El area es: {area}");
System.Console.WriteLine($"El perimetro es: {perimetro}");