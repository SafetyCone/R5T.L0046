using System;


namespace R5T.L0046.Q000
{
    public static class Instances
    {
        public static S000.Library.IOperations Operations => S000.Library.Operations.Instance;
        public static O001.ILibraryNameOperations LibraryNameOperations => O001.LibraryNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}