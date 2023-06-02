using System;

using R5T.T0132;

using R5T.L0043.T000;
using R5T.L0046.T000;
using R5T.L0046.T000.Extensions;

using IExternalLibraryName = R5T.T0197.ILibraryName;
using IExternalUnadjustedLibraryName = R5T.T0197.IUnadjustedLiraryName;


namespace R5T.L0046.X000
{
    [FunctionalityMarker]
    public partial interface ILibraryNameTypeConverter : IFunctionalityMarker
    {
        public IExternalLibraryName As_ExternalLibraryName(ILibraryName libraryName)
        {
            var output = Instances.StringOperator_External.ToLibraryName(
                libraryName.Value);

            return output;
        }

        public IExternalLibraryName As_ExternalLibraryName(IName name)
        {
            var output = Instances.StringOperator_External.ToLibraryName(
                name.Value);

            return output;
        }

        public ILibraryName As_InternalLibraryName(IExternalLibraryName externalLibraryName)
        {
            var output = externalLibraryName.Value.ToLibraryName();
            return output;
        }

        public ILibraryName As_InternalLibraryName(IExternalUnadjustedLibraryName externalUnadjustedLibraryName)
        {
            var output = externalUnadjustedLibraryName.Value.ToLibraryName();
            return output;
        }
    }
}
