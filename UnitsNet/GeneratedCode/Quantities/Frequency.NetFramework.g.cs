﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The number of occurrences of a repeating event per unit time.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Frequency : IComparable, IComparable<Frequency>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Frequency from nullable CyclesPerHour.
        /// </summary>
        public static Frequency? FromCyclesPerHour(QuantityValue? cyclesperhour)
        {
            return cyclesperhour.HasValue ? FromCyclesPerHour(cyclesperhour.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable CyclesPerMinute.
        /// </summary>
        public static Frequency? FromCyclesPerMinute(QuantityValue? cyclesperminute)
        {
            return cyclesperminute.HasValue ? FromCyclesPerMinute(cyclesperminute.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable Gigahertz.
        /// </summary>
        public static Frequency? FromGigahertz(QuantityValue? gigahertz)
        {
            return gigahertz.HasValue ? FromGigahertz(gigahertz.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable Hertz.
        /// </summary>
        public static Frequency? FromHertz(QuantityValue? hertz)
        {
            return hertz.HasValue ? FromHertz(hertz.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable Kilohertz.
        /// </summary>
        public static Frequency? FromKilohertz(QuantityValue? kilohertz)
        {
            return kilohertz.HasValue ? FromKilohertz(kilohertz.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable Megahertz.
        /// </summary>
        public static Frequency? FromMegahertz(QuantityValue? megahertz)
        {
            return megahertz.HasValue ? FromMegahertz(megahertz.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable RadiansPerSecond.
        /// </summary>
        public static Frequency? FromRadiansPerSecond(QuantityValue? radianspersecond)
        {
            return radianspersecond.HasValue ? FromRadiansPerSecond(radianspersecond.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Get nullable Frequency from nullable Terahertz.
        /// </summary>
        public static Frequency? FromTerahertz(QuantityValue? terahertz)
        {
            return terahertz.HasValue ? FromTerahertz(terahertz.Value) : default(Frequency?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FrequencyUnit" /> to <see cref="Frequency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Frequency unit value.</returns>
        public static Frequency? From(QuantityValue? value, FrequencyUnit fromUnit)
        {
            return value.HasValue ? new Frequency((double)value.Value, fromUnit) : default(Frequency?);
        }

        #endregion

        #region Arithmetic Operators

        public static Frequency operator -(Frequency right)
        {
            return new Frequency(-right.Value, right.Unit);
        }

        public static Frequency operator +(Frequency left, Frequency right)
        {
            return new Frequency(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Frequency operator -(Frequency left, Frequency right)
        {
            return new Frequency(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Frequency operator *(double left, Frequency right)
        {
            return new Frequency(left * right.Value, right.Unit);
        }

        public static Frequency operator *(Frequency left, double right)
        {
            return new Frequency(left.Value * right, left.Unit);
        }

        public static Frequency operator /(Frequency left, double right)
        {
            return new Frequency(left.Value / right, left.Unit);
        }

        public static double operator /(Frequency left, Frequency right)
        {
            return left.Hertz / right.Hertz;
        }

        #endregion

        public static bool operator <=(Frequency left, Frequency right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Frequency left, Frequency right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Frequency left, Frequency right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Frequency left, Frequency right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Frequency left, Frequency right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Frequency left, Frequency right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(FrequencyUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FrequencyUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(FrequencyUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
