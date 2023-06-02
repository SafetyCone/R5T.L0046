using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0046.T000
{
    /// <inheritdoc cref="ILibraryNameToken"/>
    [StrongTypeImplementationMarker]
    public class LibraryNameToken : TypedBase<string>, IStrongTypeMarker,
        ILibraryNameToken
    {
        public LibraryNameToken(string value)
            : base(value)
        {
        }
    }
}