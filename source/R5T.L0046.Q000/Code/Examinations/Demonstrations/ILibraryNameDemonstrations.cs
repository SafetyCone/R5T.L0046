using System;

using R5T.T0141;


namespace R5T.L0046.Q000
{
    [DemonstrationsMarker]
    public partial interface ILibraryNameDemonstrations : IDemonstrationsMarker
    {
        public void Adjust_LibraryNameForPrivacy()
        {
            /// Inputs.
            var libraryName = Instances.Values.Sample_LibraryName;
            bool isPrivate = true;


            /// Run.
            var adjustedSolutionName = Instances.LibraryNameOperations.Adjust_LibraryNameForPrivacy(
                libraryName,
                isPrivate);

            Instances.Operations.Write_Adjust_LibraryNameForPrivacy_ToConsole(
                libraryName,
                isPrivate,
                adjustedSolutionName);
        }
    }
}
