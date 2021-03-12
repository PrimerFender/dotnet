using System;

namespace whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHp = 10;
            int monsterHp = 10;
            Random attack = new Random();
            int hit = 0;

            // Hero attack
            // Console.WriteLine($"Hero hits Monster with {hit} HP; Monster has {monsterHp} remaining!")
            do
            {
                // Hero attacks first
                hit = attack.Next(1, 11);
                monsterHp -= hit;
                Console.WriteLine($"> Hero hits Monster with {hit} HP; Monster has {monsterHp} remaining!");

                // If monster is still alive, monster attacks back
                if (monsterHp <= 0) continue;
                hit = attack.Next(1, 11);
                heroHp -= hit;
                Console.WriteLine($"< Monster hits Hero with {hit} HP; Hero has {heroHp} remaining!");
            } while (monsterHp > 0 && heroHp > 0);

            Console.WriteLine(heroHp > monsterHp ? "Hero wins!" : "Monster wins!");
        }
    }
}
