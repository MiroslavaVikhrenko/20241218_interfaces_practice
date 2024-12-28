using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace _20241228_task16
{
    internal class Program
    {
        /*
         «Телефон» - «Сервер». Основным устройством в этой связи является телефон. 
        В задании он может быть двух типов: «Смартфон» и «Сотовый»(обычный). 
        У них есть общая функция - отправить сообщение (send) и получить сообщение (get). 

        «Человек» - это пользователь телефона. Телефон получает сообщение от человека и 
        передаёт его другому телефону с помощью сервера - на нем хранится список номеров. 

        Для отправки сообщения человеку необходимо выбрать номер телефона получателя. 
        Для получения необходимо проверить сервер на наличие сообщений. Учтите различия 
        телефонов и их взаимодействие посредством человека. 

        Цель - реализовать программу, отображающую процесс диалога двух людей по телефону.
         */
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Name = "John",
                Phone = new Smartphone(14536)
            };
            Person p2 = new Person()
            {
                Name = "Julia",
                Phone = new Smartphone(56789)
            };
            Person p3 = new Person()
            {
                Name = "Adam",
                Phone = new Smartphone(32648)
            };
            Person p4 = new Person()
            {
                Name = "Maria",
                Phone = new Smartphone(12098)
            };

            List<Person> phonebook = new List<Person>()
            {
                p1, p2, p3, p4
            };

            Server server = new Server();

            while (true)
            {
                DisplayMenu(phonebook, server);
            }

            Console.ReadKey();
        }

        static void DisplayMenu(List<Person> phonebook, Server server)
        {
            Console.Clear();
            Console.WriteLine("Choose a user:");
            foreach (Person person in phonebook)
            {
                Console.WriteLine(person.Name);
            }

            try
            {
                string user = Console.ReadLine();

                bool flag = false;
                foreach (Person person in phonebook)
                {
                    if (person.Name == user)
                    {
                        Person activeUser = phonebook.Find(x => x.Name == user);
                        flag = true;
                        Console.WriteLine($"------------------\nHi, {user}! Please choose: \n1. Send message\n2. Check new messages\n3. Exit\n------------------");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                activeUser.SendMessage(server, phonebook);
                                Console.ReadKey();
                                break;
                            case 2:
                                activeUser.CheckMessages(server);
                                Console.ReadKey();
                                break;
                            case 3:
                                Environment.Exit(0);
                                break;
                            default:
                                DisplayMenu(phonebook, server);
                                Console.ReadKey();
                                break;
                        }
                    }
                }

                if (!flag)
                {
                    throw new Exception("Incorrect Input");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
