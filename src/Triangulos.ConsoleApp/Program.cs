namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ola, {Environment.MachineName}");
            Console.WriteLine("Triangulos Orientados a Objetos!");
            Console.WriteLine("\n");

            Console.WriteLine("Exemplos");
            Triangulo fazTriangulo = new Triangulo();

            fazTriangulo.x = 1;
            fazTriangulo.y = 1;
            fazTriangulo.z = 1;

            fazTriangulo.DefineTriangulo();

            Console.WriteLine($"o triangulo eh {fazTriangulo.tipo}");

            Console.WriteLine("\n");
            Console.WriteLine("Agora deixo em suas maos");

            Triangulo fazTrianguloManual = new Triangulo();

            Console.WriteLine("Informe o PRIMEIRO LADO do triangulo");
            fazTrianguloManual.x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o SEGUNDO LADO do triangulo");
            fazTrianguloManual.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o TERCEIRO LADO do triangulo");
            fazTrianguloManual.z = Convert.ToInt32(Console.ReadLine());

            fazTrianguloManual.DefineTriangulo();

            Console.WriteLine($"o resultado do seu triangulo eh {fazTrianguloManual.tipo}");
        }
    }
}
