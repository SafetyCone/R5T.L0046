using System;

using R5T.T0178;


namespace R5T.L0046.T000
{
    /// <summary>
    /// Strongly-types a string as a library name token separator.
    /// </summary>
    [StrongTypeMarker]
    public interface ILibraryNameTokenSeparator : IStrongTypeMarker,
        L0043.T000.INameTokenSeparator
    {
    }
}