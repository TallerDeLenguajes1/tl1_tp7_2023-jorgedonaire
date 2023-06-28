namespace EspacioEmpleado;

public enum cargos
{
    Auxiliar = 1,
    Administrativo = 2,
    Ingeniero = 3,
    Especialista = 4,
    Investigador = 5,
}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private cargos cargo;

    private int edadJubilacionMasc = 65;
    private int edadJubilacionFem = 60;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal cargos Cargo { get => cargo; set => cargo = value; }

    public Empleado(){

    }

    public Empleado( string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, cargos cargo)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.FechaDeNacimiento = fechaDeNacimiento;
        this.EstadoCivil = estadoCivil;
        this.Genero = genero;
        this.FechaIngreso = fechaIngreso;
        this.SueldoBasico = sueldoBasico;
        this.Cargo = cargo;
    }

    //Metodos
    public int Antiguedad(){
        int antiguedad = DateTime.Now.Year - FechaIngreso.Year;
        return antiguedad;
    }
    public int Edad(){
        int edad = DateTime.Now.Year - fechaDeNacimiento.Year;
        return edad;
    }
    public int aniosParaJubilarse(){
        if (Genero == 'M')
        {
            return (edadJubilacionMasc - Edad());
        }else
        {
            return (edadJubilacionFem - Edad());
        }
    }

    public double Salario(){
        double Adicional = 0;
        int antiguedad = Antiguedad();

        if (antiguedad <= 20)
        {
            Adicional = antiguedad * SueldoBasico * 1.01;
        }else
        {
            Adicional = SueldoBasico * 1.25;
        }

        if (Cargo == cargos.Ingeniero || Cargo == cargos.Especialista)
        {
            Adicional += SueldoBasico * 1.5;
        }

        if (estadoCivil == 'c')
        {
            Adicional += 15000;
        }

        return (SueldoBasico + Adicional);
    }

}

