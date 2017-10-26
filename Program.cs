using System; //bibliotecas proprias do .Net Core

namespace Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Fusca", "Amarelo");
            c1.MostrarDados();
        }
    }
}
