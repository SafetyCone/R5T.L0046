using System;

using R5T.T0132;


namespace R5T.L0046.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ILibraryName"/>
        public ILibraryName ToLibraryName(string value)
        {
            var output = new LibraryName(value);
            return output;
        }

        /// <inheritdoc cref="ILibraryNamePart"/>
        public ILibraryNamePart ToLibraryNamePart(string value)
        {
            var output = new LibraryNamePart(value);
            return output;
        }

        /// <inheritdoc cref="ILibraryNameToken"/>
        public ILibraryNameToken ToLibraryNameToken(string value)
        {
            var output = new LibraryNameToken(value);
            return output;
        }

        /// <inheritdoc cref="ILibraryNameTokenSeparator"/>
        public ILibraryNameTokenSeparator ToLibraryNameTokenSeparator(string value)
        {
            var output = new LibraryNameTokenSeparator(value);
            return output;
        }

        /// <inheritdoc cref="IUnadjustedLibraryName"/>
        public IUnadjustedLibraryName ToUnadjustedLibraryName(string value)
        {
            var output = new UnadjustedLibraryName(value);
            return output;
        }
    }
}
