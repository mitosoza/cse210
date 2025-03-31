using System;

class Program
{
    static void Main(string[] args)
    {
        Comment videoOneComment1 = new Comment("User1", "Great video!");
        Comment videoOneComment2 = new Comment("User2", "I learned a lot.");
        Comment videoOneComment3 = new Comment("User3", "Thanks for sharing!");
        Comment videoOneComment4 = new Comment("User4", "I love it.");
        List<Comment> videoOneComments = new List<Comment> { videoOneComment1, videoOneComment2, videoOneComment3, videoOneComment4 };
        Video videoOne = new Video("My First Video", "John Doe", 120, videoOneComments);

        Comment videoTwoComment1 = new Comment("User5", "Awesome content!");
        Comment videoTwoComment2 = new Comment("User6", "Very informative.");
        Comment videoTwoComment3 = new Comment("User7", "Can't wait for more.");
        List<Comment> videoTwoComments = new List<Comment> { videoTwoComment1, videoTwoComment2, videoTwoComment3 };
        Video videoTwo = new Video("Second Video", "Jane Smith", 150, videoTwoComments);

        Comment videoThreeComment1 = new Comment("User9", "Loved it!");
        Comment videoThreeComment2 = new Comment("User10", "So helpful.");
        Comment videoThreeComment3 = new Comment("User11", "Keep it up!");
        Comment videoThreeComment4 = new Comment("User12", "I didn't find it useful.");
        List<Comment> videoThreeComments = new List<Comment> { videoThreeComment1, videoThreeComment2, videoThreeComment3, videoThreeComment4 };
        Video videoThree = new Video("This is My Third Video", "Alice Johnson", 90, videoThreeComments);

        Comment videoFourComment1 = new Comment("User13", "Fantastic!");
        Comment videoFourComment2 = new Comment("User14", "Very well explained.");
        Comment videoFourComment3 = new Comment("User15", "I appreciate the effort.");
        List<Comment> videoFourComments = new List<Comment> { videoFourComment1, videoFourComment2, videoFourComment3 };
        Video videoFour = new Video("Final Fourth Video", "Bob Brown", 180, videoFourComments);

        List<Video> myYouTubeVideos = new List<Video> { videoOne, videoTwo, videoThree, videoFour };

        foreach (Video video in myYouTubeVideos)
        {
            Console.WriteLine(video.GetVideoDetails());
            Console.WriteLine();
        }
    }
}