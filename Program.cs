namespace RavenDBSample
{
    using System;
    using Sample;

    public class Program
    {
        public static void Main(string[] args)
        {
            BasicSampleCommands.DeleteAllReubenAlbumsFromRavenDb();
            BasicSampleCommands.AddReubenAlbumToRavenDb();
            BasicSampleCommands.GetAllReubenAlbumsFromRaven();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine(); // Pause execution
        }
    }
}
