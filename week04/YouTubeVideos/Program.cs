using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video();
        video1._author = "Train to Code";
        video1._title = "Every single feature of C# in 10 minutes";
        video1._length = 589;
        Comment comment1Video1 = new Comment();
        comment1Video1._author = "MsFm2000";
        comment1Video1._text = "The best ten minutes of education I've had in a while.";
        video1.AddComment(comment1Video1);
        Comment comment2Video1 = new Comment();
        comment2Video1._author = "WayneGreen-g8l";
        comment2Video1._text = "I've been programming in C# since 2006, and this video had a few things I had forgotten. Thanks.";
        video1.AddComment(comment2Video1);
        Comment comment3Video1 = new Comment();
        comment3Video1._author = "Banaaani";
        comment3Video1._text = "I have used C# for roughly 5 years now, and I still learned something new!";
        video1.AddComment(comment3Video1);
        videos.Add(video1);
        

        Video video2 = new Video();
        video2._author = "Luke Barousse";
        video2._title = "Python for Data Analytics - Full Course for Beginners";
        video2._length = 40140;
        Comment comment1Video2 = new Comment();
        comment1Video2._author = "ballinspalding11";
        comment1Video2._text = "God bless you Luke, making this available for free really says a lot about the man you are.";
        video2.AddComment(comment1Video2);
        Comment comment2Video2 = new Comment();
        comment2Video2._author = "humichael7228";
        comment2Video2._text = "I almost finished the course! And I almost finished my first python project along with the course. This is hands down the best tutorial on python out there!";
        video2.AddComment(comment2Video2);
        Comment comment3Video2 = new Comment();
        comment3Video2._author = "nhimallansupramaniam2626";
        comment3Video2._text = "My god, the pivot table function is a game changer. Thank you Luke, im 81% done with the course";
        video2.AddComment(comment3Video2);
        videos.Add(video2);

        Video video3 = new Video();
        video3._author = "IAmTimCorey";
        video3._title = "How Do I Become a Back-End Developer in C#";
        video3._length = 1077;
        Comment comment1Video3 = new Comment();
        comment1Video3._author = "andergarcia1115";
        comment1Video3._text = "blessings Master, wonderful as always.";
        video3.AddComment(comment1Video3);
        Comment comment2Video3 = new Comment();
        comment2Video3._author = "hectoreduardosolanopestana6964";
        comment2Video3._text = "Great video from great teacher";
        video3.AddComment(comment2Video3);
        Comment comment3Video3 = new Comment();
        comment3Video3._author = "Mobilemaniaplays";
        comment3Video3._text = "Can you make a video on how to write backend in c++";
        video3.AddComment(comment3Video3);
        videos.Add(video3);

        Video video4 = new Video();
        video4._author = "Rob Mulla";
        video4._title = "Learning Pandas for Data Analysis? Start Here.";
        video4._length = 1369;
        Comment comment1Video4 = new Comment();
        comment1Video4._author = "LCP7070";
        comment1Video4._text = "This is a game changer to refresh your knowledge before an technical interview";
        video4.AddComment(comment1Video4);
        Comment comment2Video4 = new Comment();
        comment2Video4._author = "syedhaider0916";
        comment2Video4._text = "Not enough half way through and I can tell this video is gold.";
        video4.AddComment(comment2Video4);
        Comment comment3Video4 = new Comment();
        comment3Video4._author = "whatisagoodusernamehere";
        comment3Video4._text = "we are waiting for the next part! I personally wanna see sth on visualization!";
        video4.AddComment(comment3Video4);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
    }
}