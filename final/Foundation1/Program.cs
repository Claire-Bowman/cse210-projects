using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to Cook Pasta", "Chef Luigi", 300);
            video1.AddComment(new Comment("Alice", "This was super helpful!"));
            video1.AddComment(new Comment("Bob", "I love this recipe."));
            video1.AddComment(new Comment("Carlos", "Can you make a vegetarian version?"));

            var video2 = new Video("Python OOP Tutorial", "CodeMaster", 900);
            video2.AddComment(new Comment("Daisy", "Great explanation of classes!"));
            video2.AddComment(new Comment("Evan", "Could you add examples of inheritance?"));
            video2.AddComment(new Comment("Fay", "This is the best tutorial I’ve found."));

            var video3 = new Video("Travel Vlog: Japan", "WanderWithMe", 600);
            video3.AddComment(new Comment("George", "So beautiful! I want to go now."));
            video3.AddComment(new Comment("Hannah", "Thanks for the tips on Tokyo!"));
            video3.AddComment(new Comment("Ivy", "Please do one for South Korea next!"));

            var video4 = new Video("DIY Home Office Setup", "TechNook", 750);
            video4.AddComment(new Comment("Jack", "Clean and simple, I like it."));
            video4.AddComment(new Comment("Kara", "Where did you get the desk from?"));
            video4.AddComment(new Comment("Liam", "Can you do a budget version?"));

            var videos = new List<Video> { video1, video2, video3, video4 };

            foreach (var video in videos)
            {
                video.DisplayInfo();
            }
    }
}