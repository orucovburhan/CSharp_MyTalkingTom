using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static Cat cat1 = new Cat("Lucy", 4, "Female", 300, 100,30);
        static Cat cat2 = new Cat("Bruno", 3, "Male", 450, 300, 45);
        static Cat cat3 = new Cat("Bach", 1, "Male", 600, 120, 20);
        static Cat cat4 = new Cat("Ravena", 2, "Female", 550, 200, 28);
        
            
        static Dog dog1 = new Dog("Max", 3, "Male", 400, 700, 90);
        static Dog dog2 = new Dog("Zephyr", 7, "Female", 440, 500, 70);
        static Dog dog3 = new Dog("Freya", 5, "Female", 600, 650, 120);
        static Dog dog4 = new Dog("Juno", 1, "Male", 400, 550, 60);
        private static void Main()
        {
            
            Dog[] dogs = new Dog[] { dog1, dog2, dog3, dog4 };
            Cat[] cats = new Cat[] { cat1, cat2, cat3,cat4 };
            int SearchCat( string nickname)
            {
                for (int i = 0; i < cats.Length; i++)
                {
                    if (cats[i].Nickname == nickname)
                        return i;
                }

                return -1;
            }
            int SearchDog( string nickname)
            {
                for (int i = 0; i < dogs.Length; i++)
                {
                    if (dogs[i].Nickname == nickname)
                        return i;
                }

                return -1;
            }
            void RemoveWithNicknameCat( string nickname)
            {
                int index = SearchCat( nickname);
                Cat[] newArr = new Cat[cats.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newArr[i] = cats[i];
                }

                for (int k = index; k < newArr.Length; k++)
                {
                    newArr[k] = cats[k+1];
                }
                cats = newArr;
                
            }
            void RemoveWithNicknameDog( string nickname)
            {
                int index = SearchDog(nickname);
                Dog[] newArr = new Dog[dogs.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newArr[i] = dogs[i];
                }

                for (int k = index; k < newArr.Length; k++)
                {
                    newArr[k] = dogs[k];
                }

            }
            void ShowCats()
            {
                foreach (Cat cat in cats)
                {
                    Console.WriteLine(cat);
                    Console.WriteLine("________________________");
                }
            }
            void ShowDogs()
            {
                foreach (Dog dog in dogs)
                {
                    Console.WriteLine(dog);
                    Console.WriteLine("________________________");
                }
            }

            void ShowOneCat(string name)
            {
                Console.WriteLine("________________________");
                int index = SearchCat( name);
                if (index != -1)
                    Console.WriteLine(cats[index]);
                else 
                    Console.WriteLine("No cat with the name");
                Console.WriteLine("________________________");
            }
            void ShowOneDog(string name)
            {
                Console.WriteLine("________________________");
                int index = SearchDog( name);
                if (index != -1)
                    Console.WriteLine(dogs[index]);
                else 
                    Console.WriteLine("No dog with the name");
                Console.WriteLine("________________________");
                
            }
           
            

            while (true)
            {
                string choice;
                Console.WriteLine("1.Show dogs");
                Console.WriteLine("2.Show cats");
                Console.WriteLine("3.Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Clear();
                    ShowDogs();
                    string choice1;
                        Console.WriteLine("1.Search dog");
                        Console.WriteLine("2.Back");
                        Console.WriteLine("3.Exit");
                        choice1 = Console.ReadLine();
                        if (choice1 == "1")
                        {
                            
                                Console.Clear();
                                string name;
                                Console.WriteLine("Enter dog's name: ");
                                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                                TextInfo textInfo = cultureInfo.TextInfo;
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                ShowOneDog(name);
                                string choice2;
                                while (true)
                                {
                                    Console.WriteLine($"1.Play with {dogs[SearchDog(name)].Nickname}");
                                    Console.WriteLine($"2.Feed {dogs[SearchDog(name)].Nickname}");
                                    Console.WriteLine($"3.Send {dogs[SearchDog(name)].Nickname} to sleep");
                                    Console.WriteLine("4.Show info");
                                    Console.WriteLine("5.Back to main");
                                    Console.WriteLine("6.Exit");
                                

                                choice2 = Console.ReadLine();
                                if (choice2 == "1")
                                {
                                    dogs[SearchDog(name)].Play();
                                }
                                else if (choice2 == "2")
                                {
                                    dogs[SearchDog(name)].Eat();
                                }
                                else if (choice2 == "3")
                                {
                                    dogs[SearchDog(name)].Sleep();
                                }
                                else if (choice2 == "4")
                                {
                                    Console.Clear();
                                    ShowOneDog(name);
                                }
                                else if (choice2 == "5")
                                {
                                    Main();
                                }
                                else if (choice2 == "6")
                                {
                                    break;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input!!!");
                                }
                            }

                        }
                        else if (choice1 == "2")
                        {
                            Main();
                        }
                        else if (choice1 == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!!!");
                        }
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    ShowCats();
                    string choice3;
                        Console.WriteLine("1.Search cat");
                        Console.WriteLine("2.Back");
                        Console.WriteLine("3.Exit");
                        choice3 = Console.ReadLine();
                        if (choice3 == "1")
                        {
                            
                                Console.Clear();
                                string name;
                                Console.WriteLine("Enter cat's name: ");
                                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                                TextInfo textInfo = cultureInfo.TextInfo;
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                ShowOneCat(name);
                                string choice4;
                                while (true)
                                {
                                Console.WriteLine($"1.Play with {cats[SearchCat(name)].Nickname}");
                                Console.WriteLine($"2.Feed {cats[SearchCat(name)].Nickname}");
                                Console.WriteLine($"3.Send {cats[SearchCat(name)].Nickname} to sleep");
                                Console.WriteLine("4.Show info");
                                Console.WriteLine("5.Back to main");
                                Console.WriteLine("6.Exit");
                                

                                choice4 = Console.ReadLine();
                                if (choice4 == "1")
                                {
                                    cats[SearchCat(name)].Play();
                                }
                                else if (choice4 == "2")
                                {
                                    cats[SearchCat(name)].Eat();
                                }
                                else if (choice4 == "3")
                                {
                                    cats[SearchCat(name)].Sleep();
                                }
                                else if (choice4 == "4")
                                {
                                    Console.Clear();
                                    ShowOneCat(name);
                                }
                                else if (choice4 == "5")
                                {
                                    Main();
                                }
                                else if (choice4 == "6")
                                {
                                    break;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input!!!");
                                }
                            }

                        }
                        else if (choice3 == "2")
                        {
                            Main();
                        }
                        else if (choice3 == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!!!");
                        }
                }
                else if (choice == "3")
                {
                    break;
                }
            }
            
            
            


            





        }


    }
}

    

    

    
    

        
    

