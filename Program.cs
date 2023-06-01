// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Console.WriteLine("***** CALCULADORA *******");
Calculadora miCalculadora = new Calculadora();
int menu;
double number,valor;

Console.WriteLine("Ingrese que operacion desea realizar");
Console.WriteLine("1-SUMA");
Console.WriteLine("2-RESTA");
Console.WriteLine("3-MULTIPLICACION");
Console.WriteLine("4-DIVISION");
bool controlMenu = int.TryParse(Console.ReadLine(),out menu);
if (controlMenu)
{
    switch (menu)
    {
        case 1:
            Console.WriteLine("Ingrese numero a sumar:");
            bool controlSuma = double.TryParse(Console.ReadLine(),out valor);
            if (controlSuma)
            {
                number = double.Parse(Console.ReadLine());
            }else
            {
                Console.WriteLine("");
            }
            
            while (true)
            {
                
            }
            miCalculadora.Suma(number);
            miCalculadora.Suma(number);
            Console.WriteLine(miCalculadora.Resultado);
            break;
        case 2:

        case 3:

        case 4:

        default:
            Console.WriteLine("Opcion ingresada incorrecta");
            break;
    }
}else
{
    Console.WriteLine("Opcion ingresada incorrecta");
}
