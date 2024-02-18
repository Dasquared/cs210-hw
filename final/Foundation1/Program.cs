using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        Console.WriteLine();
        // Video 1
        Video video1 = new Video("Life as a penguin", "John Marlow", 36);
        
        List<Comment> commentsVideo1 = new List<Comment>();
        Comment comment1Video1 = new Comment("Mike Smith", "This was so good!");
        Comment comment2Video1 = new Comment("Susan", "They are so cute. I love them!");
        Comment comment3Video1 = new Comment("Adam Dean", "Is not easy to be a penguin sometimes.");

        commentsVideo1.Add(comment1Video1);
        commentsVideo1.Add(comment2Video1);
        commentsVideo1.Add(comment3Video1);
        video1.SetComments(commentsVideo1);
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Economy 500 years ago", "Adam Dean", 336);
        
        List<Comment> commentsVideo2 = new List<Comment>();
        Comment comment1Video2 = new Comment("Lara Mikeson", "It's crazy to see all the canges through history.");
        Comment comment2Video2 = new Comment("Joshua Marcht", "I like how is econmy now than 500 years ago.");
        Comment comment3Video2 = new Comment("Johnny Belayro", "This video is a masterpiece!");

        commentsVideo2.Add(comment1Video2);
        commentsVideo2.Add(comment2Video2);
        commentsVideo2.Add(comment3Video2);
        video2.SetComments(commentsVideo2);
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Programming with AI", "Luke Mark", 250);
        
        List<Comment> commentsVideo3 = new List<Comment>();
        Comment comment1Video3 = new Comment("Georgi Bennet", "This is the future!");
        Comment comment2Video3 = new Comment("Derek Hutson", "Is scary to see all things AI can do!");
        Comment comment3Video3 = new Comment("Joshua Frerichs", "Waiting for a new video, this was amazing.");

        commentsVideo3.Add(comment1Video3);
        commentsVideo3.Add(comment2Video3);
        commentsVideo3.Add(comment3Video3);
        video3.SetComments(commentsVideo3);
        videos.Add(video3);
        

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();    
        }
    }
}