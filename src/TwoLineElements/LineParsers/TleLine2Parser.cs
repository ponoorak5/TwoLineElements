namespace TwoLineElements.LineParsers
{
    using System;
    using Extensions;
    using Models;

    public static class TleLine2Parser
    {
        /// <summary>
        ///     Parse second line of TLE
        /// </summary>
        /// <param name="line2"></param>
        /// <returns>
        ///     <see cref="Line2Model" />
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Line2Model Parse(string line2)
        {
            if (string.IsNullOrEmpty(line2))
            {
                throw new ArgumentNullException(nameof(line2), @"line1 can't be empty");
            }

            if (line2.Length > 69)
            {
                throw new ArgumentOutOfRangeException(nameof(line2), @"line0 exceeds 69 chars");
            }

            var checkSum = Convert.ToInt32(line2.Substring(68, 1));
            Utils.Checksum(line2, checkSum);

            var result = new Line2Model
            {
                Line = Utils.ParseIntValue(line2.Columns(1, 1).Trim()),
                Number = Utils.ParseDoubleValue(line2.Columns(3, 7).Trim()),
                Inclination = Utils.ParseDoubleValue(line2.Columns(9, 16).Trim()),
                Ascension = Utils.ParseDoubleValue(line2.Columns(18, 25).Trim()),
                Eccentricity = Utils.ParseDoubleValue(line2.Columns(27, 33).Trim()),
                Perigee = Utils.ParseDoubleValue(line2.Columns(35, 42).Trim()),
                Anomaly = Utils.ParseDoubleValue(line2.Columns(44, 51).Trim()),
                Motion = Utils.ParseDoubleValue(line2.Columns(53, 63).Trim()),
                Revolution = Utils.ParseDoubleValue(line2.Columns(64, 68).Trim())
            };

            return result;
        }
    }
}