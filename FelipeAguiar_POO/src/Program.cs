using FelipeAguiar_POO.src.Entities;
using src.Entities;
using static System.Console;

namespace FelipeAguiar_POO.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Felipe", 10, "Assassino");
            Wizard wizard = new Wizard("Thais", 10, "Tanque");

            WriteLine(arus.Attack());
            WriteLine(wizard.Attack());
        }
    }
}
