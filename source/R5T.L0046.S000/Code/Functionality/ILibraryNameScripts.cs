using System;

using R5T.T0132;


namespace R5T.L0046.S000
{
    [FunctionalityMarker]
    public partial interface ILibraryNameScripts : IFunctionalityMarker
    {
        public void Adjust_LibraryNameForPrivacy()
        {
            /// Inputs.
            var libraryName = Instances.Values.Sample_LibraryName;
            var isPrivate =
                //false
                true
                ;


            /// Run.
            var adjustedLibraryName = Instances.LibraryNameOperations.Adjust_LibraryNameForPrivacy(
                libraryName,
                isPrivate);

            Instances.Operations.Write_Adjust_LibraryNameForPrivacy_ToConsole(
                libraryName,
                isPrivate,
                adjustedLibraryName);
        }
    }
}
