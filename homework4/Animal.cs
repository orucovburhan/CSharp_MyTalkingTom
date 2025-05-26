using System.Text;

namespace MyApp;

public abstract class Animal
{
        public virtual string Nickname { get; set; }
        public virtual float Age { get; set; }
        public virtual string Gender { get; set; }
        public virtual int Energy { get; set; }
        public virtual float Price { get; set; }
        public virtual float MealQuantity { get; set; }
        public virtual float Size { get; set; }

        public Animal(){}
        public Animal(string nickname, float age, string gender, float price, float mealquantity, float size)
        {
            Nickname = nickname;
            Age = age;
            Gender = gender;
            if (age < 2)
                Energy = 50;
            else
                Energy = 100;
            Price = price;
            MealQuantity = mealquantity;
            Size = size;
        }

        public override string ToString()
        {
            return $@"Name: {Nickname} 
Age: {Age} 
Gender: {Gender} 
Energy: {Energy} 
Price: {Price} 
Meal quantity: {MealQuantity}
Size: {Size:F1}";
            
        }

        
        
        public virtual void Eat()
        {
            var stb = new StringBuilder("Animal is eating");
            for (var i = 0; i < 12; i++)
            {
                if (Age <= 2)
                {
                    if (Energy < 50 )
                    {
                        Console.Clear();
                        Console.WriteLine(stb);
                        stb.Append(".");
                        Energy++;
                        if (Age < 20)
                        {
                            Size += 0.1f;
                            Price += 1f;
                        }
                    }
                    else
                    {
                        Console.WriteLine("can not eat");
                        break;
                    }
                }
                else if (Age > 2)
                {
                    if (Energy < 100 )
                    {
                        Console.Clear();
                        Console.WriteLine(stb);
                        stb.Append(".");
                        Energy++;
                        if (Age < 20)
                        {
                            Size += 0.1f;
                            Price += 1f;
                        }
                    }
                    else
                    {
                        Console.WriteLine("can not eat");
                        break;
                    }
                }

                Thread.Sleep(500);
                if (i == 3 || i == 7)
                {
                    stb.Clear();
                    stb.Append("Animal is eating");
                }
            }
        }
        public virtual void Sleep()
        {
            var stb = new StringBuilder("Animal is sleeping");
            for (var i = 0; i < 12; i++)
            {
                if (Age <= 2)
                {
                    if (Energy < 50 )
                    {
                        Console.Clear();
                        Console.WriteLine(stb);
                        stb.Append(".");
                        Energy+=2;
                        if (Age < 20)
                        {
                            Size += 0.1f;
                            Price += 1f;
                        }
                    }
                    else
                    {
                        Console.WriteLine("can not sleep");
                        break;
                    }
                }
                else if (Age > 2)
                {
                    if (Energy < 100 )
                    {
                        Console.Clear();
                        Console.WriteLine(stb);
                        stb.Append(".");
                        Energy+=2;
                        if (Age < 20)
                        {
                            Size += 0.1f;
                            Price += 1f;
                        }
                    }
                    else
                    {
                        Console.WriteLine("can not sleep");
                        break;
                    }
                }

                Thread.Sleep(500);
                if (i == 3 || i == 7)
                {
                    stb.Clear();
                    stb.Append("Animal is sleeping");
                }
            }
        }
        public virtual void Play()
        {
            if (Energy > 12)
            {
                StringBuilder stb = new StringBuilder("Animal is playing");
                for (int i = 0; i < 12; i++)
                {
                    Console.Clear();
                    Console.WriteLine(stb);
                    stb.Append(".");
                    if (Energy > 0) Energy -= 2;
                    Thread.Sleep(500);
                    if (i == 3 || i == 7)
                    {
                        stb.Clear();
                        stb.Append("Animal is playing");
                    }
                }
            }
            else if (Energy==0)
            {
                Sleep();
            }
            else
            {
                Console.WriteLine("Energy is not enough");
            }

        }
        
        
        
        
        
}