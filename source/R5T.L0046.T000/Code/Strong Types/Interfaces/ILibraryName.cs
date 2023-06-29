using System;

using R5T.T0178;


namespace R5T.L0046.T000
{
    /// <summary>
    /// Strongly-types a string as a library name.
    /// <purpose>This is a library name for the purposes of working with name tokens.</purpose>
    /// </summary>
    [StrongTypeMarker]
    public interface ILibraryName : IStrongTypeMarker,
        L0043.T000.IName
    {
    }
}