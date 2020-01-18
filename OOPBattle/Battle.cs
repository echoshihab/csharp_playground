using System;

namespace OOPBattle
{
    class Battle
    {
        public static void StartFight(Fighter Fighter1, Fighter Fighter2)
        {
            while (true)
                {
                if(GetAttackResult(Fighter1, Fighter2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(Fighter2, Fighter1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }


        }

        public static string GetAttackResult(Fighter Fighter1, Fighter Fighter2)
        {
            double fight1Attk = Fighter1.Attack();
            double fight2Blk = Fighter2.Block();

            double dmg2fight2 = fight1Attk - fight2Blk;

            if (dmg2fight2 > 0)
            {
                Fighter2.Health = Fighter2.Health - dmg2fight2;
            }
            else dmg2fight2 = 0;

            Console.WriteLine("{0} attacks {1} and deals {2} Damage", Fighter1.Name, Fighter2.Name, dmg2fight2);
            Console.Write("{0} has {1} Health \n", Fighter2.Name, Fighter2.Health);

            if (Fighter2.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious \n", Fighter2.Name, Fighter1.Name);
                return "Game Over";
            }
            else return "Fight Again";

        }
    }
}
