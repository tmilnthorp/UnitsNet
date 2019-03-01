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
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Molar concentration, also called molarity, amount concentration or substance concentration, is a measure of the concentration of a solute in a solution, or of any chemical species, in terms of amount of substance in a given volume. 
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Molar_concentration
    /// </remarks>
    public partial struct Molarity : IQuantity<MolarityUnit>, IEquatable<Molarity>, IComparable<Molarity>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarityUnit? _unit;

        static Molarity()
        {
            BaseDimensions = new BaseDimensions(-3, 0, 0, 0, 0, 1, 0);
            Info = new QuantityInfo<MolarityUnit>(QuantityType.Molarity, Units, BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Molarity(double numericValue, MolarityUnit unit)
        {
            if(unit == MolarityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<MolarityUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Molarity, which is MolesPerCubicMeter. All conversions go via this value.
        /// </summary>
        public static MolarityUnit BaseUnit { get; } = MolarityUnit.MolesPerCubicMeter;

        /// <summary>
        /// Represents the largest possible value of Molarity
        /// </summary>
        public static Molarity MaxValue { get; } = new Molarity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Molarity
        /// </summary>
        public static Molarity MinValue { get; } = new Molarity(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.Molarity;

        /// <summary>
        ///     All units of measurement for the Molarity quantity.
        /// </summary>
        public static MolarityUnit[] Units { get; } = Enum.GetValues(typeof(MolarityUnit)).Cast<MolarityUnit>().Except(new MolarityUnit[]{ MolarityUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit MolesPerCubicMeter.
        /// </summary>
        public static Molarity Zero { get; } = new Molarity(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public MolarityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<MolarityUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Molarity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Molarity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get Molarity in CentimolesPerLiter.
        /// </summary>
        public double CentimolesPerLiter => As(MolarityUnit.CentimolesPerLiter);

        /// <summary>
        ///     Get Molarity in DecimolesPerLiter.
        /// </summary>
        public double DecimolesPerLiter => As(MolarityUnit.DecimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MicromolesPerLiter.
        /// </summary>
        public double MicromolesPerLiter => As(MolarityUnit.MicromolesPerLiter);

        /// <summary>
        ///     Get Molarity in MillimolesPerLiter.
        /// </summary>
        public double MillimolesPerLiter => As(MolarityUnit.MillimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MolesPerCubicMeter.
        /// </summary>
        public double MolesPerCubicMeter => As(MolarityUnit.MolesPerCubicMeter);

        /// <summary>
        ///     Get Molarity in MolesPerLiter.
        /// </summary>
        public double MolesPerLiter => As(MolarityUnit.MolesPerLiter);

        /// <summary>
        ///     Get Molarity in NanomolesPerLiter.
        /// </summary>
        public double NanomolesPerLiter => As(MolarityUnit.NanomolesPerLiter);

        /// <summary>
        ///     Get Molarity in PicomolesPerLiter.
        /// </summary>
        public double PicomolesPerLiter => As(MolarityUnit.PicomolesPerLiter);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(MolarityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static string GetAbbreviation(MolarityUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Molarity from CentimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromCentimolesPerLiter(QuantityValue centimolesperliter)
        {
            double value = (double) centimolesperliter;
            return new Molarity(value, MolarityUnit.CentimolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from DecimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromDecimolesPerLiter(QuantityValue decimolesperliter)
        {
            double value = (double) decimolesperliter;
            return new Molarity(value, MolarityUnit.DecimolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from MicromolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMicromolesPerLiter(QuantityValue micromolesperliter)
        {
            double value = (double) micromolesperliter;
            return new Molarity(value, MolarityUnit.MicromolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from MillimolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMillimolesPerLiter(QuantityValue millimolesperliter)
        {
            double value = (double) millimolesperliter;
            return new Molarity(value, MolarityUnit.MillimolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from MolesPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMolesPerCubicMeter(QuantityValue molespercubicmeter)
        {
            double value = (double) molespercubicmeter;
            return new Molarity(value, MolarityUnit.MolesPerCubicMeter);
        }
        /// <summary>
        ///     Get Molarity from MolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromMolesPerLiter(QuantityValue molesperliter)
        {
            double value = (double) molesperliter;
            return new Molarity(value, MolarityUnit.MolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from NanomolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromNanomolesPerLiter(QuantityValue nanomolesperliter)
        {
            double value = (double) nanomolesperliter;
            return new Molarity(value, MolarityUnit.NanomolesPerLiter);
        }
        /// <summary>
        ///     Get Molarity from PicomolesPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Molarity FromPicomolesPerLiter(QuantityValue picomolesperliter)
        {
            double value = (double) picomolesperliter;
            return new Molarity(value, MolarityUnit.PicomolesPerLiter);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
        public static Molarity From(QuantityValue value, MolarityUnit fromUnit)
        {
            return new Molarity((double)value, fromUnit);
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
        public static Molarity Parse(string str)
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
        public static Molarity Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            return QuantityParser.Default.Parse<Molarity, MolarityUnit>(
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
        public static bool TryParse([CanBeNull] string str, out Molarity result)
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
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Molarity result)
        {
            return QuantityParser.Default.TryParse<Molarity, MolarityUnit>(
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
        public static MolarityUnit ParseUnit(string str)
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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public static MolarityUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            return UnitParser.Default.Parse<MolarityUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.MolarityUnit)"/>
        public static bool TryParseUnit(string str, out MolarityUnit unit)
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
        public static bool TryParseUnit(string str, IFormatProvider provider, out MolarityUnit unit)
        {
            return UnitParser.Default.TryParse<MolarityUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static Molarity operator -(Molarity right)
        {
            return new Molarity(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Molarity"/> from adding two <see cref="Molarity"/>.</summary>
        public static Molarity operator +(Molarity left, Molarity right)
        {
            return new Molarity(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Molarity"/> from subtracting two <see cref="Molarity"/>.</summary>
        public static Molarity operator -(Molarity left, Molarity right)
        {
            return new Molarity(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Molarity"/> from multiplying value and <see cref="Molarity"/>.</summary>
        public static Molarity operator *(double left, Molarity right)
        {
            return new Molarity(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Molarity"/> from multiplying value and <see cref="Molarity"/>.</summary>
        public static Molarity operator *(Molarity left, double right)
        {
            return new Molarity(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="Molarity"/> from dividing <see cref="Molarity"/> by value.</summary>
        public static Molarity operator /(Molarity left, double right)
        {
            return new Molarity(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="Molarity"/> by <see cref="Molarity"/>.</summary>
        public static double operator /(Molarity left, Molarity right)
        {
            return left.MolesPerCubicMeter / right.MolesPerCubicMeter;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(Molarity left, Molarity right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(Molarity left, Molarity right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(Molarity left, Molarity right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(Molarity left, Molarity right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(Molarity, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator ==(Molarity left, Molarity right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns true if not exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(Molarity, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator !=(Molarity left, Molarity right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Molarity objMolarity)) throw new ArgumentException("Expected type Molarity.", nameof(obj));

            return CompareTo(objMolarity);
        }

        /// <inheritdoc />
        public int CompareTo(Molarity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(Molarity, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Molarity objMolarity))
                return false;

            return Equals(objMolarity);
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(Molarity, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public bool Equals(Molarity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Molarity within the given absolute or relative tolerance.
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
        public bool Equals(Molarity other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current Molarity.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(Enum unit) => As((MolarityUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MolarityUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <inheritdoc />
        public double As(Enum unit) => As((MolarityUnit) unit);

        /// <summary>
        ///     Converts this Molarity to another Molarity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Molarity with the specified unit.</returns>
        public Molarity ToUnit(MolarityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Molarity(convertedValue, unit);
        }

        IQuantity<MolarityUnit> IQuantity<MolarityUnit>.ToUnit(MolarityUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        public IQuantity ToUnit(Enum unit) => ToUnit((MolarityUnit) unit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case MolarityUnit.CentimolesPerLiter: return (_value/1e-3) * 1e-2d;
                case MolarityUnit.DecimolesPerLiter: return (_value/1e-3) * 1e-1d;
                case MolarityUnit.MicromolesPerLiter: return (_value/1e-3) * 1e-6d;
                case MolarityUnit.MillimolesPerLiter: return (_value/1e-3) * 1e-3d;
                case MolarityUnit.MolesPerCubicMeter: return _value;
                case MolarityUnit.MolesPerLiter: return _value/1e-3;
                case MolarityUnit.NanomolesPerLiter: return (_value/1e-3) * 1e-9d;
                case MolarityUnit.PicomolesPerLiter: return (_value/1e-3) * 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MolarityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MolarityUnit.CentimolesPerLiter: return (baseUnitValue*1e-3) / 1e-2d;
                case MolarityUnit.DecimolesPerLiter: return (baseUnitValue*1e-3) / 1e-1d;
                case MolarityUnit.MicromolesPerLiter: return (baseUnitValue*1e-3) / 1e-6d;
                case MolarityUnit.MillimolesPerLiter: return (baseUnitValue*1e-3) / 1e-3d;
                case MolarityUnit.MolesPerCubicMeter: return baseUnitValue;
                case MolarityUnit.MolesPerLiter: return baseUnitValue*1e-3;
                case MolarityUnit.NanomolesPerLiter: return (baseUnitValue*1e-3) / 1e-9d;
                case MolarityUnit.PicomolesPerLiter: return (baseUnitValue*1e-3) / 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
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
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider)
        {
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
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
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? CultureInfo.CurrentUICulture;

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
            throw new InvalidCastException($"Converting {typeof(Molarity)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Molarity)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Molarity)} to DateTime is not supported.");
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

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(Molarity))
                return this;
            else if(conversionType == typeof(MolarityUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return Molarity.QuantityType;
            else if(conversionType == typeof(BaseDimensions))
                return Molarity.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(Molarity)} to {conversionType} is not supported.");
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
