namespace tamagochi
{
    public struct Food
    {
        public int heath;
        public string type;
    }
    class Cat
    {
        private string name;
        private int satiety;

        public Cat(string name = "Blank", int hunger = 0)
        {
            this.name = name;
            this.satiety = hunger;
        }
        public void Meow()
        {
            Console.WriteLine("Мяу");
        }
        public void Eat(Food food)
        {
            Console.WriteLine($"Кот съел {food.type}. {food.type} и восстановил {food.heath} здоровья.");
            satiety += food.heath;
        }

        public static void Info(Cat a)
        {
            Console.WriteLine($"{a.name}, {a.satiety}");
        }
        public void CheckHunger()
        {
            Console.WriteLine($"Здоровье: {satiety}");
        }
        public void Play()
        {
            Console.WriteLine($"{name} играет с игрушкой!");
            satiety -= 5;
            if (satiety < 0)
            {
                Console.WriteLine($"{name} Помер!");
            }
            else
            {
                Console.WriteLine($"{name} Устал");
                CheckHunger();
            }
        }

        public void Run()
        {
            Console.WriteLine($"{name} бегает за мышкой!");
            satiety -= 10;
            if (satiety < 0)
            {
                Console.WriteLine($"{name} Помер!");
            }
            else
            {
                Console.WriteLine($"{name} Устал");
                CheckHunger();
            }
        }
        public bool IsAlive()
        {
            bool flag = true;
            if (satiety < 0)
            {
                flag = false;
            }
            return flag;
        }
    }

}