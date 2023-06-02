using System;


namespace R5T.L0046.T000.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToLibraryName(string)"/>
        public static ILibraryName ToLibraryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToLibraryName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLibraryNamePart(string)"/>
        public static ILibraryNamePart ToLibraryNamePart(this string value)
        {
            return Instances.StringOperator_Extensions.ToLibraryNamePart(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLibraryNameToken(string)"/>
        public static ILibraryNameToken ToLibraryNameToken(this string value)
        {
            return Instances.StringOperator_Extensions.ToLibraryNameToken(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLibraryNameTokenSeparator(string)"/>
        public static ILibraryNameTokenSeparator ToLibraryNameTokenSeparator(this string value)
        {
            return Instances.StringOperator_Extensions.ToLibraryNameTokenSeparator(value);
        }

        /// <inheritdoc cref="IStringOperator.ToUnadjustedLibraryName(string)"/>
        public static IUnadjustedLibraryName ToUnadjustedLibraryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToUnadjustedLibraryName(value);
        }
    }
}
