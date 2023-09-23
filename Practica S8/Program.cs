//Pracica dia sabado 

//Math.Cbrt(double)Metodo raiz cubica

/*double RaizCubica1 = Math.Cbrt(8);

int[] re = { 8, 27, 125};

foreach(int i in re)
{
    Console.WriteLine(Math.Cbrt(i));
}*/

//--------------------------------------------------

//DateTime

DateTime DtToday = DateTime.Now;  //Muestra hora y fecha del sistema actual
//Console.WriteLine(DtToday);

//--------------------------------------------------

/*Console.WriteLine(DtToday.ToString("F")); //ToString puede convertir en el formato que deseemos ya sea hora y fecha

Console.WriteLine(DtToday.ToString("g"));

Console.WriteLine(DtToday.ToString("ddd MMM yyyy"));*/

//--------------------------------------------------
//AddMonths sirve para agregar meses

//Console.WriteLine(DtToday.AddMonths(3));

//--------------------------------------------------
//AddYears para agregar años

//Console.WriteLine(DtToday.AddYears(4));

//--------------------------------------------------
//AddDays cambia dia y hora

//Console.WriteLine(DtToday.AddDays(1.5));

//--------------------------------------------------
//AddHours Agregar horas

//Console.WriteLine(DtToday.AddHours(24));

//--------------------------------------------------
//AddMinutes Agregar Minutos

//Console.WriteLine(DtToday.AddMinutes(1440));

//--------------------------------------------------
//DayOfWeek fecha al dia acual 

//Console.WriteLine(DtToday.DayOfWeek);

//--------------------------------------------------
//DayOfYear numero del dia del año 

//Console.WriteLine(DtToday.DayOfYear);

//--------------------------------------------------
//Cambiar datos implicitamente

int Entero = 10;
string Flotante = Entero.ToString();
Console.WriteLine(Flotante.GetType());

short Corto = 10;
int Entero2 = Corto;
Console.WriteLine(Entero2.GetType());

int a = 10;
long b = a;
Console.WriteLine(b.GetType());

float c = 3.14f;
double d = c;
Console.WriteLine(d.GetType());

char e = 'A';
int f = e;
Console.WriteLine(f.GetType());

double ValorDouble = 3.1416;
int ValorInt = (int)ValorDouble;
Console.WriteLine(ValorInt);

int num1 = 10;
double num2 = 5.57;
double res = num1 * num2;
Console.WriteLine(res);

string num3 = "Hola";
Console.WriteLine(num3.Cast<int>());
