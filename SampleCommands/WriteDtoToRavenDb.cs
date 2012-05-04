namespace RavenDBSample.SampleCommands
{
    using System;
    using RavenAccess;

    /// <summary>
    /// Example class showing how to write a data transfer object to RavenDB
    /// </summary>
    internal static class WriteDtoToRavenDb
    {
        internal static void AddReubenAlbumToRavenDb()
        {
            var reubenAlbum = new Dto.Album
                {
                    Title = "We Should Have Gone To University",
                    Artist = "Reuben",
                    ReleaseYear = DateTime.UtcNow.AddYears(-1) /* Ish */
                };

            var session = RavenSession.OpenSession();

            session.Store(reubenAlbum);

            RavenSession.SaveAndCloseSession(session);
        }
    }
}
