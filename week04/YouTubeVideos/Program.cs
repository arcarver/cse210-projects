using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video();

        video1._trackTitle = "The Fruitcake Song";
        video1._trackAuthor = "5 Chinese Brothers";
        video1._trackLength = 155;
        Comment comment1 = new Comment();
        comment1._commentText = "Such a funny Christmas Song!";
        comment1._nameOfPersonCommenting = "Anonymous";
        video1._commentList.Add(comment1);

        Comment comment2 = new Comment();
        comment2._commentText = "You want to hear this song";
        comment2._nameOfPersonCommenting = "George Lucas";
        video1._commentList.Add(comment2);

        Comment comment3 = new Comment();
        comment3._commentText = "You will love this video";
        comment3._nameOfPersonCommenting = "Sandra Lane";
        video1._commentList.Add(comment3);

        Video video2 = new Video();

        video2._trackTitle = "All I want for Christmas";
        video2._trackAuthor = "Everly Brothers";
        video2._trackLength = 235;
        Comment comment4 = new Comment();
        comment4._commentText = "I didn't know they sang this song!";
        comment4._nameOfPersonCommenting = "Faye Running";
        video2._commentList.Add(comment4);

        Comment comment5 = new Comment();
        comment5._commentText = "That is what I want to!";
        comment5._nameOfPersonCommenting = "Milo Homes";
        video2._commentList.Add(comment5);

        Comment comment6 = new Comment();
        comment6._commentText = "Make sure you watch at 45 seconds in. So funny";
        comment6._nameOfPersonCommenting = "Hermes Kinder";
        video2._commentList.Add(comment6);

        Video video3 = new Video();

        video3._trackTitle = "How much is the doggy in the window.";
        video3._trackAuthor = "Elvis and the Moo Tones";
        video3._trackLength = 312;
        Comment comment7 = new Comment();
        comment7._commentText = "The harmonies where out of this world!";
        comment7._nameOfPersonCommenting = "Mr. Jones";
        video3._commentList.Add(comment7);

        Comment comment8 = new Comment();
        comment8._commentText = "This is my favorite video";
        comment8._nameOfPersonCommenting = "Leia Hudson";
        video3._commentList.Add(comment8);

        Comment comment9 = new Comment();
        comment9._commentText = "I wish I could dance like them!";
        comment9._nameOfPersonCommenting = "Rocky Bulwinkle";
        video3._commentList.Add(comment9);

        Video video4 = new Video();

        video4._trackTitle = "I'll be home for New Years";
        video4._trackAuthor = "Shawna Sinclare";
        video4._trackLength = 284;
        Comment comment10 = new Comment();
        comment10._commentText = "This video brought tears to my eyes.";
        comment10._nameOfPersonCommenting = "Mary Shore";
        video4._commentList.Add(comment10);

        Comment comment11 = new Comment();
        comment11._commentText = "I watch this everyyear!";
        comment11._nameOfPersonCommenting = "H Solo";
        video4._commentList.Add(comment11);

        Comment comment12 = new Comment();
        comment12._commentText = "Grandma's favorite!";
        comment12._nameOfPersonCommenting = "Peter Pannet";
        video4._commentList.Add(comment12);

        List<Video> videos = new List<Video>([video1, video2, video3, video4]);
        foreach (Video video in videos)
        {
            Console.WriteLine(video._trackTitle);
            Console.WriteLine(video._trackAuthor);
            Console.WriteLine(video._trackLength);
            Console.WriteLine(video.NumberOfComments());
        }
    }
}