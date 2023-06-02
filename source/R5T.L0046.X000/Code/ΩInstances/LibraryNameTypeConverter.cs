using System;


namespace R5T.L0046.X000
{
    public class LibraryNameTypeConverter : ILibraryNameTypeConverter
    {
        #region Infrastructure

        public static ILibraryNameTypeConverter Instance { get; } = new LibraryNameTypeConverter();


        private LibraryNameTypeConverter()
        {
        }

        #endregion
    }
}
