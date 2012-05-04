namespace RavenDBSample
{
    using System;
    using Sample;

    public class Program
    {
        public static void Main(string[] args)
        {
            SampleCommands.DeleteAllReubenAlbumsFromRavenDb();
            SampleCommands.AddReubenAlbumToRavenDb();
            SampleCommands.GetAllReubenAlbumsFromRaven();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine(); // Pause execution
        }
    }
}
