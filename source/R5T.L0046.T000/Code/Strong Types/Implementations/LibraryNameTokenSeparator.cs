using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0046.T000
{
    /// <inheritdoc cref="ILibraryNameTokenSeparator"/>
    [StrongTypeImplementationMarker]
    public class LibraryNameTokenSeparator : TypedBase<string>, IStrongTypeMarker,
        ILibraryNameTokenSeparator
    {
        public LibraryNameTokenSeparator(string value)
            : base(value)
        {
        }
    }
}