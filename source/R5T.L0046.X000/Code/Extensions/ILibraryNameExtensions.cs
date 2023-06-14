using System;

using R5T.L0043.T000;
using R5T.L0046.T000;

using IExternalLibraryName = R5T.T0197.ILibraryName;
using IExternalUnadjustedLibraryName = R5T.T0197.IUnadjustedLibraryName;


namespace R5T.L0046.X000
{
    public static class ILibraryNameExtensions
    {
        public static IExternalLibraryName As_ExternalLibraryName(this ILibraryName libraryName)
        {
            return Instances.LibraryNameTypeConverter.As_ExternalLibraryName(libraryName);
        }

        public static IExternalLibraryName As_ExternalLibraryName(this IName name)
        {
            return Instances.LibraryNameTypeConverter.As_ExternalLibraryName(name);
        }

        public static ILibraryName As_InternalLibraryName(this IExternalLibraryName externalLibraryName)
        {
            return Instances.LibraryNameTypeConverter.As_InternalLibraryName(externalLibraryName);
        }

        public static ILibraryName As_InternalLibraryName(this IExternalUnadjustedLibraryName externalUnadjustedLibraryName)
        {
            return Instances.LibraryNameTypeConverter.As_InternalLibraryName(externalUnadjustedLibraryName);
        }
    }
}
