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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Difference between two temperatures. The conversions are different than for Temperature.
    /// </summary>
    public partial struct TemperatureDelta : IQuantity<TemperatureDeltaUnit>, IEquatable<TemperatureDelta>, IComparable, IComparable<TemperatureDelta>, IConvertible
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureDeltaUnit? _unit;

        static TemperatureDelta()
        {
            BaseDimensions = BaseDimensions.Dimensionless;

            Info = new QuantityInfo<TemperatureDeltaUnit>(QuantityType.TemperatureDelta, new UnitInfo<TemperatureDeltaUnit>[] {
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeCelsius, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeDelisle, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeFahrenheit, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeNewton, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeRankine, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeReaumur, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.DegreeRoemer, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                new UnitInfo<TemperatureDeltaUnit>(TemperatureDeltaUnit.Kelvin, new BaseUnits(LengthUnit.Undefined, MassUnit.Undefined, DurationUnit.Undefined, ElectricCurrentUnit.Undefined, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Undefined)),
                }, BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TemperatureDelta(double numericValue, TemperatureDeltaUnit unit)
        {
            if(unit == TemperatureDeltaUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        public TemperatureDelta(double numericValue, UnitSystem unitSystem)
        {
            if(unitSystem == null) throw new ArgumentNullException(nameof(unitSystem));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = GetUnitForBaseUnits(unitSystem.BaseUnits);
        }

        public TemperatureDelta(double numericValue, BaseUnits baseUnits)
        {
            if(baseUnits == null) throw new ArgumentNullException(nameof(baseUnits));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = GetUnitForBaseUnits(baseUnits);
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<TemperatureDeltaUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of TemperatureDelta, which is Kelvin. All conversions go via this value.
        /// </summary>
        public static TemperatureDeltaUnit BaseUnit { get; } = TemperatureDeltaUnit.Kelvin;

        /// <summary>
        /// Represents the largest possible value of TemperatureDelta
        /// </summary>
        public static TemperatureDelta MaxValue { get; } = new TemperatureDelta(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of TemperatureDelta
        /// </summary>
        public static TemperatureDelta MinValue { get; } = new TemperatureDelta(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.TemperatureDelta;

        /// <summary>
        ///     All units of measurement for the TemperatureDelta quantity.
        /// </summary>
        public static TemperatureDeltaUnit[] Units { get; } = Enum.GetValues(typeof(TemperatureDeltaUnit)).Cast<TemperatureDeltaUnit>().Except(new TemperatureDeltaUnit[]{ TemperatureDeltaUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Kelvin.
        /// </summary>
        public static TemperatureDelta Zero { get; } = new TemperatureDelta(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc cref="IQuantity.Unit"/>
        Enum IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public TemperatureDeltaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        public QuantityInfo<TemperatureDeltaUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => TemperatureDelta.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => TemperatureDelta.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get TemperatureDelta in DegreesCelsius.
        /// </summary>
        public double DegreesCelsius => As(TemperatureDeltaUnit.DegreeCelsius);

        /// <summary>
        ///     Get TemperatureDelta in DegreesDelisle.
        /// </summary>
        public double DegreesDelisle => As(TemperatureDeltaUnit.DegreeDelisle);

        /// <summary>
        ///     Get TemperatureDelta in DegreesFahrenheit.
        /// </summary>
        public double DegreesFahrenheit => As(TemperatureDeltaUnit.DegreeFahrenheit);

        /// <summary>
        ///     Get TemperatureDelta in DegreesNewton.
        /// </summary>
        public double DegreesNewton => As(TemperatureDeltaUnit.DegreeNewton);

        /// <summary>
        ///     Get TemperatureDelta in DegreesRankine.
        /// </summary>
        public double DegreesRankine => As(TemperatureDeltaUnit.DegreeRankine);

        /// <summary>
        ///     Get TemperatureDelta in DegreesReaumur.
        /// </summary>
        public double DegreesReaumur => As(TemperatureDeltaUnit.DegreeReaumur);

        /// <summary>
        ///     Get TemperatureDelta in DegreesRoemer.
        /// </summary>
        public double DegreesRoemer => As(TemperatureDeltaUnit.DegreeRoemer);

        /// <summary>
        ///     Get TemperatureDelta in Kelvins.
        /// </summary>
        public double Kelvins => As(TemperatureDeltaUnit.Kelvin);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(TemperatureDeltaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(TemperatureDeltaUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get TemperatureDelta from DegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesCelsius(QuantityValue degreescelsius)
        {
            double value = (double) degreescelsius;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeCelsius);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesDelisle.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesDelisle(QuantityValue degreesdelisle)
        {
            double value = (double) degreesdelisle;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeDelisle);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesFahrenheit(QuantityValue degreesfahrenheit)
        {
            double value = (double) degreesfahrenheit;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeFahrenheit);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesNewton(QuantityValue degreesnewton)
        {
            double value = (double) degreesnewton;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeNewton);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesRankine.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesRankine(QuantityValue degreesrankine)
        {
            double value = (double) degreesrankine;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeRankine);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesReaumur.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesReaumur(QuantityValue degreesreaumur)
        {
            double value = (double) degreesreaumur;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeReaumur);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesRoemer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesRoemer(QuantityValue degreesroemer)
        {
            double value = (double) degreesroemer;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeRoemer);
        }
        /// <summary>
        ///     Get TemperatureDelta from Kelvins.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromKelvins(QuantityValue kelvins)
        {
            double value = (double) kelvins;
            return new TemperatureDelta(value, TemperatureDeltaUnit.Kelvin);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureDeltaUnit" /> to <see cref="TemperatureDelta" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureDelta unit value.</returns>
        public static TemperatureDelta From(QuantityValue value, TemperatureDeltaUnit fromUnit)
        {
            return new TemperatureDelta((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static TemperatureDelta Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static TemperatureDelta Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            return QuantityParser.Default.Parse<TemperatureDelta, TemperatureDeltaUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out TemperatureDelta result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out TemperatureDelta result)
        {
            return QuantityParser.Default.TryParse<TemperatureDelta, TemperatureDeltaUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static TemperatureDeltaUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static TemperatureDeltaUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            return UnitParser.Default.Parse<TemperatureDeltaUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out TemperatureDeltaUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider provider, out TemperatureDeltaUnit unit)
        {
            return UnitParser.Default.TryParse<TemperatureDeltaUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        public static TemperatureDelta operator -(TemperatureDelta right)
        {
            return new TemperatureDelta(-right.Value, right.Unit);
        }

        public static TemperatureDelta operator +(TemperatureDelta left, TemperatureDelta right)
        {
            return new TemperatureDelta(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static TemperatureDelta operator -(TemperatureDelta left, TemperatureDelta right)
        {
            return new TemperatureDelta(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static TemperatureDelta operator *(double left, TemperatureDelta right)
        {
            return new TemperatureDelta(left * right.Value, right.Unit);
        }

        public static TemperatureDelta operator *(TemperatureDelta left, double right)
        {
            return new TemperatureDelta(left.Value * right, left.Unit);
        }

        public static TemperatureDelta operator /(TemperatureDelta left, double right)
        {
            return new TemperatureDelta(left.Value / right, left.Unit);
        }

        public static double operator /(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Kelvins / right.Kelvins;
        }

        #endregion

        #region Equality / IComparable

        public static bool operator <=(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        public static bool operator ==(TemperatureDelta left, TemperatureDelta right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TemperatureDelta left, TemperatureDelta right)
        {
            return !(left == right);
        }

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is TemperatureDelta objTemperatureDelta)) throw new ArgumentException("Expected type TemperatureDelta.", nameof(obj));

            return CompareTo(objTemperatureDelta);
        }

        public int CompareTo(TemperatureDelta other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is TemperatureDelta objTemperatureDelta))
                return false;

            return Equals(objTemperatureDelta);
        }

        public bool Equals(TemperatureDelta other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another TemperatureDelta within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(TemperatureDelta other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current TemperatureDelta.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(Enum unit) => As((TemperatureDeltaUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TemperatureDeltaUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        public double As(Enum unit) => As((TemperatureDeltaUnit) unit);

        /// <summary>
        ///     Converts this TemperatureDelta to another TemperatureDelta with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A TemperatureDelta with the specified unit.</returns>
        public TemperatureDelta ToUnit(TemperatureDeltaUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new TemperatureDelta(convertedValue, unit);
        }

        IQuantity<TemperatureDeltaUnit> IQuantity<TemperatureDeltaUnit>.ToUnit(TemperatureDeltaUnit unit) => ToUnit(unit);

        public IQuantity ToUnit(Enum unit) => ToUnit((TemperatureDeltaUnit) unit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case TemperatureDeltaUnit.DegreeCelsius: return _value;
                case TemperatureDeltaUnit.DegreeDelisle: return _value*-2/3;
                case TemperatureDeltaUnit.DegreeFahrenheit: return _value*5/9;
                case TemperatureDeltaUnit.DegreeNewton: return _value*100/33;
                case TemperatureDeltaUnit.DegreeRankine: return _value*5/9;
                case TemperatureDeltaUnit.DegreeReaumur: return _value*5/4;
                case TemperatureDeltaUnit.DegreeRoemer: return _value*40/21;
                case TemperatureDeltaUnit.Kelvin: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(TemperatureDeltaUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case TemperatureDeltaUnit.DegreeCelsius: return baseUnitValue;
                case TemperatureDeltaUnit.DegreeDelisle: return baseUnitValue*-3/2;
                case TemperatureDeltaUnit.DegreeFahrenheit: return baseUnitValue*9/5;
                case TemperatureDeltaUnit.DegreeNewton: return baseUnitValue*33/100;
                case TemperatureDeltaUnit.DegreeRankine: return baseUnitValue*9/5;
                case TemperatureDeltaUnit.DegreeReaumur: return baseUnitValue*4/5;
                case TemperatureDeltaUnit.DegreeRoemer: return baseUnitValue*21/40;
                case TemperatureDeltaUnit.Kelvin: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        public static TemperatureDeltaUnit GetUnitForBaseUnits(BaseUnits baseUnits)
        {
            var unit = Info.UnitInfos.Where((unitInfo) => unitInfo.BaseUnits.EqualsIgnoreUndefined(baseUnits)).FirstOrDefault();
            if(unit == null)
                throw new NotImplementedException($"No LengthUnit was found for the given BaseUnits.");

            return unit.Value;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider)
        {
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(TemperatureDelta)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(TemperatureDelta)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(TemperatureDelta)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ToString(provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(TemperatureDelta))
                return this;
            else if(conversionType == typeof(TemperatureDeltaUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return TemperatureDelta.QuantityType;
            else if(conversionType == typeof(BaseDimensions))
                return TemperatureDelta.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(TemperatureDelta)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}
