using System;

using R5T.T0178;


namespace R5T.L0046.T000
{
    /// <summary>
    /// Strongly-types a string as a library name token.
    /// </summary>
    [StrongTypeMarker]
    public interface ILibraryNameToken : IStrongTypeMarker,
        L0043.T000.INameToken
    {
    }
}