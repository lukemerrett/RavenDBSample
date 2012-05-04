namespace RavenDBSample
{
    using System;
    using Sample;

    public class Program
    {
        public static void Main(string[] args)
        {
            SampleCommands.AddReubenAlbumToRavenDb();
            SampleCommands.GetAllReubenAlbumsFromRaven();
            Console.ReadLine(); // Pause execution
        }
    }
}
