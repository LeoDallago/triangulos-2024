namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        public int x;
        public int y;
        public int z;

        public string tipo = "";

        public void DefineTriangulo()
        {

            if (x == y && y == z)
            {
                tipo = "Equilatero";
            }
            else if (x == z || x == y || y == x || y == z || z == x || z == y)
            {
                tipo = "Isosceles";
            }
            else if (x != y && y != z)

            {
                tipo = "Escaleno";
            }
        }
    }
}
