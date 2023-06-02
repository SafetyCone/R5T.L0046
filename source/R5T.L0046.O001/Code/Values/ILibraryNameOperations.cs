using System;

using R5T.T0131;
using R5T.T0197.Extensions;

using R5T.L0046.X000;

using IExternalLibraryName = R5T.T0197.ILibraryName;
using IExternalUnadjustedLibraryName = R5T.T0197.IUnadjustedLiraryName;


namespace R5T.L0046.O001
{
    [ValuesMarker]
    public partial interface ILibraryNameOperations : IValuesMarker
    {
        public IExternalLibraryName Adjust_LibraryNameForPrivacy(
            IExternalUnadjustedLibraryName unadjustedLibraryName,
            bool isPrivate)
        {
            var externalLibraryName = unadjustedLibraryName.Value.ToLibraryName();

            var output = this.Adjust_LibraryNameForPrivacy(
                externalLibraryName,
                isPrivate);

            return output;
        }

        public IExternalLibraryName Adjust_LibraryNameForPrivacy(
            IExternalLibraryName libraryName,
            bool isPrivate)
        {
            var internalLibraryName = libraryName.As_InternalLibraryName();

            var adjustedLibraryName = Instances.NameOperations.Adjust_ForPrivacy(
                internalLibraryName,
                isPrivate)
                .As_ExternalLibraryName();

            return adjustedLibraryName;
        }
    }
}
