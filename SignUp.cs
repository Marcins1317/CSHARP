using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_semestr_3_Programowanie_Obiektowe
{
  static public class SignUp
  {

        public class UserID
        {
            public string name;
            public int pin;
            
        
        
        }

    static public void Your_signUp()
    {
        Console.WriteLine("Nazwa użytkowanika: \n");
        UserID user = new UserID();
        user.name = Console.ReadLine();
        Console.WriteLine("Hasło: \n");
        user.pin = int.Parse (Console.ReadLine());

            SignIn.Sign_in();

        }

  }
    static public class SignIn
    {
        public class User
        {
            public string user_name;
            public int pin;
        }

        static public void Sign_in()
        {
            Console.WriteLine("Zaloguj się podając swoje dane podane przy rejestracji:\n\n ");
            User user = new User();
            Console.WriteLine("Podaj swoją nazwę użytkownika: \n");
            user.user_name = Console.ReadLine();
            Console.WriteLine("Podaj swój pin: \n");
            user.pin = int.Parse(Console.ReadLine());

        }
    }
}
    




