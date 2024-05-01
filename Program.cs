namespace Frete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a distância: ");
            int distancia = int.Parse(Console.ReadLine());

            Console.Write("Digite o peso da mercadoria: ");
            int peso = int.Parse(Console.ReadLine());

            double frete = CalcularFrete(distancia, peso);

            Console.WriteLine($"O valor do frete é: R$ {frete:F2}");
        }

        /// </summary>
        /// <param name="posicaoInical"></param>
        /// <param name="distancia"></param>
        /// <param name="peso"></param>
        /// <returns></returns>
        public static double CalcularFrete(int distancia, int peso)
        {
            double valorFrete = distancia * 0.01;

            if (distancia >= 200)
            {
                valorFrete += (distancia / 200) * 1.00;
            }

            if (distancia >= 1000)
            {
                valorFrete += (distancia / 1000) * 10.00;
            }

            if (peso > 5 && peso <= 25)
            {
                valorFrete *= 5;
            }
            else if (peso > 25 && peso <= 75)
            {
                valorFrete *= 3;
            }
            return valorFrete;
        }
    }
}
