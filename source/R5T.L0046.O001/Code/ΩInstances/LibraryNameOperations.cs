using System;


namespace R5T.L0046.O001
{
    public class LibraryNameOperations : ILibraryNameOperations
    {
        #region Infrastructure

        public static ILibraryNameOperations Instance { get; } = new LibraryNameOperations();


        private LibraryNameOperations()
        {
        }

        #endregion
    }
}
