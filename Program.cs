// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Console.WriteLine("***** CALCULADORA *******");
Calculadora miCalculadora = new Calculadora();
int menu;
double num,num1,num2,valor;
bool controlNum;

do
{
    Console.WriteLine("Ingrese que operacion desea realizar");
    Console.WriteLine("1-SUMA");
    Console.WriteLine("2-RESTA");
    Console.WriteLine("3-MULTIPLICACION");
    Console.WriteLine("4-DIVISION");
    Console.WriteLine("5-LIMPIAR");
    Console.WriteLine("6-SALIR");

    bool controlMenu = int.TryParse(Console.ReadLine(),out menu);
    if (controlMenu)
    {
            switch (menu)
            {
            case 1:
                    Console.WriteLine("Ingrese el numero a sumar:");
                    controlNum = double.TryParse(Console.ReadLine(),out num);
                    if (controlNum)
                    {
                        miCalculadora.Suma(num);
                    }
                break;
            case 2:
                    Console.WriteLine("Ingrese el numero a restar:");
                    controlNum = double.TryParse(Console.ReadLine(),out num);
                    if (controlNum)
                    {
                        miCalculadora.Restar(num);
                    }
                break;
            case 3:
                    Console.WriteLine("Ingrese el numero a multiplicar:");
                    controlNum = double.TryParse(Console.ReadLine(),out num);
                    if (controlNum)
                    {
                        miCalculadora.Multiplicar(num);
                    }
                break;
            case 4:
                    Console.WriteLine("Ingrese el numero a dividir:");
                    controlNum = double.TryParse(Console.ReadLine(),out num);
                    if (controlNum)
                    {
                        miCalculadora.Dividir(num);
                    }
                break;
            case 5:
                    miCalculadora.Limpiar();
                break;
            case 6:
                break;
            default:
                Console.WriteLine("Opcion ingresada incorrecta");
                break;
            }
            Console.WriteLine("El resultado es: "+miCalculadora.Resultado+"\n");
    }else
    {
        Console.WriteLine("Opcion ingresada incorrecta");
    }
} while (menu != 6);
        Console.WriteLine("////// Calculadora Cerrada ///////");


