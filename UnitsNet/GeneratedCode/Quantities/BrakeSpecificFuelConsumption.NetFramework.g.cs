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
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Brake specific fuel consumption (BSFC) is a measure of the fuel efficiency of any prime mover that burns fuel and produces rotational, or shaft, power. It is typically used for comparing the efficiency of internal combustion engines with a shaft output.
    /// </summary>
    public partial struct BrakeSpecificFuelConsumption : IQuantity<BrakeSpecificFuelConsumptionUnit>, IEquatable<BrakeSpecificFuelConsumption>, IComparable, IComparable<BrakeSpecificFuelConsumption>, IConvertible, IFormattable
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly BrakeSpecificFuelConsumptionUnit? _unit;

        static BrakeSpecificFuelConsumption()
        {
            BaseDimensions = new BaseDimensions(-2, 0, 2, 0, 0, 0, 0);
            Info = new QuantityInfo<BrakeSpecificFuelConsumptionUnit>(QuantityType.BrakeSpecificFuelConsumption, Units, BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public BrakeSpecificFuelConsumption(double numericValue, BrakeSpecificFuelConsumptionUnit unit)
        {
            if(unit == BrakeSpecificFuelConsumptionUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<BrakeSpecificFuelConsumptionUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of BrakeSpecificFuelConsumption, which is KilogramPerJoule. All conversions go via this value.
        /// </summary>
        public static BrakeSpecificFuelConsumptionUnit BaseUnit { get; } = BrakeSpecificFuelConsumptionUnit.KilogramPerJoule;

        /// <summary>
        /// Represents the largest possible value of BrakeSpecificFuelConsumption
        /// </summary>
        public static BrakeSpecificFuelConsumption MaxValue { get; } = new BrakeSpecificFuelConsumption(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of BrakeSpecificFuelConsumption
        /// </summary>
        public static BrakeSpecificFuelConsumption MinValue { get; } = new BrakeSpecificFuelConsumption(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.BrakeSpecificFuelConsumption;

        /// <summary>
        ///     All units of measurement for the BrakeSpecificFuelConsumption quantity.
        /// </summary>
        public static BrakeSpecificFuelConsumptionUnit[] Units { get; } = Enum.GetValues(typeof(BrakeSpecificFuelConsumptionUnit)).Cast<BrakeSpecificFuelConsumptionUnit>().Except(new BrakeSpecificFuelConsumptionUnit[]{ BrakeSpecificFuelConsumptionUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit KilogramPerJoule.
        /// </summary>
        public static BrakeSpecificFuelConsumption Zero { get; } = new BrakeSpecificFuelConsumption(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public BrakeSpecificFuelConsumptionUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<BrakeSpecificFuelConsumptionUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => BrakeSpecificFuelConsumption.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => BrakeSpecificFuelConsumption.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in GramsPerKiloWattHour.
        /// </summary>
        public double GramsPerKiloWattHour => As(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in KilogramsPerJoule.
        /// </summary>
        public double KilogramsPerJoule => As(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption in PoundsPerMechanicalHorsepowerHour.
        /// </summary>
        public double PoundsPerMechanicalHorsepowerHour => As(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(BrakeSpecificFuelConsumptionUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(BrakeSpecificFuelConsumptionUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get BrakeSpecificFuelConsumption from GramsPerKiloWattHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BrakeSpecificFuelConsumption FromGramsPerKiloWattHour(QuantityValue gramsperkilowatthour)
        {
            double value = (double) gramsperkilowatthour;
            return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
        }
        /// <summary>
        ///     Get BrakeSpecificFuelConsumption from KilogramsPerJoule.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BrakeSpecificFuelConsumption FromKilogramsPerJoule(QuantityValue kilogramsperjoule)
        {
            double value = (double) kilogramsperjoule;
            return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
        }
        /// <summary>
        ///     Get BrakeSpecificFuelConsumption from PoundsPerMechanicalHorsepowerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static BrakeSpecificFuelConsumption FromPoundsPerMechanicalHorsepowerHour(QuantityValue poundspermechanicalhorsepowerhour)
        {
            double value = (double) poundspermechanicalhorsepowerhour;
            return new BrakeSpecificFuelConsumption(value, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="BrakeSpecificFuelConsumptionUnit" /> to <see cref="BrakeSpecificFuelConsumption" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>BrakeSpecificFuelConsumption unit value.</returns>
        public static BrakeSpecificFuelConsumption From(QuantityValue value, BrakeSpecificFuelConsumptionUnit fromUnit)
        {
            return new BrakeSpecificFuelConsumption((double)value, fromUnit);
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
        public static BrakeSpecificFuelConsumption Parse(string str)
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
        public static BrakeSpecificFuelConsumption Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            return QuantityParser.Default.Parse<BrakeSpecificFuelConsumption, BrakeSpecificFuelConsumptionUnit>(
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
        public static bool TryParse([CanBeNull] string str, out BrakeSpecificFuelConsumption result)
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
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out BrakeSpecificFuelConsumption result)
        {
            return QuantityParser.Default.TryParse<BrakeSpecificFuelConsumption, BrakeSpecificFuelConsumptionUnit>(
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
        public static BrakeSpecificFuelConsumptionUnit ParseUnit(string str)
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
        public static BrakeSpecificFuelConsumptionUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            return UnitParser.Default.Parse<BrakeSpecificFuelConsumptionUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.BrakeSpecificFuelConsumptionUnit)"/>
        public static bool TryParseUnit(string str, out BrakeSpecificFuelConsumptionUnit unit)
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
        public static bool TryParseUnit(string str, IFormatProvider provider, out BrakeSpecificFuelConsumptionUnit unit)
        {
            return UnitParser.Default.TryParse<BrakeSpecificFuelConsumptionUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static BrakeSpecificFuelConsumption operator -(BrakeSpecificFuelConsumption right)
        {
            return new BrakeSpecificFuelConsumption(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="BrakeSpecificFuelConsumption"/> from adding two <see cref="BrakeSpecificFuelConsumption"/>.</summary>
        public static BrakeSpecificFuelConsumption operator +(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return new BrakeSpecificFuelConsumption(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="BrakeSpecificFuelConsumption"/> from subtracting two <see cref="BrakeSpecificFuelConsumption"/>.</summary>
        public static BrakeSpecificFuelConsumption operator -(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return new BrakeSpecificFuelConsumption(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="BrakeSpecificFuelConsumption"/> from multiplying value and <see cref="BrakeSpecificFuelConsumption"/>.</summary>
        public static BrakeSpecificFuelConsumption operator *(double left, BrakeSpecificFuelConsumption right)
        {
            return new BrakeSpecificFuelConsumption(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="BrakeSpecificFuelConsumption"/> from multiplying value and <see cref="BrakeSpecificFuelConsumption"/>.</summary>
        public static BrakeSpecificFuelConsumption operator *(BrakeSpecificFuelConsumption left, double right)
        {
            return new BrakeSpecificFuelConsumption(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="BrakeSpecificFuelConsumption"/> from dividing <see cref="BrakeSpecificFuelConsumption"/> by value.</summary>
        public static BrakeSpecificFuelConsumption operator /(BrakeSpecificFuelConsumption left, double right)
        {
            return new BrakeSpecificFuelConsumption(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="BrakeSpecificFuelConsumption"/> by <see cref="BrakeSpecificFuelConsumption"/>.</summary>
        public static double operator /(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return left.KilogramsPerJoule / right.KilogramsPerJoule;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(BrakeSpecificFuelConsumption, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator ==(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns true if not exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(BrakeSpecificFuelConsumption, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator !=(BrakeSpecificFuelConsumption left, BrakeSpecificFuelConsumption right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is BrakeSpecificFuelConsumption objBrakeSpecificFuelConsumption)) throw new ArgumentException("Expected type BrakeSpecificFuelConsumption.", nameof(obj));

            return CompareTo(objBrakeSpecificFuelConsumption);
        }

        /// <inheritdoc />
        public int CompareTo(BrakeSpecificFuelConsumption other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(BrakeSpecificFuelConsumption, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is BrakeSpecificFuelConsumption objBrakeSpecificFuelConsumption))
                return false;

            return Equals(objBrakeSpecificFuelConsumption);
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(BrakeSpecificFuelConsumption, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public bool Equals(BrakeSpecificFuelConsumption other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another BrakeSpecificFuelConsumption within the given absolute or relative tolerance.
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
        public bool Equals(BrakeSpecificFuelConsumption other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current BrakeSpecificFuelConsumption.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(Enum unit) => As((BrakeSpecificFuelConsumptionUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(BrakeSpecificFuelConsumptionUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <inheritdoc />
        public double As(Enum unit) => As((BrakeSpecificFuelConsumptionUnit) unit);

        /// <summary>
        ///     Converts this BrakeSpecificFuelConsumption to another BrakeSpecificFuelConsumption with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A BrakeSpecificFuelConsumption with the specified unit.</returns>
        public BrakeSpecificFuelConsumption ToUnit(BrakeSpecificFuelConsumptionUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new BrakeSpecificFuelConsumption(convertedValue, unit);
        }

        IQuantity<BrakeSpecificFuelConsumptionUnit> IQuantity<BrakeSpecificFuelConsumptionUnit>.ToUnit(BrakeSpecificFuelConsumptionUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        public IQuantity ToUnit(Enum unit) => ToUnit((BrakeSpecificFuelConsumptionUnit) unit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour: return _value/3.6e9;
                case BrakeSpecificFuelConsumptionUnit.KilogramPerJoule: return _value;
                case BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour: return _value*1.689659410672e-7;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(BrakeSpecificFuelConsumptionUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour: return baseUnitValue*3.6e9;
                case BrakeSpecificFuelConsumptionUnit.KilogramPerJoule: return baseUnitValue;
                case BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour: return baseUnitValue/1.689659410672e-7;
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
            return ToString("g");
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

        /// <summary>
        /// Gets the string representation of this instance in the specified format string using <see cref="GlobalConfiguration.DefaultCulture" />.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <returns>The string representation.</returns>
        /// <remarks>
        /// The valid format strings are as follows:
        /// "g": The quantity formatted as the value with 2 significant digits after the radix, and abbreviation. For example: 1.23 m
        /// "a": The default abbreviation for the quantity's unit.
        /// "a0", "a1", "a2", etc.: The abbreviation with index where multiple abbreviations exist. "a0" is the same as "a" or the default abbreviation.
        /// "v": The quantity's value outputted as a string using the default representation.
        /// "u": The quantity's unit
        /// "q": The quantity's name.
        /// "s1", "s4", etc.: The quantity formatted as the value with n significant digits after the radix, and abbreviation. For example, "s4" would give: 1.2345 m
        /// </remarks>
        public string ToString(string format)
        {
            return ToString(format, GlobalConfiguration.DefaultCulture);
        }

        /// <summary>
        /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="GlobalConfiguration.DefaultCulture" /> if null.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="formatProvider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        /// <returns>The string representation.</returns>
        /// <remarks>
        /// The valid format strings are as follows:
        /// "g": The quantity formatted as the value with 2 significant digits after the radix, and abbreviation. For example: 1.23 m
        /// "a": The default abbreviation for the quantity's unit.
        /// "a0", "a1", "a2", etc.: The abbreviation with index where multiple abbreviations exist. "a0" is the same as "a" or the default abbreviation.
        /// "v": The quantity's value outputted as a string using the default representation.
        /// "u": The quantity's unit
        /// "q": The quantity's name.
        /// "s1", "s4", etc.: The quantity formatted as the value with n significant digits after the radix, and abbreviation. For example, "s4" would give: 1.2345 m
        /// </remarks>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return QuantityFormatter.Format<BrakeSpecificFuelConsumptionUnit>(this, format, formatProvider);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(BrakeSpecificFuelConsumption)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(BrakeSpecificFuelConsumption)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(BrakeSpecificFuelConsumption)} to DateTime is not supported.");
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
            if(conversionType == typeof(BrakeSpecificFuelConsumption))
                return this;
            else if(conversionType == typeof(BrakeSpecificFuelConsumptionUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return BrakeSpecificFuelConsumption.QuantityType;
            else if(conversionType == typeof(BaseDimensions))
                return BrakeSpecificFuelConsumption.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(BrakeSpecificFuelConsumption)} to {conversionType} is not supported.");
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
