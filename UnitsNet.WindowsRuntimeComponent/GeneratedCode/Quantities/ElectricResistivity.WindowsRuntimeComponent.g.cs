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
    ///     Electrical resistivity (also known as resistivity, specific electrical resistance, or volume resistivity) is a fundamental property that quantifies how strongly a given material opposes the flow of electric current.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electrical_resistivity_and_conductivity
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class ElectricResistivity : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricResistivityUnit? _unit;

        static ElectricResistivity()
        {
            BaseDimensions = new BaseDimensions(3, 1, -3, -2, 0, 0, 0);
        }
        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit OhmMeter.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public ElectricResistivity()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private ElectricResistivity(double numericValue, ElectricResistivityUnit unit)
        {
            if(unit == ElectricResistivityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of ElectricResistivity, which is OhmMeter. All conversions go via this value.
        /// </summary>
        public static ElectricResistivityUnit BaseUnit => ElectricResistivityUnit.OhmMeter;

        /// <summary>
        /// Represents the largest possible value of ElectricResistivity
        /// </summary>
        public static ElectricResistivity MaxValue => new ElectricResistivity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricResistivity
        /// </summary>
        public static ElectricResistivity MinValue => new ElectricResistivity(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.ElectricResistivity;

        /// <summary>
        ///     All units of measurement for the ElectricResistivity quantity.
        /// </summary>
        public static ElectricResistivityUnit[] Units { get; } = Enum.GetValues(typeof(ElectricResistivityUnit)).Cast<ElectricResistivityUnit>().Except(new ElectricResistivityUnit[]{ ElectricResistivityUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit OhmMeter.
        /// </summary>
        public static ElectricResistivity Zero => new ElectricResistivity(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public ElectricResistivityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => ElectricResistivity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ElectricResistivity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get ElectricResistivity in KiloohmsCentimeter.
        /// </summary>
        public double KiloohmsCentimeter => As(ElectricResistivityUnit.KiloohmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in KiloohmMeters.
        /// </summary>
        public double KiloohmMeters => As(ElectricResistivityUnit.KiloohmMeter);

        /// <summary>
        ///     Get ElectricResistivity in MegaohmsCentimeter.
        /// </summary>
        public double MegaohmsCentimeter => As(ElectricResistivityUnit.MegaohmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in MegaohmMeters.
        /// </summary>
        public double MegaohmMeters => As(ElectricResistivityUnit.MegaohmMeter);

        /// <summary>
        ///     Get ElectricResistivity in MicroohmsCentimeter.
        /// </summary>
        public double MicroohmsCentimeter => As(ElectricResistivityUnit.MicroohmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in MicroohmMeters.
        /// </summary>
        public double MicroohmMeters => As(ElectricResistivityUnit.MicroohmMeter);

        /// <summary>
        ///     Get ElectricResistivity in MilliohmsCentimeter.
        /// </summary>
        public double MilliohmsCentimeter => As(ElectricResistivityUnit.MilliohmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in MilliohmMeters.
        /// </summary>
        public double MilliohmMeters => As(ElectricResistivityUnit.MilliohmMeter);

        /// <summary>
        ///     Get ElectricResistivity in NanoohmsCentimeter.
        /// </summary>
        public double NanoohmsCentimeter => As(ElectricResistivityUnit.NanoohmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in NanoohmMeters.
        /// </summary>
        public double NanoohmMeters => As(ElectricResistivityUnit.NanoohmMeter);

        /// <summary>
        ///     Get ElectricResistivity in OhmsCentimeter.
        /// </summary>
        public double OhmsCentimeter => As(ElectricResistivityUnit.OhmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in OhmMeters.
        /// </summary>
        public double OhmMeters => As(ElectricResistivityUnit.OhmMeter);

        /// <summary>
        ///     Get ElectricResistivity in PicoohmsCentimeter.
        /// </summary>
        public double PicoohmsCentimeter => As(ElectricResistivityUnit.PicoohmCentimeter);

        /// <summary>
        ///     Get ElectricResistivity in PicoohmMeters.
        /// </summary>
        public double PicoohmMeters => As(ElectricResistivityUnit.PicoohmMeter);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(ElectricResistivityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(ElectricResistivityUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ElectricResistivity from KiloohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromKiloohmsCentimeter(double kiloohmscentimeter)
        {
            double value = (double) kiloohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.KiloohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from KiloohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromKiloohmMeters(double kiloohmmeters)
        {
            double value = (double) kiloohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.KiloohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MegaohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromMegaohmsCentimeter(double megaohmscentimeter)
        {
            double value = (double) megaohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.MegaohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MegaohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromMegaohmMeters(double megaohmmeters)
        {
            double value = (double) megaohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.MegaohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MicroohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromMicroohmsCentimeter(double microohmscentimeter)
        {
            double value = (double) microohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.MicroohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MicroohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromMicroohmMeters(double microohmmeters)
        {
            double value = (double) microohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.MicroohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MilliohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromMilliohmsCentimeter(double milliohmscentimeter)
        {
            double value = (double) milliohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.MilliohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from MilliohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromMilliohmMeters(double milliohmmeters)
        {
            double value = (double) milliohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.MilliohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from NanoohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromNanoohmsCentimeter(double nanoohmscentimeter)
        {
            double value = (double) nanoohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.NanoohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from NanoohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromNanoohmMeters(double nanoohmmeters)
        {
            double value = (double) nanoohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.NanoohmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from OhmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromOhmsCentimeter(double ohmscentimeter)
        {
            double value = (double) ohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.OhmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from OhmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromOhmMeters(double ohmmeters)
        {
            double value = (double) ohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.OhmMeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from PicoohmsCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromPicoohmsCentimeter(double picoohmscentimeter)
        {
            double value = (double) picoohmscentimeter;
            return new ElectricResistivity(value, ElectricResistivityUnit.PicoohmCentimeter);
        }
        /// <summary>
        ///     Get ElectricResistivity from PicoohmMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricResistivity FromPicoohmMeters(double picoohmmeters)
        {
            double value = (double) picoohmmeters;
            return new ElectricResistivity(value, ElectricResistivityUnit.PicoohmMeter);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricResistivityUnit" /> to <see cref="ElectricResistivity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricResistivity unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ElectricResistivity From(double value, ElectricResistivityUnit fromUnit)
        {
            return new ElectricResistivity((double)value, fromUnit);
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
        public static ElectricResistivity Parse(string str)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static ElectricResistivity Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<ElectricResistivity, ElectricResistivityUnit>(
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
        public static bool TryParse([CanBeNull] string str, out ElectricResistivity result)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out ElectricResistivity result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<ElectricResistivity, ElectricResistivityUnit>(
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
        public static ElectricResistivityUnit ParseUnit(string str)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static ElectricResistivityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<ElectricResistivityUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out ElectricResistivityUnit unit)
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out ElectricResistivityUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<ElectricResistivityUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is ElectricResistivity objElectricResistivity)) throw new ArgumentException("Expected type ElectricResistivity.", nameof(obj));

            return CompareTo(objElectricResistivity);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(ElectricResistivity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is ElectricResistivity objElectricResistivity))
                return false;

            return Equals(objElectricResistivity);
        }

        public bool Equals(ElectricResistivity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another ElectricResistivity within the given absolute or relative tolerance.
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
        public bool Equals(ElectricResistivity other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current ElectricResistivity.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricResistivityUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this ElectricResistivity to another ElectricResistivity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A ElectricResistivity with the specified unit.</returns>
        public ElectricResistivity ToUnit(ElectricResistivityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new ElectricResistivity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        internal ElectricResistivity AsBaseUnit()
        {
            switch(Unit)
            {
                case ElectricResistivityUnit.KiloohmCentimeter:
                    return new ElectricResistivity((_value/100) * 1e3d, BaseUnit);
                case ElectricResistivityUnit.KiloohmMeter:
                    return new ElectricResistivity((_value) * 1e3d, BaseUnit);
                case ElectricResistivityUnit.MegaohmCentimeter:
                    return new ElectricResistivity((_value/100) * 1e6d, BaseUnit);
                case ElectricResistivityUnit.MegaohmMeter:
                    return new ElectricResistivity((_value) * 1e6d, BaseUnit);
                case ElectricResistivityUnit.MicroohmCentimeter:
                    return new ElectricResistivity((_value/100) * 1e-6d, BaseUnit);
                case ElectricResistivityUnit.MicroohmMeter:
                    return new ElectricResistivity((_value) * 1e-6d, BaseUnit);
                case ElectricResistivityUnit.MilliohmCentimeter:
                    return new ElectricResistivity((_value/100) * 1e-3d, BaseUnit);
                case ElectricResistivityUnit.MilliohmMeter:
                    return new ElectricResistivity((_value) * 1e-3d, BaseUnit);
                case ElectricResistivityUnit.NanoohmCentimeter:
                    return new ElectricResistivity((_value/100) * 1e-9d, BaseUnit);
                case ElectricResistivityUnit.NanoohmMeter:
                    return new ElectricResistivity((_value) * 1e-9d, BaseUnit);
                case ElectricResistivityUnit.OhmCentimeter:
                    return new ElectricResistivity(_value/100, BaseUnit);
                case ElectricResistivityUnit.OhmMeter:
                    return new ElectricResistivity(_value, BaseUnit);
                case ElectricResistivityUnit.PicoohmCentimeter:
                    return new ElectricResistivity((_value/100) * 1e-12d, BaseUnit);
                case ElectricResistivityUnit.PicoohmMeter:
                    return new ElectricResistivity((_value) * 1e-12d, BaseUnit);
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(ElectricResistivityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var asBaseUnit = AsBaseUnit();
            var baseUnitValue = asBaseUnit._value;

            switch(unit)
            {
                case ElectricResistivityUnit.KiloohmCentimeter: return (baseUnitValue*100) / 1e3d;
                case ElectricResistivityUnit.KiloohmMeter: return (baseUnitValue) / 1e3d;
                case ElectricResistivityUnit.MegaohmCentimeter: return (baseUnitValue*100) / 1e6d;
                case ElectricResistivityUnit.MegaohmMeter: return (baseUnitValue) / 1e6d;
                case ElectricResistivityUnit.MicroohmCentimeter: return (baseUnitValue*100) / 1e-6d;
                case ElectricResistivityUnit.MicroohmMeter: return (baseUnitValue) / 1e-6d;
                case ElectricResistivityUnit.MilliohmCentimeter: return (baseUnitValue*100) / 1e-3d;
                case ElectricResistivityUnit.MilliohmMeter: return (baseUnitValue) / 1e-3d;
                case ElectricResistivityUnit.NanoohmCentimeter: return (baseUnitValue*100) / 1e-9d;
                case ElectricResistivityUnit.NanoohmMeter: return (baseUnitValue) / 1e-9d;
                case ElectricResistivityUnit.OhmCentimeter: return baseUnitValue*100;
                case ElectricResistivityUnit.OhmMeter: return baseUnitValue;
                case ElectricResistivityUnit.PicoohmCentimeter: return (baseUnitValue*100) / 1e-12d;
                case ElectricResistivityUnit.PicoohmMeter: return (baseUnitValue) / 1e-12d;
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
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
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
