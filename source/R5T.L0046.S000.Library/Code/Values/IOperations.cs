using System;

using R5T.T0131;
using R5T.T0197;


namespace R5T.L0046.S000.Library
{
    [ValuesMarker]
    public partial interface IOperations : IValuesMarker
    {
        public string Get_Adjust_LibraryNameForPrivacy_Message(
            ILibraryName libraryName,
            bool isPrivate,
            ILibraryName adjustedLibraryName)
        {
            var output = $"{adjustedLibraryName}: adjusted library name for '{libraryName}', is private: {isPrivate}.";
            return output;
        }

        public void Write_Adjust_LibraryNameForPrivacy_ToConsole(
            ILibraryName libraryName,
            bool isPrivate,
            ILibraryName adjustedLibraryName)
        {
            var message = this.Get_Adjust_LibraryNameForPrivacy_Message(
                libraryName,
                isPrivate,
                adjustedLibraryName);

            Console.WriteLine(message);
        }
    }
}
