using System;


namespace R5T.L0046.S000
{
    public class LibraryNameScripts : ILibraryNameScripts
    {
        #region Infrastructure

        public static ILibraryNameScripts Instance { get; } = new LibraryNameScripts();


        private LibraryNameScripts()
        {
        }

        #endregion
    }
}
