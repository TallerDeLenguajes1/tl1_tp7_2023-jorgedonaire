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

    public void Restar(double restando){

    }

    public void Multiplicar(double multiplicando){
        
    }

    public void Dividir(double valor){
        
    }
    public double Resultado { get => valor; }
}

