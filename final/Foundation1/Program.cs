class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        Video v1 = new Video("I Found The Button Behind My Fridge!", "NeverSweat49", 239);
        v1.AddComment("I always love watching your videos. There just so creative.", "SuperFace41");
        v1.AddComment("What an amazing piece of work! I would've never guessed the button was behind the fridge.", "TheDumbo69");
        v1.AddComment("WOOOOOW...So cool. I never knew a fake button, placed prior to filming the video, would be in a non-reasonable place.", "TheHater124");
        videos.Add(v1);

        Video v2 = new Video("I Made 500 Million By Watching Over A Nuclear Facility!", "Mr. Mader", 1023);
        v2.AddComment("I WAS THE FIRST TO COMMENT!!!", "SpeadTexter41");
        v2.AddComment("Was anyone wondering about where that guy came from, or is it just me.", "TheQuestioneirFirst");
        v2.AddComment("Was the set made for a movie before the video? I just seems like I've seen it somewhere.", "Future Movie Watcher");
        videos.Add(v2);

        Video v3 = new Video("The Only Known Element That Existed Once.", "The Karsentech Company", 1400);
        v3.AddComment("I am a scientist and thought all the evidence was great to explaining why the element may or may not be real.", "Fake Scientist");
        v3.AddComment("Learning about an element that was created only once was really educational.", "Nerd41376523");
        v3.AddComment("The Periodic Table is calling for a revision.", "Periodic Person");
        videos.Add(v3);


        foreach (Video video in videos)
        { 
            Console.WriteLine($"{video._title}, {video._creator}, {video._length}, {video.GetTotalComments()}");
            Console.WriteLine();
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment.DisplayComment());
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}