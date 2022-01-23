﻿namespace TwoLineElements.LineParsers
{
    using System;

    /// <summary>
    ///     Parse first 1 (or 0) line contains name
    ///     char [24]
    /// </summary>
    public static class TleLine0Parser
    {
        public static string Parse(string line0)
        {
            if (string.IsNullOrEmpty(line0))
            {
                throw new ArgumentNullException(nameof(line0),@"line0 can't be empty");
            }

            if (line0.Length > 24)
            {
                throw new ArgumentOutOfRangeException(nameof(line0), @"line0 exceeds 24 chars");
            }

            return line0.Trim();
        }
    }
}