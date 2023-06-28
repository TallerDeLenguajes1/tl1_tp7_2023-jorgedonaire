// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;

class Program
{
    private static void Main(){
        //Creacion de empleados
        Empleado empleado1 = new Empleado("Jorge","Donaire",new DateTime(1993,02,24),'S','M',new DateTime(2020,01,20),125000,cargos.Ingeniero);
        Empleado empleado2 = new Empleado("Juan","Perez",new DateTime(2005,06,10),'C','F',new DateTime(2015,11,15),250000,cargos.Auxiliar);
        Empleado empleado3 = new Empleado("Sofia","Lopez",new DateTime(1995,08,13),'S','F',new DateTime(2018,03,05),325000,cargos.Especialista);
    }
}