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
    ///     In physics and engineering, in particular fluid dynamics and hydrometry, the volumetric flow rate, (also known as volume flow rate, rate of fluid flow or volume velocity) is the volume of fluid which passes through a given surface per unit time. The SI unit is m³/s (cubic meters per second). In US Customary Units and British Imperial Units, volumetric flow rate is often expressed as ft³/s (cubic feet per second). It is usually represented by the symbol Q.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct VolumeFlow : IComparable, IComparable<VolumeFlow>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CentilitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromCentilitersPerMinute(QuantityValue? centilitersperminute)
        {
            return centilitersperminute.HasValue ? FromCentilitersPerMinute(centilitersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicDecimetersPerMinute.
        /// </summary>
        public static VolumeFlow? FromCubicDecimetersPerMinute(QuantityValue? cubicdecimetersperminute)
        {
            return cubicdecimetersperminute.HasValue ? FromCubicDecimetersPerMinute(cubicdecimetersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicFeetPerHour.
        /// </summary>
        public static VolumeFlow? FromCubicFeetPerHour(QuantityValue? cubicfeetperhour)
        {
            return cubicfeetperhour.HasValue ? FromCubicFeetPerHour(cubicfeetperhour.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicFeetPerMinute.
        /// </summary>
        public static VolumeFlow? FromCubicFeetPerMinute(QuantityValue? cubicfeetperminute)
        {
            return cubicfeetperminute.HasValue ? FromCubicFeetPerMinute(cubicfeetperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicFeetPerSecond.
        /// </summary>
        public static VolumeFlow? FromCubicFeetPerSecond(QuantityValue? cubicfeetpersecond)
        {
            return cubicfeetpersecond.HasValue ? FromCubicFeetPerSecond(cubicfeetpersecond.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicMetersPerHour.
        /// </summary>
        public static VolumeFlow? FromCubicMetersPerHour(QuantityValue? cubicmetersperhour)
        {
            return cubicmetersperhour.HasValue ? FromCubicMetersPerHour(cubicmetersperhour.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicMetersPerMinute.
        /// </summary>
        public static VolumeFlow? FromCubicMetersPerMinute(QuantityValue? cubicmetersperminute)
        {
            return cubicmetersperminute.HasValue ? FromCubicMetersPerMinute(cubicmetersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicMetersPerSecond.
        /// </summary>
        public static VolumeFlow? FromCubicMetersPerSecond(QuantityValue? cubicmeterspersecond)
        {
            return cubicmeterspersecond.HasValue ? FromCubicMetersPerSecond(cubicmeterspersecond.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicYardsPerHour.
        /// </summary>
        public static VolumeFlow? FromCubicYardsPerHour(QuantityValue? cubicyardsperhour)
        {
            return cubicyardsperhour.HasValue ? FromCubicYardsPerHour(cubicyardsperhour.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicYardsPerMinute.
        /// </summary>
        public static VolumeFlow? FromCubicYardsPerMinute(QuantityValue? cubicyardsperminute)
        {
            return cubicyardsperminute.HasValue ? FromCubicYardsPerMinute(cubicyardsperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable CubicYardsPerSecond.
        /// </summary>
        public static VolumeFlow? FromCubicYardsPerSecond(QuantityValue? cubicyardspersecond)
        {
            return cubicyardspersecond.HasValue ? FromCubicYardsPerSecond(cubicyardspersecond.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable DecilitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromDecilitersPerMinute(QuantityValue? decilitersperminute)
        {
            return decilitersperminute.HasValue ? FromDecilitersPerMinute(decilitersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable KilolitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromKilolitersPerMinute(QuantityValue? kilolitersperminute)
        {
            return kilolitersperminute.HasValue ? FromKilolitersPerMinute(kilolitersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable LitersPerHour.
        /// </summary>
        public static VolumeFlow? FromLitersPerHour(QuantityValue? litersperhour)
        {
            return litersperhour.HasValue ? FromLitersPerHour(litersperhour.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable LitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromLitersPerMinute(QuantityValue? litersperminute)
        {
            return litersperminute.HasValue ? FromLitersPerMinute(litersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable LitersPerSecond.
        /// </summary>
        public static VolumeFlow? FromLitersPerSecond(QuantityValue? literspersecond)
        {
            return literspersecond.HasValue ? FromLitersPerSecond(literspersecond.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable MicrolitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromMicrolitersPerMinute(QuantityValue? microlitersperminute)
        {
            return microlitersperminute.HasValue ? FromMicrolitersPerMinute(microlitersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable MillilitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromMillilitersPerMinute(QuantityValue? millilitersperminute)
        {
            return millilitersperminute.HasValue ? FromMillilitersPerMinute(millilitersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable MillionUsGallonsPerDay.
        /// </summary>
        public static VolumeFlow? FromMillionUsGallonsPerDay(QuantityValue? millionusgallonsperday)
        {
            return millionusgallonsperday.HasValue ? FromMillionUsGallonsPerDay(millionusgallonsperday.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable NanolitersPerMinute.
        /// </summary>
        public static VolumeFlow? FromNanolitersPerMinute(QuantityValue? nanolitersperminute)
        {
            return nanolitersperminute.HasValue ? FromNanolitersPerMinute(nanolitersperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable OilBarrelsPerDay.
        /// </summary>
        public static VolumeFlow? FromOilBarrelsPerDay(QuantityValue? oilbarrelsperday)
        {
            return oilbarrelsperday.HasValue ? FromOilBarrelsPerDay(oilbarrelsperday.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable UsGallonsPerHour.
        /// </summary>
        public static VolumeFlow? FromUsGallonsPerHour(QuantityValue? usgallonsperhour)
        {
            return usgallonsperhour.HasValue ? FromUsGallonsPerHour(usgallonsperhour.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable UsGallonsPerMinute.
        /// </summary>
        public static VolumeFlow? FromUsGallonsPerMinute(QuantityValue? usgallonsperminute)
        {
            return usgallonsperminute.HasValue ? FromUsGallonsPerMinute(usgallonsperminute.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Get nullable VolumeFlow from nullable UsGallonsPerSecond.
        /// </summary>
        public static VolumeFlow? FromUsGallonsPerSecond(QuantityValue? usgallonspersecond)
        {
            return usgallonspersecond.HasValue ? FromUsGallonsPerSecond(usgallonspersecond.Value) : default(VolumeFlow?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumeFlowUnit" /> to <see cref="VolumeFlow" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>VolumeFlow unit value.</returns>
        public static VolumeFlow? From(QuantityValue? value, VolumeFlowUnit fromUnit)
        {
            return value.HasValue ? new VolumeFlow((double)value.Value, fromUnit) : default(VolumeFlow?);
        }

        #endregion

        #region Arithmetic Operators

        public static VolumeFlow operator -(VolumeFlow right)
        {
            return new VolumeFlow(-right.Value, right.Unit);
        }

        public static VolumeFlow operator +(VolumeFlow left, VolumeFlow right)
        {
            return new VolumeFlow(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static VolumeFlow operator -(VolumeFlow left, VolumeFlow right)
        {
            return new VolumeFlow(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static VolumeFlow operator *(double left, VolumeFlow right)
        {
            return new VolumeFlow(left * right.Value, right.Unit);
        }

        public static VolumeFlow operator *(VolumeFlow left, double right)
        {
            return new VolumeFlow(left.Value * right, left.Unit);
        }

        public static VolumeFlow operator /(VolumeFlow left, double right)
        {
            return new VolumeFlow(left.Value / right, left.Unit);
        }

        public static double operator /(VolumeFlow left, VolumeFlow right)
        {
            return left.CubicMetersPerSecond / right.CubicMetersPerSecond;
        }

        #endregion

        public static bool operator <=(VolumeFlow left, VolumeFlow right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(VolumeFlow left, VolumeFlow right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(VolumeFlow left, VolumeFlow right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(VolumeFlow left, VolumeFlow right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(VolumeFlow left, VolumeFlow right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(VolumeFlow left, VolumeFlow right)
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
        public string ToString(VolumeFlowUnit unit, [CanBeNull] IFormatProvider provider)
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
        public string ToString(VolumeFlowUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
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
        public string ToString(VolumeFlowUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
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
