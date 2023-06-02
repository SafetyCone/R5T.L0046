using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0046.T000
{
    /// <inheritdoc cref="ILibraryNamePart"/>
    [StrongTypeImplementationMarker]
    public class LibraryNamePart : TypedBase<string>, IStrongTypeMarker,
        ILibraryNamePart
    {
        public LibraryNamePart(string value)
            : base(value)
        {
        }
    }
}