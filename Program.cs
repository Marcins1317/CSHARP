using Praca_semestr_3_Programowanie_Obiektowe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_semestr_3_Programowanie_Obiektowe
{
    public class Program
    {

        public static void Main(string[] args)
        { //Główne Menu programu


            {
                string hello = ("====== Witaj w Hotelu OOP jesteś zalogowany jako gość. ======  \n");
                Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
                Console.WriteLine(hello);





                Menu.Main_menu();



                Console.ReadKey();
            }


        }

    }
}

    



   