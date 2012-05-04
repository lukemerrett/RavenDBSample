namespace RavenDBSample.SampleCommands
{
    using System;
    using System.Linq;
    using Dto;

    using RavenAccess;

    /// <summary>
    /// Example class showing how to read a dto from RavenDB
    /// </summary>
    internal static class ReadDtoFromRavenDb
    {
        internal static void GetReubenAlbumFromRaven()
        {
            var session = RavenSession.OpenSession();

            var allAlbums = session.Query<Album>();

            var reubenAlbums = allAlbums.Where(x => x.Artist == "Reuben");

            foreach (var album in reubenAlbums)
            {
                Console.WriteLine(album.Title);
            }

            RavenSession.SaveAndCloseSession(session);
        }
    }
}
