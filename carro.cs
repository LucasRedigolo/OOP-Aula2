namespace Veiculo // são bibliotecas que a gente cria para organizar metodos e o seu código
{
    using System;

    public class Carro
    {
        private string Nome { get; set; }
        private string Modelo { get; set; }

        public Carro(string Nome)
        {
            MostrarDados(Nome);
        }

        public Carro(string Nome1, string Modelo1)
        {
            this.Nome = Nome1;
            this.Modelo = Modelo1;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Instancio a classe " + this.Modelo + " " + this.Nome);
        }

        private void MostrarDados(string dados)
        {
            Console.WriteLine("Instancio a classe " + dados);
        }

    }

}
