using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0046.T000
{
    /// <inheritdoc cref="IUnadjustedLibraryName"/>
    [StrongTypeImplementationMarker]
    public class UnadjustedLibraryName : TypedBase<string>, IStrongTypeMarker,
        IUnadjustedLibraryName
    {
        public UnadjustedLibraryName(string value)
            : base(value)
        {
        }
    }
}