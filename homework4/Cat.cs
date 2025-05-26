using System.Text;

namespace MyApp;

public class Cat : Animal
{
    public Cat(string nickname, int age, string gender, float price, float mealQuantity,float size)
        : base(nickname, age, gender, price, mealQuantity,size)
    {
    }
    
    public virtual void Eat()
    {
        var stb = new StringBuilder($"{Nickname} is eating");
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
                stb.Append($"{Nickname} is eating");
            }
        }
    }

    public override void Sleep()
    {
        var stb = new StringBuilder($"{Nickname} is sleeping");
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
                stb.Append($"{Nickname} is sleeping");
            }
        }
    }

    

    public override void Play()
    {
        if (Energy > 12)
        {
            StringBuilder stb = new StringBuilder($"{Nickname} is playing");
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
                    stb.Append($"{Nickname} is playing");
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