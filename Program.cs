namespace RavenDBSample
{
    using System;

    using SampleCommands;

    public class Program
    {
        public static void Main(string[] args)
        {
            WriteDtoToRavenDb.AddReubenAlbumToRavenDb();
            ReadDtoFromRavenDb.GetReubenAlbumFromRaven();
            Console.ReadLine(); // Pause execution
        }
    }
}
