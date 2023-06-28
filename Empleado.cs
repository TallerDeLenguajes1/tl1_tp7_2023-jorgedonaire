namespace Empleado;

public class Empleado
{
    private string Nombre;
    private string Apellido;
    private datetime FechaDeNacimiento;
    private char EstadoCivil;
    private char Genero;
    private datetime FechaIngreso;
    private double SueldoBasico;
    private cargos Cargo;

    public datetime antiguedad(){
        antiguedad = FechaIngreso
    }
    public datetime edad(){

    }
    public int aniosParaJubilarse(){

    }
}

enum cargos
{
    Auxiliar = 1;
    Administrativo = 2;
    Ingeniero = 3;
    Especialista = 4;
    Investigador = 5;
}