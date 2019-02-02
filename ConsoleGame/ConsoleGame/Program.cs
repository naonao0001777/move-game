using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            string end = Console.ReadKey().Key.ToString();
            do
            {
                board.DrawingBoard();
                Console.Clear();
            }
            while (end != "F");
        }
    }
    public class Board
    {
        public int cursorX { set; get; }
        public int cursorY { set; get; }
        public int x { set; get; }
        public int y { set; get; }
        

        public void DrawingBoard()
        {
            switch (cursorX)
            {
                case -1:
                    cursorX += 21;
                    break;
                case 21:
                    cursorX -= 21;
                    break;
            }
            switch (cursorY)
            {
                case -1:
                    cursorY += 21;
                    break;
                case 21:
                    cursorY -= 21;
                    break;
            }
            /*Random r = new Random();
            int random_box = r.Next(5);
            string[] box = new string[5];

            switch (random_box)
            {
                case 0:
                    box[0] = "☆";
                    break;
                case 1:
                    box[1] = "〇";
                    break;
                case 2:
                    box[2] = "□";
                    break;
                case 3:
                    box[3] = "△";
                    break;
                case 4:
                    box[4] = "・";
                    break;
            }*/

            for (y = 0; y < 21; y++)
            {
                for (x = 0; x < 21; x++)
                {
                    if (y == cursorY && x == cursorX)
                    {
                        Console.Write("＠");
                    }
                    else
                    {
                        Console.Write("・");
                    }
                }
                Console.WriteLine();

            }
            ConsoleKeyInfo kKey = Console.ReadKey(true);
            string key = kKey.Key.ToString();
            switch (key)
            {
                case "W":
                    cursorY--;
                    break;
                case "A":
                    cursorX--;
                    break;
                case "S":
                    cursorY++;
                    break;
                case "D":
                    cursorX++;
                    break;
                default:
                    Console.WriteLine("想定外のキーです");
                    break;
            }
        }
    }
}
