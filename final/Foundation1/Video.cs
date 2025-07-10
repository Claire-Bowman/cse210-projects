using System;

public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthSeconds { get; set; }
        public List<Comment> Comments { get; private set; }

        public Video(string title, string author, int lengthSeconds)
        {
            Title = title;
            Author = author;
            LengthSeconds = lengthSeconds;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return Comments.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"  - {comment.Display()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }