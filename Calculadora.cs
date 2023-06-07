namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;

    public Calculadora(){
        dato = 0; //inicializa la calculadora con el valor cero, pero puede entrar un valor por parametro
    }

    public void Suma(double termino){
        dato+=termino;
    }

    public void Restar(double termino){
        dato-=termino;
    }

    public void Multiplicar(double termino){
        dato*=termino;
    }

    public void Dividir(double termino){
        if (termino != 0)
        {
            dato/=termino;
        }
    }

    public void Limpiar(){
        dato = 0;
    }
    public double Resultado { get => dato; }
}

