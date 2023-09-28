Console.WriteLine("Ingrese el valor de a : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor de b : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el valor de c : ");
int c = Convert.ToInt32(Console.ReadLine());


double potencia_RAIZ = Math.Pow(b, 2);


double multi = 4 * a * c;

double resta_Raiz = potencia_RAIZ - multi;

double raiz_Cuadrada = Math.Sqrt(resta_Raiz);


double redon_Raiz = Math.Round(raiz_Cuadrada, 2);


double multiplicacion_Abajo = 2 * a;

double resultado_Positivo = (-b + redon_Raiz) / multiplicacion_Abajo;
double resultado_Negativo = (-b - redon_Raiz) / multiplicacion_Abajo;

Console.WriteLine("tu funcion cuadratica en positivo es : " + resultado_Positivo);
Console.WriteLine();
Console.WriteLine("tu funcion cuadratica en negativo es : " + resultado_Negativo);