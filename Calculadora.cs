namespace EspacioCalculadora;

public class Calculadora
{
    private double valor;

    public Calculadora(){
        valor = 0; //inicializa la calculadora con el valor cero, pero puede entrar un valor por parametro
    }

    public void Suma(double sumando){
        valor+=sumando;
    }

    public double Resultado { get => valor; }
}

