using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            USER user = new USER("Ikrom", "********");
            PasswordAuthenticator authenticator = new PasswordAuthenticator();
            Console.WriteLine("Логин завершен: " + authenticator.Authenticate(user, "********"));
            IShape circle = new Circle(radius:5);
            Rectangle rectangle = new Rectangle(width:4, length:6);
            Console.WriteLine("Зона круга: " + circle.CalculateArea());
            Console.WriteLine("Зона четыреугольника: " + rectangle.CalculateArea());
        }
    }
        }
    