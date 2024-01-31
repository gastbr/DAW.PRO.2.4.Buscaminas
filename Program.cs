using DAW.PRO._2._4.Buscaminas;

internal class Program
{
    public static Random rng = new Random();
    private static void Main(string[] args)
    {
        Tablero tablero = new Tablero();
        tablero.dibujaTablero();
    }
}