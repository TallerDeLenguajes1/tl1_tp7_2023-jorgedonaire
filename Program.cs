// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;

class Program
{
    private static void Main(){

        //Creacion de empleados
        Empleado empleado1 = new Empleado("Jorge","Donaire",new DateTime(1993,02,24),'C','M',new DateTime(2020,01,20),100000,cargos.Ingeniero);
        Empleado empleado2 = new Empleado("Juan","Perez",new DateTime(1994,06,10),'C','M',new DateTime(2015,11,15),250000,cargos.Auxiliar);
        Empleado empleado3 = new Empleado("Sofia","Lopez",new DateTime(1995,08,13),'C','F',new DateTime(2008,03,05),65000,cargos.Especialista);
    
        double salario1 = empleado1.Salario();
        Console.WriteLine("El salario del Empleado 1 es: "+ salario1);
        double salario2 = empleado2.Salario();
        Console.WriteLine("El salario del Empleado 1 es: "+ salario2);
        double salario3 = empleado3.Salario();
        Console.WriteLine("El salario del Empleado 1 es: "+ salario3);
    
        double salarioTotal = salario1+salario2+salario3;
        Console.WriteLine("El monto total que se paga en concepto de salarios es: "+ salarioTotal);


        if (empleado1.aniosParaJubilarse() < empleado2.aniosParaJubilarse() && empleado1.aniosParaJubilarse() < empleado3.aniosParaJubilarse())
        {
            mostrarDatosEmpleado(empleado1);
        }else
        {
            if (empleado2.aniosParaJubilarse() < empleado1.aniosParaJubilarse() && empleado2.aniosParaJubilarse() < empleado3.aniosParaJubilarse())
            {
                mostrarDatosEmpleado(empleado2);                
            }else
            {
                mostrarDatosEmpleado(empleado3);
            }
        }
    }
    public static void mostrarDatosEmpleado(Empleado empleado){
        Console.WriteLine("***** Datos del empleado más proximo a jubilarse *****");
        Console.WriteLine("Nombre: " + empleado.Nombre + "," + empleado.Apellido);
        Console.WriteLine("Fecha de Nacimiento: "+ empleado.FechaDeNacimiento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Edad: " + empleado.Edad());
        if (empleado.EstadoCivil == 'S')
        {
            Console.WriteLine("Estado civil: Soltero");            
        }else
        {
            Console.WriteLine("Estado civil: Casado");                        
        }

        if (empleado.Genero == 'F')
        {
            Console.WriteLine("Femenino");
        }else
        {
            Console.WriteLine("Masculino");
        }
        Console.WriteLine("Fecha de ingreso: "+ empleado.FechaIngreso.ToString("dd/MM/yyyy"));
        Console.WriteLine("Sueldo basico: "+empleado.SueldoBasico);
        Console.WriteLine("Cargo: "+empleado.Cargo);
        Console.WriteLine("Salario: " + empleado.Salario());
        Console.WriteLine("Antiguedad del empleado: "+ empleado.Antiguedad());
        Console.WriteLine("Cantidad de anios que le faltan para jubilarse: "+empleado.aniosParaJubilarse());
        Console.WriteLine("****************************");
    }
}