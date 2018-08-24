using Playground2.Structural.Decorator.Library;
using System;

namespace Playground2.Structural.Decorator
{
    public static class DecoratorMain
    {
        public static void Run()
        {
            IRobot robot = new Robot();
            robot.Introduce("Hello");

            IRobot dancingRobot = new DancingRobot(robot);
            dancingRobot.Introduce("He yo");

            IRobot dancingAndShooting = new DancingAndShootingRobot(dancingRobot);
            dancingAndShooting.Introduce("Hey");

            Console.WriteLine(new String('-', 50));

            //2

            // Create book
            var book = new Book("Microsoft", "CLR via C# 4", 10);
            book.Display();
            Console.WriteLine(new string('-', 60));

            // Create video
            var video = new Video("Stanley Kubrick", "A Clockwork Orange", 23, 92);
            video.Display();
            Console.WriteLine(new string('-', 60));

            // Make book borroable, then borrow and display
            Console.WriteLine("Making book borrowable:");
            var borrowableBook = new Borrowable(book);
            borrowableBook.BorrowItem("Nikolay Kostov");
            borrowableBook.BorrowItem("Ivaylo Kenov");
            borrowableBook.Display();
            Console.WriteLine(new string('-', 60));

            // Make video borrowable, then borrow and display
            Console.WriteLine("Making video borrowable:");
            var borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Nikolay Kostov");
            borrowableVideo.BorrowItem("Ivaylo Kenov");
            borrowableVideo.Display();
            Console.WriteLine(new string('-', 60));

            // Make only video buyable
            Console.WriteLine("Making video buyable:");
            var buyableAndBorrowableVideo = new Buyable(borrowableVideo, 15);
            buyableAndBorrowableVideo.Display();
            Console.WriteLine(new string('-', 60));
        }
    }
}
