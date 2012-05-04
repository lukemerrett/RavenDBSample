namespace RavenDBSample.SampleCommands
{
    using System;
    using System.Linq;

    using Dto;

    using Raven.Client;

    using RavenAccess;

    /// <summary>
    /// Example class showing how to write a data transfer object to RavenDB
    /// </summary>
    internal static class WriteDtoToRavenDb
    {
        internal static void AddReubenAlbumToRavenDb()
        {
            var reubenAlbum = new Album
                {
                    Title = "We Should Have Gone To University",
                    Artist = "Reuben",
                    ReleaseYear = DateTime.UtcNow.AddYears(-1) /* Ish */
                };

            var session = RavenSession.OpenSession();

            if (AlbumDoesntAlreadyExist(session, reubenAlbum))
            {
                Console.WriteLine("Adding " + reubenAlbum.Title + " to RavenDB");
                session.Store(reubenAlbum);
            }
            else
            {
                Console.WriteLine("Album " + reubenAlbum.Title + " already exists in RavenDB");
            }

            RavenSession.SaveAndCloseSession(session);
        }

        internal static bool AlbumDoesntAlreadyExist(IDocumentSession session, Album reubenAlbum)
        {
            return !session.Query<Album>()
                .Any(x => x.Title == reubenAlbum.Title 
                    && x.Artist == reubenAlbum.Artist);
        }
    }
}
