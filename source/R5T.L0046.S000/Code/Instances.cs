using System;


namespace R5T.L0046.S000
{
    public static class Instances
    {
        public static Library.IOperations Operations => Library.Operations.Instance;
        public static O001.ILibraryNameOperations LibraryNameOperations => O001.LibraryNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}