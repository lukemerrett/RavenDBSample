namespace RavenDBSample.Dto
{
    using System;

    /// <summary>
    /// A DTO containing all the details on a specific album
    /// </summary>
    internal class Album
    {
        /// <summary>
        /// Gets or sets the title of the album.
        /// </summary>
        internal string Title { get; set; }

        /// <summary>
        /// Gets or set the artist of the album.
        /// </summary>
        internal string Artist { get; set; }

        /// <summary>
        /// Gets ors sets the year the album was released.
        /// </summary>
        internal DateTime ReleaseYear { get; set; }
    }
}
