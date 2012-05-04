namespace RavenDBSample.RavenAccess
{
    using Raven.Client;
    using Raven.Client.Document;

    /// <summary>
    /// Static class managing the initialisation and closing of a RavenDB session.  This is 
    /// almost definitely not best practise but will do for the sample application.
    /// </summary>
    internal static class RavenSession
    {
        internal static IDocumentSession OpenSession()
        {
            var documentStore = new DocumentStore
                {
                    ConnectionStringName = "RavenDB"
                }.Initialize();

            return documentStore.OpenSession();
        }

        internal static void SaveAndCloseSession(IDocumentSession session)
        {
            session.SaveChanges();
            session.Dispose();
        }
    }
}
