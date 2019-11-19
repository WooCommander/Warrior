using System;

namespace ConsoleApp3
{
    public class Warrior
    {
        string name;
        double health;
        public int damage, armor;
        public int x;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        public Warrior(string name, double health, int damage, int armor)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Armor = armor;
        }

        public void Attack()
        {
            Random rand = new Random();
            double temp;
            temp = rand.Next(1, x);
            health = health - temp;
            Console.WriteLine($"У жертвы атаки осталось = { health} хп ");
        }


        class Program
        {
            static void Main(string[] args)
            {
                Warrior Valera = new Warrior("war", 100, 5, 7);
                Warrior Egor = new Warrior("badboy", 110, 25, 5);
                Console.WriteLine("Valera nanosit udar po Egoru");
                Egor.x = Valera.damage;
                Egor.Attack();

                Valera.x = Egor.damage;
                Console.WriteLine("Valera othvativaet");
                Valera.Attack();
            }
        }
    }
}
