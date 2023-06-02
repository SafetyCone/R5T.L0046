using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0046.T000
{
    /// <inheritdoc cref="ILibraryName"/>
    [StrongTypeImplementationMarker]
    public class LibraryName : TypedBase<string>, IStrongTypeMarker,
        ILibraryName
    {
        public LibraryName(string value)
            : base(value)
        {
        }
    }
}