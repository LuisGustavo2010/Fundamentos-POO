using System;
using Balta.ContentContext;
using Balta.ContentContext.Enums;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("article about OOP", "orientacao-obj"));
            articles.Add(new Article("article about c#", "csharp"));
            articles.Add(new Article("article about asp.net", "dotnet"));

            var course = new List<Course>();
            var coursesOOP = new Course("Fundamentos OOP", "courseOOP");
            var coursescsharp = new Course("Fundamentos c#", "coursecsharp");
            var coursesaspnet = new Course("Fundamentos asp.net", "courseASPNET");
            course.Add(coursesOOP);
            course.Add(coursescsharp);
            course.Add(coursesaspnet);

            var carrers = new List<Carrer>();
            var CarrerDotnet = new Carrer("especialista .NET", "esp-dot-net");
            var CarrerItem = new CarrerItem(2, "Aprenda OOP", "", coursesOOP);
            var CarrerItem2 = new CarrerItem(1, "Aprenda .Net", "", coursesaspnet);
            var CarrerItem3 = new CarrerItem(3, "Aprenda C#", "", coursescsharp);

            CarrerDotnet.Items.Add(CarrerItem);
            CarrerDotnet.Items.Add(CarrerItem2);
            CarrerDotnet.Items.Add(CarrerItem3);



            carrers.Add(CarrerDotnet);

            foreach (var carrer in carrers)
            {
                Console.WriteLine(carrer.Title);
                foreach (var item in carrer.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.CreateSubscription(payPalSubscription);
            }
        }

    }

}