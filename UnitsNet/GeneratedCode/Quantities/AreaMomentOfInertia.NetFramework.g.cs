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
    ///     A geometric property of an area that reflects how its points are distributed with regard to an axis.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct AreaMomentOfInertia : IComparable, IComparable<AreaMomentOfInertia>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable AreaMomentOfInertia from nullable CentimetersToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia? FromCentimetersToTheFourth(QuantityValue? centimeterstothefourth)
        {
            return centimeterstothefourth.HasValue ? FromCentimetersToTheFourth(centimeterstothefourth.Value) : default(AreaMomentOfInertia?);
        }

        /// <summary>
        ///     Get nullable AreaMomentOfInertia from nullable DecimetersToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia? FromDecimetersToTheFourth(QuantityValue? decimeterstothefourth)
        {
            return decimeterstothefourth.HasValue ? FromDecimetersToTheFourth(decimeterstothefourth.Value) : default(AreaMomentOfInertia?);
        }

        /// <summary>
        ///     Get nullable AreaMomentOfInertia from nullable FeetToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia? FromFeetToTheFourth(QuantityValue? feettothefourth)
        {
            return feettothefourth.HasValue ? FromFeetToTheFourth(feettothefourth.Value) : default(AreaMomentOfInertia?);
        }

        /// <summary>
        ///     Get nullable AreaMomentOfInertia from nullable InchesToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia? FromInchesToTheFourth(QuantityValue? inchestothefourth)
        {
            return inchestothefourth.HasValue ? FromInchesToTheFourth(inchestothefourth.Value) : default(AreaMomentOfInertia?);
        }

        /// <summary>
        ///     Get nullable AreaMomentOfInertia from nullable MetersToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia? FromMetersToTheFourth(QuantityValue? meterstothefourth)
        {
            return meterstothefourth.HasValue ? FromMetersToTheFourth(meterstothefourth.Value) : default(AreaMomentOfInertia?);
        }

        /// <summary>
        ///     Get nullable AreaMomentOfInertia from nullable MillimetersToTheFourth.
        /// </summary>
        public static AreaMomentOfInertia? FromMillimetersToTheFourth(QuantityValue? millimeterstothefourth)
        {
            return millimeterstothefourth.HasValue ? FromMillimetersToTheFourth(millimeterstothefourth.Value) : default(AreaMomentOfInertia?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AreaMomentOfInertiaUnit" /> to <see cref="AreaMomentOfInertia" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AreaMomentOfInertia unit value.</returns>
        public static AreaMomentOfInertia? From(QuantityValue? value, AreaMomentOfInertiaUnit fromUnit)
        {
            return value.HasValue ? new AreaMomentOfInertia((double)value.Value, fromUnit) : default(AreaMomentOfInertia?);
        }

        #endregion

        #region Arithmetic Operators

        public static AreaMomentOfInertia operator -(AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(-right.Value, right.Unit);
        }

        public static AreaMomentOfInertia operator +(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static AreaMomentOfInertia operator -(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static AreaMomentOfInertia operator *(double left, AreaMomentOfInertia right)
        {
            return new AreaMomentOfInertia(left * right.Value, right.Unit);
        }

        public static AreaMomentOfInertia operator *(AreaMomentOfInertia left, double right)
        {
            return new AreaMomentOfInertia(left.Value * right, left.Unit);
        }

        public static AreaMomentOfInertia operator /(AreaMomentOfInertia left, double right)
        {
            return new AreaMomentOfInertia(left.Value / right, left.Unit);
        }

        public static double operator /(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.MetersToTheFourth / right.MetersToTheFourth;
        }

        #endregion

        public static bool operator <=(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(AreaMomentOfInertia left, AreaMomentOfInertia right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(AreaMomentOfInertia left, AreaMomentOfInertia right)
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
        public string ToString(AreaMomentOfInertiaUnit unit, [CanBeNull] IFormatProvider provider)
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
        public string ToString(AreaMomentOfInertiaUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
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
        public string ToString(AreaMomentOfInertiaUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
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
