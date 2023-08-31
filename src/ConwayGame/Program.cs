using System;

namespace Conwaygame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\rodri\OneDrive\Escritorio\Coding\Visual studio\Programacion 2 c#\ConwayGame\src\Library\archivo.txt"; // La ruta relativa no funciona, copiar ruta exacta.
            bool[,] gameBoard = LeerArchivo.LeerTablero(filePath);

            while (true)
            {
                PrintTablero.ImprimirTablero(gameBoard, 10);    //El segundo parametro es la cantidad de generaciones. :)
                gameBoard = Logica.CalcularSiguienteGeneracion(gameBoard);
            }
        }
    }
}
