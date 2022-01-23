namespace TwoLineElements.Exceptions
{
    using System;

    public class ChecksumException : Exception
    {
        public ChecksumException(int expected, int actual)
        {
            Expected = expected;
            Actual = actual;
        }

        public int Expected { get; }
        public int Actual { get; }
    }
}