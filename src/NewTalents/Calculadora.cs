namespace src.NewTalents;

public class Calculadora
{   
    public Calculadora()
    {
    }

    public int Somar(int x, int y)
    {
        int res = x + y;
        return res;
    }

    public int Subtrair(int x, int y)
    {
        int res = x - y;
        return res;
    }
    public int Multiplicar(int x, int y)
    {
        int res = x * y;
        return res;
    }
    public int Dividir(int x, int y)
    {
        int res = x / y;
        return res;
    }
}