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

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

#nullable enable

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     A unit for expressing the integral of apparent power over time, equal to the product of 1 volt-ampere and 1 hour, or to 3600 joules.
    /// </summary>
    public partial struct ApparentEnergy<T> : IQuantityT<ApparentEnergyUnit, T>, IEquatable<ApparentEnergy<T>>, IComparable, IComparable<ApparentEnergy<T>>, IConvertible, IFormattable
    {
        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ApparentEnergyUnit? _unit;

        static ApparentEnergy()
        {
            BaseDimensions = new BaseDimensions(2, 1, -2, 0, 0, 0, 0);

            Info = new QuantityInfo<ApparentEnergyUnit>("ApparentEnergy",
                new UnitInfo<ApparentEnergyUnit>[] {
                    new UnitInfo<ApparentEnergyUnit>(ApparentEnergyUnit.KilovoltampereHour, BaseUnits.Undefined),
                    new UnitInfo<ApparentEnergyUnit>(ApparentEnergyUnit.MegavoltampereHour, BaseUnits.Undefined),
                    new UnitInfo<ApparentEnergyUnit>(ApparentEnergyUnit.VoltampereHour, BaseUnits.Undefined),
                },
                BaseUnit, Zero, BaseDimensions, QuantityType.ApparentEnergy);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ApparentEnergy(T value, ApparentEnergyUnit unit)
        {
            if(unit == ApparentEnergyUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            Value = value;
            _unit = unit;
        }

        /// <summary>
        /// Creates an instance of the quantity with the given numeric value in units compatible with the given <see cref="UnitSystem"/>.
        /// If multiple compatible units were found, the first match is used.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unitSystem">The unit system to create the quantity with.</param>
        /// <exception cref="ArgumentNullException">The given <see cref="UnitSystem"/> is null.</exception>
        /// <exception cref="ArgumentException">No unit was found for the given <see cref="UnitSystem"/>.</exception>
        public ApparentEnergy(T value, UnitSystem unitSystem)
        {
            if(unitSystem is null) throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);
            var firstUnitInfo = unitInfos.FirstOrDefault();

            Value = value;
            _unit = firstUnitInfo?.Value ?? throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<ApparentEnergyUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of <see cref="ApparentEnergy{T}" />, which is VoltampereHour. All conversions go via this value.
        /// </summary>
        public static ApparentEnergyUnit BaseUnit { get; } = ApparentEnergyUnit.VoltampereHour;

        /// <summary>
        /// Represents the largest possible value of <see cref="ApparentEnergy{T}" />
        /// </summary>
        public static ApparentEnergy<T> MaxValue { get; } = new ApparentEnergy<T>(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of <see cref="ApparentEnergy{T}" />
        /// </summary>
        public static ApparentEnergy<T> MinValue { get; } = new ApparentEnergy<T>(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use Info property instead.")]
        public static QuantityType QuantityType { get; } = QuantityType.ApparentEnergy;

        /// <summary>
        ///     All units of measurement for the <see cref="ApparentEnergy{T}" /> quantity.
        /// </summary>
        public static ApparentEnergyUnit[] Units { get; } = Enum.GetValues(typeof(ApparentEnergyUnit)).Cast<ApparentEnergyUnit>().Except(new ApparentEnergyUnit[]{ ApparentEnergyUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit VoltampereHour.
        /// </summary>
        public static ApparentEnergy<T> Zero { get; } = new ApparentEnergy<T>((T)0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public T Value{ get; }

        double IQuantity.Value => Convert.ToDouble(Value);

        #region Conversion Properties

        /// <summary>
        ///     Get <see cref="ApparentEnergy{T}" /> in KilovoltampereHours.
        /// </summary>
        public T KilovoltampereHours => As(ApparentEnergyUnit.KilovoltampereHour);

        /// <summary>
        ///     Get <see cref="ApparentEnergy{T}" /> in MegavoltampereHours.
        /// </summary>
        public T MegavoltampereHours => As(ApparentEnergyUnit.MegavoltampereHour);

        /// <summary>
        ///     Get <see cref="ApparentEnergy{T}" /> in VoltampereHours.
        /// </summary>
        public T VoltampereHours => As(ApparentEnergyUnit.VoltampereHour);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ApparentEnergyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static string GetAbbreviation(ApparentEnergyUnit unit, IFormatProvider? provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get <see cref="ApparentEnergy{T}" /> from KilovoltampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentEnergy<T> FromKilovoltampereHours(T kilovoltamperehours)
        {
            return new ApparentEnergy<T>(kilovoltamperehours, ApparentEnergyUnit.KilovoltampereHour);
        }
        /// <summary>
        ///     Get <see cref="ApparentEnergy{T}" /> from MegavoltampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentEnergy<T> FromMegavoltampereHours(T megavoltamperehours)
        {
            return new ApparentEnergy<T>(megavoltamperehours, ApparentEnergyUnit.MegavoltampereHour);
        }
        /// <summary>
        ///     Get <see cref="ApparentEnergy{T}" /> from VoltampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ApparentEnergy<T> FromVoltampereHours(T voltamperehours)
        {
            return new ApparentEnergy<T>(voltamperehours, ApparentEnergyUnit.VoltampereHour);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentEnergyUnit" /> to <see cref="ApparentEnergy{T}" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns><see cref="ApparentEnergy{T}" /> unit value.</returns>
        public static ApparentEnergy<T> From(T value, ApparentEnergyUnit fromUnit)
        {
            return new ApparentEnergy<T>(value, fromUnit);
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
        public static ApparentEnergy<T> Parse(string str)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static ApparentEnergy<T> Parse(string str, IFormatProvider? provider)
        {
            return QuantityParser.Default.Parse<ApparentEnergy<T>, ApparentEnergyUnit>(
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
        public static bool TryParse(string? str, out ApparentEnergy<T> result)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static bool TryParse(string? str, IFormatProvider? provider, out ApparentEnergy<T> result)
        {
            return QuantityParser.Default.TryParse<ApparentEnergy<T>, ApparentEnergyUnit>(
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
        public static ApparentEnergyUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ApparentEnergyUnit ParseUnit(string str, IFormatProvider? provider)
        {
            return UnitParser.Default.Parse<ApparentEnergyUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.ApparentEnergyUnit)"/>
        public static bool TryParseUnit(string str, out ApparentEnergyUnit unit)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider? provider, out ApparentEnergyUnit unit)
        {
            return UnitParser.Default.TryParse<ApparentEnergyUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static ApparentEnergy<T> operator -(ApparentEnergy<T> right)
        {
            return new ApparentEnergy<T>(CompiledLambdas.Negate(right.Value), right.Unit);
        }

        /// <summary>Get <see cref="ApparentEnergy{T}"/> from adding two <see cref="ApparentEnergy{T}"/>.</summary>
        public static ApparentEnergy<T> operator +(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            var value = CompiledLambdas.Add(left.Value, right.GetValueAs(left.Unit));
            return new ApparentEnergy<T>(value, left.Unit);
        }

        /// <summary>Get <see cref="ApparentEnergy{T}"/> from subtracting two <see cref="ApparentEnergy{T}"/>.</summary>
        public static ApparentEnergy<T> operator -(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            var value = CompiledLambdas.Subtract(left.Value, right.GetValueAs(left.Unit));
            return new ApparentEnergy<T>(value, left.Unit);
        }

        /// <summary>Get <see cref="ApparentEnergy{T}"/> from multiplying value and <see cref="ApparentEnergy{T}"/>.</summary>
        public static ApparentEnergy<T> operator *(T left, ApparentEnergy<T> right)
        {
            var value = CompiledLambdas.Multiply(left, right.Value);
            return new ApparentEnergy<T>(value, right.Unit);
        }

        /// <summary>Get <see cref="ApparentEnergy{T}"/> from multiplying value and <see cref="ApparentEnergy{T}"/>.</summary>
        public static ApparentEnergy<T> operator *(ApparentEnergy<T> left, T right)
        {
            var value = CompiledLambdas.Multiply(left.Value, right);
            return new ApparentEnergy<T>(value, left.Unit);
        }

        /// <summary>Get <see cref="ApparentEnergy{T}"/> from dividing <see cref="ApparentEnergy{T}"/> by value.</summary>
        public static ApparentEnergy<T> operator /(ApparentEnergy<T> left, T right)
        {
            var value = CompiledLambdas.Divide(left.Value, right);
            return new ApparentEnergy<T>(value, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="ApparentEnergy{T}"/> by <see cref="ApparentEnergy{T}"/>.</summary>
        public static T operator /(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return CompiledLambdas.Divide(left.VoltampereHours, right.VoltampereHours);
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return CompiledLambdas.LessThanOrEqual(left.Value, right.GetValueAs(left.Unit));
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return CompiledLambdas.GreaterThanOrEqual(left.Value, right.GetValueAs(left.Unit));
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return CompiledLambdas.LessThan(left.Value, right.GetValueAs(left.Unit));
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return CompiledLambdas.GreaterThan(left.Value, right.GetValueAs(left.Unit));
        }

        /// <summary>Returns true if exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(ApparentEnergy{T}, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator ==(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns true if not exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(ApparentEnergy{T}, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator !=(ApparentEnergy<T> left, ApparentEnergy<T> right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is ApparentEnergy<T> objApparentEnergy)) throw new ArgumentException("Expected type ApparentEnergy.", nameof(obj));

            return CompareTo(objApparentEnergy);
        }

        /// <inheritdoc />
        public int CompareTo(ApparentEnergy<T> other)
        {
            return System.Collections.Generic.Comparer<T>.Default.Compare(Value, other.GetValueAs(this.Unit));
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(ApparentEnergy{T}, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is ApparentEnergy<T> objApparentEnergy))
                return false;

            return Equals(objApparentEnergy);
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(ApparentEnergy{T}, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public bool Equals(ApparentEnergy<T> other)
        {
            return Value.Equals(other.GetValueAs(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another <see cref="ApparentEnergy{T}" /> within the given absolute or relative tolerance.
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
        public bool Equals(ApparentEnergy<T> other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            var otherValueInThisUnits = other.As(this.Unit);
            return UnitsNet.Comparison.Equals(Value, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current <see cref="ApparentEnergy{T}" />.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public T As(ApparentEnergyUnit unit)
        {
            if(Unit == unit)
                return Value;

            var converted = GetValueAs(unit);
            return converted;
        }

        /// <inheritdoc cref="IQuantity.As(UnitSystem)"/>
        public T As(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return As(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        double IQuantity.As(Enum unit)
        {
            if(!(unit is ApparentEnergyUnit unitAsApparentEnergyUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(ApparentEnergyUnit)} is supported.", nameof(unit));

            var asValue = As(unitAsApparentEnergyUnit);
            return Convert.ToDouble(asValue);
        }

        double IQuantity.As(UnitSystem unitSystem) => Convert.ToDouble(As(unitSystem));

        double IQuantity<ApparentEnergyUnit>.As(ApparentEnergyUnit unit) => Convert.ToDouble(As(unit));

        /// <summary>
        ///     Converts this <see cref="ApparentEnergy{T}" /> to another <see cref="ApparentEnergy{T}" /> with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A <see cref="ApparentEnergy{T}" /> with the specified unit.</returns>
        public ApparentEnergy<T> ToUnit(ApparentEnergyUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ApparentEnergy<T>(convertedValue, unit);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(Enum unit)
        {
            if(!(unit is ApparentEnergyUnit unitAsApparentEnergyUnit))
                throw new ArgumentException($"The given unit is of type {unit.GetType()}. Only {typeof(ApparentEnergyUnit)} is supported.", nameof(unit));

            return ToUnit(unitAsApparentEnergyUnit);
        }

        /// <inheritdoc cref="IQuantity.ToUnit(UnitSystem)"/>
        public ApparentEnergy<T> ToUnit(UnitSystem unitSystem)
        {
            if(unitSystem is null)
                throw new ArgumentNullException(nameof(unitSystem));

            var unitInfos = Info.GetUnitInfosFor(unitSystem.BaseUnits);

            var firstUnitInfo = unitInfos.FirstOrDefault();
            if(firstUnitInfo == null)
                throw new ArgumentException("No units were found for the given UnitSystem.", nameof(unitSystem));

            return ToUnit(firstUnitInfo.Value);
        }

        /// <inheritdoc />
        IQuantity IQuantity.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantity<ApparentEnergyUnit> IQuantity<ApparentEnergyUnit>.ToUnit(ApparentEnergyUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantityT<ApparentEnergyUnit, T> IQuantityT<ApparentEnergyUnit, T>.ToUnit(ApparentEnergyUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        IQuantity<ApparentEnergyUnit> IQuantity<ApparentEnergyUnit>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <inheritdoc />
        IQuantityT<ApparentEnergyUnit, T> IQuantityT<ApparentEnergyUnit, T>.ToUnit(UnitSystem unitSystem) => ToUnit(unitSystem);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private T GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case ApparentEnergyUnit.KilovoltampereHour: return (Value) * 1e3d;
                case ApparentEnergyUnit.MegavoltampereHour: return (Value) * 1e6d;
                case ApparentEnergyUnit.VoltampereHour: return Value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        internal ApparentEnergy<T> ToBaseUnit()
        {
            var baseUnitValue = GetValueInBaseUnit();
            return new ApparentEnergy<T>(baseUnitValue, BaseUnit);
        }

        private T GetValueAs(ApparentEnergyUnit unit)
        {
            if(Unit == unit)
                return Value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ApparentEnergyUnit.KilovoltampereHour: return (baseUnitValue) / 1e3d;
                case ApparentEnergyUnit.MegavoltampereHour: return (baseUnitValue) / 1e6d;
                case ApparentEnergyUnit.VoltampereHour: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Gets the default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString("g");
        }

        /// <summary>
        ///     Gets the default string representation of value and unit using the given format provider.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString(IFormatProvider? provider)
        {
            return ToString("g", provider);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        [Obsolete(@"This method is deprecated and will be removed at a future release. Please use ToString(""s2"") or ToString(""s2"", provider) where 2 is an example of the number passed to significantDigitsAfterRadix.")]
        public string ToString(IFormatProvider? provider, int significantDigitsAfterRadix)
        {
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        [Obsolete("This method is deprecated and will be removed at a future release. Please use string.Format().")]
        public string ToString(IFormatProvider? provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? CultureInfo.CurrentUICulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.CurrentUICulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentUICulture);
        }

        /// <inheritdoc cref="QuantityFormatter.Format{TUnitType}(IQuantity{TUnitType}, string, IFormatProvider)"/>
        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider? provider)
        {
            return QuantityFormatter.Format<ApparentEnergyUnit>(this, format, provider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(ApparentEnergy<T>)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(Value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(ApparentEnergy<T>)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(ApparentEnergy<T>)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(Value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(Value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(Value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(Value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(Value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(Value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(Value);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ToString("g", provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(ApparentEnergy<T>))
                return this;
            else if(conversionType == typeof(ApparentEnergyUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return ApparentEnergy<T>.QuantityType;
            else if(conversionType == typeof(QuantityInfo))
                return ApparentEnergy<T>.Info;
            else if(conversionType == typeof(BaseDimensions))
                return ApparentEnergy<T>.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(ApparentEnergy<T>)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(Value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(Value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(Value);
        }

        #endregion
    }
}
