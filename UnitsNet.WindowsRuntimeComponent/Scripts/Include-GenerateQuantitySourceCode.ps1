﻿using module ".\Types.psm1"

function GenerateQuantitySourceCode([Quantity]$quantity)
{
    $quantityName = $quantity.Name;
    $units = $quantity.Units;
    $valueType = $quantity.BaseType;
    [Unit]$baseUnit = $units | where { $_.SingularName -eq $quantity.BaseUnit } | Select-Object -First 1
    $baseUnitSingularName = $baseUnit.SingularName
    $unitEnumName = "$quantityName" + "Unit"

    $baseDimensions = $quantity.BaseDimensions;
    $isDimensionless = $null -eq $baseDimensions -or ( $baseDimensions.Length -eq 0 -and $baseDimensions.Mass -eq 0 -and $baseDimensions.Time -eq 0 -and $baseDimensions.ElectricCurrent -eq 0 -and $baseDimensions.Temperature -eq 0 -and $baseDimensions.AmountOfSubstance -eq 0 -and $baseDimensions.LuminousIntensity -eq 0 )

    [GeneratorArgs]$genArgs = New-Object GeneratorArgs -Property @{
      Quantity = $quantity;
      BaseUnit = $baseUnit;
      UnitEnumName = $unitEnumName;
    }
    # $genArgs | fl | out-string | write-host -foreground yellow
@"
//------------------------------------------------------------------------------
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
"@;
    $obsoleteAttribute = GetObsoleteAttribute($quantity);
    if ($obsoleteAttribute)
    {
      $obsoleteAttribute = "`r`n    " + $obsoleteAttribute; # apply padding to conformance with code format in this section
    }@"
    /// <summary>
    ///     $($quantity.XmlDocSummary)
    /// </summary>
"@; if ($quantity.XmlDocRemarks) {@"
    /// <remarks>
    ///     $($quantity.XmlDocRemarks)
    /// </remarks>
"@; }@"
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class $quantityName : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly $valueType _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly $($unitEnumName)? _unit;

        static $quantityName()
        {
"@; if($isDimensionless) {@"
            BaseDimensions = BaseDimensions.Dimensionless;
"@; } else {@"
            BaseDimensions = new BaseDimensions($($baseDimensions.Length), $($baseDimensions.Mass), $($baseDimensions.Time), $($baseDimensions.ElectricCurrent), $($baseDimensions.Temperature), $($baseDimensions.AmountOfSubstance), $($baseDimensions.LuminousIntensity));
"@; }@"
            Info = new QuantityInfo(QuantityType.$quantityName, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit $baseUnitSingularName.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public $quantityName()
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
        private $quantityName($valueType numericValue, $unitEnumName unit)
        {
            if(unit == $unitEnumName.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

"@; if ($quantity.BaseType -eq "double") {@"
            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
"@; } else {@"
            _value = numericValue;
"@; }@"
            _unit = unit;
        }
"@;
    GenerateStaticProperties $genArgs
    GenerateProperties $genArgs
    GenerateConversionProperties $genArgs
    GenerateStaticMethods $genArgs
    GenerateStaticFactoryMethods $genArgs
    GenerateStaticParseMethods $genArgs
    GenerateEqualityAndComparison $genArgs
    GenerateConversionMethods  $genArgs
@"

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
"@;
}

function GenerateStaticProperties([GeneratorArgs]$genArgs)
{
    $quantityName = $genArgs.Quantity.Name
    $unitEnumName = $genArgs.UnitEnumName
    $baseUnitSingularName = $genArgs.BaseUnit.SingularName
    $valueType = $genArgs.Quantity.BaseType
@"

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of $quantityName, which is $baseUnitSingularName. All conversions go via this value.
        /// </summary>
        public static $unitEnumName BaseUnit { get; } = $unitEnumName.$baseUnitSingularName;

        /// <summary>
        /// Represents the largest possible value of $quantityName
        /// </summary>
        public static $quantityName MaxValue { get; } = new $quantityName($valueType.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of $quantityName
        /// </summary>
        public static $quantityName MinValue { get; } = new $quantityName($valueType.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.$quantityName;

        /// <summary>
        ///     All units of measurement for the $quantityName quantity.
        /// </summary>
        public static $unitEnumName[] Units { get; } = Enum.GetValues(typeof($unitEnumName)).Cast<$unitEnumName>().Except(new $unitEnumName[]{ $unitEnumName.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit $baseUnitSingularName.
        /// </summary>
        public static $quantityName Zero { get; } = new $quantityName(0, BaseUnit);

        #endregion
"@;
}

function GenerateProperties([GeneratorArgs]$genArgs)
{
  $quantityName = $genArgs.Quantity.Name
  $unitEnumName = $genArgs.UnitEnumName
@"

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public $unitEnumName Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => $quantityName.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => $quantityName.BaseDimensions;

        #endregion
"@;
}

function GenerateConversionProperties([GeneratorArgs]$genArgs)
{
  $quantityName = $genArgs.Quantity.Name
  $unitEnumName = $genArgs.UnitEnumName
  $units = $genArgs.Quantity.Units
@"

        #region Conversion Properties
"@;
    foreach ($unit in $units) {
      $propertyName = $unit.PluralName;
      $obsoleteAttribute = GetObsoleteAttribute($unit);
      if ($obsoleteAttribute)
      {
        $obsoleteAttribute = "`r`n        " + $obsoleteAttribute; # apply padding to conformance with code format in this page
      }
@"

        /// <summary>
        ///     Get $quantityName in $propertyName.
        /// </summary>$($obsoleteAttribute)
        public double $propertyName => As($unitEnumName.$($unit.SingularName));
"@; }
@"

        #endregion
"@;
}

function GenerateStaticMethods([GeneratorArgs]$genArgs)
{
  $unitEnumName = $genArgs.UnitEnumName
@"

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation($unitEnumName unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation($unitEnumName unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion
"@;
}

function GenerateStaticFactoryMethods([GeneratorArgs]$genArgs)
{
  $quantityName = $genArgs.Quantity.Name
  $unitEnumName = $genArgs.UnitEnumName
  $units = $genArgs.Quantity.Units
  $valueType = $genArgs.Quantity.BaseType
@"

        #region Static Factory Methods

"@; foreach ($unit in $units) {
  $valueParamName = $unit.PluralName.ToLowerInvariant();
  $obsoleteAttribute = GetObsoleteAttribute($unit);
  if ($obsoleteAttribute)
  {
    $obsoleteAttribute = "`r`n        " + $obsoleteAttribute; # apply padding to conformance with code format in this page
  }
  @"
        /// <summary>
        ///     Get $quantityName from $($unit.PluralName).
        /// </summary>$($obsoleteAttribute)
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static $quantityName From$($unit.PluralName)(double $valueParamName)
        {
            $valueType value = ($valueType) $valueParamName;
            return new $quantityName(value, $unitEnumName.$($unit.SingularName));
        }
"@; }@"

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="$unitEnumName" /> to <see cref="$quantityName" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>$quantityName unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static $quantityName From(double value, $unitEnumName fromUnit)
        {
            return new $quantityName(($valueType)value, fromUnit);
        }

        #endregion
"@;

}

function GenerateStaticParseMethods([GeneratorArgs]$genArgs)
{
  $quantityName = $genArgs.Quantity.Name
  $unitEnumName = $genArgs.UnitEnumName
@"

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
        public static $quantityName Parse(string str)
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
        public static $quantityName Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<$quantityName, $unitEnumName>(
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
        public static bool TryParse([CanBeNull] string str, out $quantityName result)
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
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out $quantityName result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<$quantityName, $unitEnumName>(
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
        public static $unitEnumName ParseUnit(string str)
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
        public static $unitEnumName ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<$unitEnumName>(str, provider);
        }

        public static bool TryParseUnit(string str, out $unitEnumName unit)
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
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out $unitEnumName unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<$unitEnumName>(str, provider, out unit);
        }

        #endregion
"@;
}

function GenerateEqualityAndComparison([GeneratorArgs]$genArgs)
{
  $quantityName = $genArgs.Quantity.Name
@"

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is $quantityName obj$quantityName)) throw new ArgumentException("Expected type $quantityName.", nameof(obj));

            return CompareTo(obj$quantityName);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo($quantityName other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is $quantityName obj$quantityName))
                return false;

            return Equals(obj$quantityName);
        }

        public bool Equals($quantityName other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another $quantityName within the given absolute or relative tolerance.
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
        public bool Equals($quantityName other, double tolerance, ComparisonType comparisonType)
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
        /// <returns>A hash code for the current $quantityName.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion
"@;
}

function GenerateConversionMethods([GeneratorArgs]$genArgs)
{
  $quantityName = $genArgs.Quantity.Name
  $unitEnumName = $genArgs.UnitEnumName
  $valueType = $genArgs.Quantity.BaseType
@"

        #region Conversion Methods

        double IQuantity.As(object unit) => As(($unitEnumName)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As($unitEnumName unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this $quantityName to another $quantityName with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A $quantityName with the specified unit.</returns>
        public $quantityName ToUnit($unitEnumName unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new $quantityName(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private $valueType AsBaseUnit()
        {
            switch(Unit)
            {
"@; foreach ($unit in $units) {
  $func = $unit.FromUnitToBaseFunc.Replace("x", "_value");@"
                case $unitEnumName.$($unit.SingularName): return $func;
"@; }@"
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private $valueType AsBaseNumericType($unitEnumName unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
"@; foreach ($unit in $units) {
  $func = $unit.FromBaseToUnitFunc.Replace("x", "baseUnitValue");@"
                case $unitEnumName.$($unit.SingularName): return $func;
"@; }@"
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion
"@;
}
