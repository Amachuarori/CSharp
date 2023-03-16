namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Rifat Abashev");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Rifat Abashev",
                "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());

            VideoPost vid = new VideoPost("Trip to the South Korea", "Rifat Abashev",
                "https://videos.com/tripToKorea", 14, true);

            Console.WriteLine(vid.ToString());

            vid.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            vid.Stop();
        }
    }
}