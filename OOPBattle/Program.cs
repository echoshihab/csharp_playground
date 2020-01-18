using System;

namespace OOPBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter drogo = new Fighter("Drogo", 800, 100, 50);
            Fighter drake = new Fighter("Drake", 700, 90, 40);

            Battle.StartFight(drogo, drake);
        }
    }
}
