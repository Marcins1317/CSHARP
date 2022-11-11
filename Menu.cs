using System;


namespace Praca_semestr_3_Programowanie_Obiektowe
{
    static public class Menu
    {
        static public void Main_menu()
        {   
            string[] Tab_menu = { "Rejestracja \n", "Logowanie\n", "Nasza oferta \n", "Sprawdz swoją rezerwacje \n", "Anulowanie rezerwacji \n", "Wyjscie\n" };

            for (int i = 0; i < Tab_menu.Length; i++) //pętla do wypisania Menu w programie
            {
                int j = i + 1;
                Console.WriteLine(j + " - " +Tab_menu[i]);
            }

            int select;
            select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("************ Rejestracja ************");
                        // Dane osoby + czy z os. towarzyszącą + wybieranie pokokju z oferty
                        SignUp.Your_signUp();

                        break;
                    };
                case 2:
                    {
                        Console.WriteLine("************ Logowanie ************");
                        SignIn.Sign_in();
                        
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("************ Nasza oferta ************");
                        //Odczyt pliku z ofertą (Ile łóżek Cena Ile nocy ile osób)
                        Console.WriteLine("Oto nasza oferta: "); 
                        break;

                    };
                case 4:
                    {
                        Console.WriteLine("************ Sprawdz swoją rezerwacje ************");
                        //Logowanie + sprawdzenie swojej rezerwawcji z odczytem z pliku
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("************ Anulowanie rezerwacji ************");
                        //logowanie + odczyt pliku z rezerwacjami i mozliwosc usunięcia
                        break;
                    };

                case 6:
                    {
                        Console.WriteLine("************ Wyjście ************");
                        Console.Clear(); // czyszczenie ekranu
                        Console.WriteLine("======= Było nam bardzo nie zmiernie miło Cię gościć do zobaczenia =======");
                        break;
                    };

            }

        }
    }
}
