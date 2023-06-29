using System;

using R5T.T0178;


namespace R5T.L0046.T000
{
    /// <summary>
    /// Strongly-types a string as an unadjusted library name.
    /// <inheritdoc cref="ILibraryName" path="/summary/purpose"/>
    /// </summary>
    [StrongTypeMarker]
    public interface IUnadjustedLibraryName : IStrongTypeMarker,
        L0043.T000.IUnadjustedName
    {
    }
}