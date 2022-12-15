using System;

namespace DasPro06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Adventure Game.");
            Console.WriteLine("What is Your Name?");
            Novice Player = new Novice(); 
            Player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+Player.Name+", Ready to begin the Game? [Yes/No]");
            string bReady = Console.ReadLine();
            
            if(bReady == "Yes"){
                Console.WriteLine(Player.Name+" is Entering The Word... ");
                Enemy enemy1 = new Enemy("Adudu");
                Console.WriteLine(Player.Name+ " is Encountring " +enemy1.Name);
                Console.WriteLine(enemy1.Name+" Attacking You...");
                Console.WriteLine("Choose your Action:");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defent");
                Console.WriteLine("4. Run Away");

                while (!Player.IsDead && !enemy1.IsDead && !Player.IsRunningAway)
                {
                    string PLayerAction = Console.ReadLine();
                    switch(PLayerAction)
                    {
                        case "1" :
                        Console.WriteLine(Player.Name+" is doing Single Attack...");
                        enemy1.GetHit(Player.AttackPower);
                        Player.experience += 0.4f;
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.Write("PLayer Health : "+Player.Health+" | Enemy Health : "+enemy1.Health+"\n");
                        Console.WriteLine();
                        break;
                        case "2" :
                        Player.Double();
                        Player.experience += 0.8f;
                        enemy1.GetHit(Player.AttackPower);
                        Console.Write("Player Health : "+Player.Health+" | Enemy Health : "+enemy1.Health+"\n");
                        Console.WriteLine();
                        break;
                        case "3" :
                        Player.Rest();
                        Console.WriteLine("Energy is being Restored....");
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        break;
                        case "4" :
                        Console.WriteLine(Player.Name+" Is Running Away....");
                        Player.RunningAway();
                        break;
                    }
                }
                Console.WriteLine(Player.Name+ " Get "+Player.experience+" Experience Point.");
                Console.WriteLine();

            }else{
                Console.WriteLine("GoodBye....");
                Console.Read();
            }
        }
    }
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float experience { get; set; }
        public bool IsRunningAway { get; set; }
        Random rng = new Random();

        public Novice(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 2;
            IsDead = false;
            experience = 0f;
            Name = "";

        }
        public void Double(){
            if(SkillSlot > 0){
                Console.WriteLine("SWINGG!!!");
                AttackPower = AttackPower + rng.Next(4,13);
                SkillSlot--;
            }else{
                Console.WriteLine("You are do not Energy!!");

            }

        }
        public void GetHit(int HitValue){
            Console.WriteLine(Name+ " Get Hit by " +HitValue);
            Health = Health - HitValue;

            if(Health <= 0 ){
                Health = 0;
                Die();
            }

        }
        public void Rest(){
            SkillSlot = 4;
            AttackPower = 2;

        }
        public void Die(){
            Console.WriteLine("You are Dead, Game Over!!!1");
            IsDead = true;

        }
        public void RunningAway(){
            IsRunningAway = true;
        }
    }
    class Enemy{
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rng = new Random();
       
 
        public Enemy(string name){
         Health = 50;
         Name = name;
        }
        public void Attack(int damage){
         AttackPower = rng.Next(1,10);

        }
        public void GetHit(int HitValue){
         Console.WriteLine(Name+" Get Hit by "+HitValue);
         Health = Health - HitValue;

         if(Health <= 0){
            Health = 0;
            Die();
            }

        }

        public void Die(){
         Console.WriteLine(Name+" is Dead...");
         IsDead = true;

        }
 
    }
}