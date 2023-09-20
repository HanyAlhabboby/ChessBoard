using System;
using System.Data.Common;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // denna kod hjälper fyrakanterna att synas, annars blir det bara frågatecken
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //här tilldelar jag en int variablen till rader och kolumner samt till input som användaren ska skriva in siffran
            int row, col, num; //
            Console.WriteLine("Skriv vilken siffra du än vill");
            string user = Console.ReadLine();
            num = int.Parse(user);

            //här skapar vi brädet, loopen inuti och hur allt ska gå till
            for (row = 1; row <= num; row++ )
            {
                for (col = 1; col <= num; col++)
                {

                    //Skriver ut summan av rader och kolumner, om den är jämn så skrivs en vit ruta, annars blir det svart ruta
                    if ((row + col) % 2 == 0) 
                    {
                        Console.Write("□");
                    }
                     else
                    {
                        Console.Write("■");
                    }
                }
                     

                Console.WriteLine(); //hjälper att byta rad 
            }
           
        }
    }
}