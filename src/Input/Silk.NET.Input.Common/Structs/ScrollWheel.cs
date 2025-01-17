// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Text;

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents a scroll wheel.
    /// </summary>
    public struct ScrollWheel
    {
        /// <summary>
        /// The X position of the scroll wheel.
        /// </summary>
        public float X { get; }

        /// <summary>
        /// The Y position of the scroll wheel.
        /// </summary>
        public float Y { get; }

        /// <summary>
        /// Creates a new instance of the scroll wheel struct.
        /// </summary>
        /// <param name="x">The X position of the scroll wheel.</param>
        /// <param name="y">The Y position of the scroll wheel.</param>
        public ScrollWheel(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>Returns a String representing this <see cref="ScrollWheel"/> instance.</summary>
        /// <returns>The string representation.</returns>
        public override readonly string ToString() => ToString("G", CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this <see cref="ScrollWheel"/> instance, using the specified format to format individual elements.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format) => ToString(format, CultureInfo.CurrentCulture);

        /// <summary>Returns a String representing this <see cref="ScrollWheel"/> instance, using the specified format to format individual elements and the given IFormatProvider.</summary>
        /// <param name="format">The format of individual elements.</param>
        /// <param name="formatProvider">The format provider to use when formatting elements.</param>
        /// <returns>The string representation.</returns>
        public readonly string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            sb.Append('<');
            sb.Append(X.ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(Y.ToString(format, formatProvider));
            sb.Append('>');
            return sb.ToString();
        }
    }
}
