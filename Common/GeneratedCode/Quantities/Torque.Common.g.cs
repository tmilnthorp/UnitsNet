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
    ///     Torque, moment or moment of force (see the terminology below), is the tendency of a force to rotate an object about an axis,[1] fulcrum, or pivot. Just as a force is a push or a pull, a torque can be thought of as a twist to an object. Mathematically, torque is defined as the cross product of the lever-arm distance and force, which tends to produce rotation. Loosely speaking, torque is a measure of the turning force on an object such as a bolt or a flywheel. For example, pushing or pulling the handle of a wrench connected to a nut or bolt produces a torque (turning force) that loosens or tightens the nut or bolt.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Torque : IQuantity
#else
    public partial struct Torque : IQuantity, IComparable, IComparable<Torque>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TorqueUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public TorqueUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Torque()
        {
            BaseDimensions = new BaseDimensions(2, 1, -2, 0, 0, 0, 0);
        }

        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public Torque(double newtonmeters)
        {
            _value = Convert.ToDouble(newtonmeters);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public 
#endif
        Torque(double numericValue, TorqueUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit NewtonMeter.
        /// </summary>
        /// <param name="newtonmeters">Value assuming base unit NewtonMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Torque(long newtonmeters) : this(Convert.ToDouble(newtonmeters), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit NewtonMeter.
        /// </summary>
        /// <param name="newtonmeters">Value assuming base unit NewtonMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Torque(decimal newtonmeters) : this(Convert.ToDouble(newtonmeters), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Torque;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static TorqueUnit BaseUnit => TorqueUnit.NewtonMeter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Torque quantity.
        /// </summary>
        public static TorqueUnit[] Units { get; } = Enum.GetValues(typeof(TorqueUnit)).Cast<TorqueUnit>().ToArray();

        /// <summary>
        ///     Get Torque in KilogramForceCentimeters.
        /// </summary>
        public double KilogramForceCentimeters => As(TorqueUnit.KilogramForceCentimeter);

        /// <summary>
        ///     Get Torque in KilogramForceMeters.
        /// </summary>
        public double KilogramForceMeters => As(TorqueUnit.KilogramForceMeter);

        /// <summary>
        ///     Get Torque in KilogramForceMillimeters.
        /// </summary>
        public double KilogramForceMillimeters => As(TorqueUnit.KilogramForceMillimeter);

        /// <summary>
        ///     Get Torque in KilonewtonCentimeters.
        /// </summary>
        public double KilonewtonCentimeters => As(TorqueUnit.KilonewtonCentimeter);

        /// <summary>
        ///     Get Torque in KilonewtonMeters.
        /// </summary>
        public double KilonewtonMeters => As(TorqueUnit.KilonewtonMeter);

        /// <summary>
        ///     Get Torque in KilonewtonMillimeters.
        /// </summary>
        public double KilonewtonMillimeters => As(TorqueUnit.KilonewtonMillimeter);

        /// <summary>
        ///     Get Torque in KilopoundForceFeet.
        /// </summary>
        public double KilopoundForceFeet => As(TorqueUnit.KilopoundForceFoot);

        /// <summary>
        ///     Get Torque in KilopoundForceInches.
        /// </summary>
        public double KilopoundForceInches => As(TorqueUnit.KilopoundForceInch);

        /// <summary>
        ///     Get Torque in MeganewtonCentimeters.
        /// </summary>
        public double MeganewtonCentimeters => As(TorqueUnit.MeganewtonCentimeter);

        /// <summary>
        ///     Get Torque in MeganewtonMeters.
        /// </summary>
        public double MeganewtonMeters => As(TorqueUnit.MeganewtonMeter);

        /// <summary>
        ///     Get Torque in MeganewtonMillimeters.
        /// </summary>
        public double MeganewtonMillimeters => As(TorqueUnit.MeganewtonMillimeter);

        /// <summary>
        ///     Get Torque in MegapoundForceFeet.
        /// </summary>
        public double MegapoundForceFeet => As(TorqueUnit.MegapoundForceFoot);

        /// <summary>
        ///     Get Torque in MegapoundForceInches.
        /// </summary>
        public double MegapoundForceInches => As(TorqueUnit.MegapoundForceInch);

        /// <summary>
        ///     Get Torque in NewtonCentimeters.
        /// </summary>
        public double NewtonCentimeters => As(TorqueUnit.NewtonCentimeter);

        /// <summary>
        ///     Get Torque in NewtonMeters.
        /// </summary>
        public double NewtonMeters => As(TorqueUnit.NewtonMeter);

        /// <summary>
        ///     Get Torque in NewtonMillimeters.
        /// </summary>
        public double NewtonMillimeters => As(TorqueUnit.NewtonMillimeter);

        /// <summary>
        ///     Get Torque in PoundForceFeet.
        /// </summary>
        public double PoundForceFeet => As(TorqueUnit.PoundForceFoot);

        /// <summary>
        ///     Get Torque in PoundForceInches.
        /// </summary>
        public double PoundForceInches => As(TorqueUnit.PoundForceInch);

        /// <summary>
        ///     Get Torque in TonneForceCentimeters.
        /// </summary>
        public double TonneForceCentimeters => As(TorqueUnit.TonneForceCentimeter);

        /// <summary>
        ///     Get Torque in TonneForceMeters.
        /// </summary>
        public double TonneForceMeters => As(TorqueUnit.TonneForceMeter);

        /// <summary>
        ///     Get Torque in TonneForceMillimeters.
        /// </summary>
        public double TonneForceMillimeters => As(TorqueUnit.TonneForceMillimeter);

        #endregion

        #region Static

        public static Torque Zero => new Torque(0, BaseUnit);

        /// <summary>
        ///     Get Torque from KilogramForceCentimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilogramForceCentimeters(double kilogramforcecentimeters)
#else
        public static Torque FromKilogramForceCentimeters(QuantityValue kilogramforcecentimeters)
#endif
        {
            double value = (double) kilogramforcecentimeters;
            return new Torque(value, TorqueUnit.KilogramForceCentimeter);
        }

        /// <summary>
        ///     Get Torque from KilogramForceMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilogramForceMeters(double kilogramforcemeters)
#else
        public static Torque FromKilogramForceMeters(QuantityValue kilogramforcemeters)
#endif
        {
            double value = (double) kilogramforcemeters;
            return new Torque(value, TorqueUnit.KilogramForceMeter);
        }

        /// <summary>
        ///     Get Torque from KilogramForceMillimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilogramForceMillimeters(double kilogramforcemillimeters)
#else
        public static Torque FromKilogramForceMillimeters(QuantityValue kilogramforcemillimeters)
#endif
        {
            double value = (double) kilogramforcemillimeters;
            return new Torque(value, TorqueUnit.KilogramForceMillimeter);
        }

        /// <summary>
        ///     Get Torque from KilonewtonCentimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilonewtonCentimeters(double kilonewtoncentimeters)
#else
        public static Torque FromKilonewtonCentimeters(QuantityValue kilonewtoncentimeters)
#endif
        {
            double value = (double) kilonewtoncentimeters;
            return new Torque(value, TorqueUnit.KilonewtonCentimeter);
        }

        /// <summary>
        ///     Get Torque from KilonewtonMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilonewtonMeters(double kilonewtonmeters)
#else
        public static Torque FromKilonewtonMeters(QuantityValue kilonewtonmeters)
#endif
        {
            double value = (double) kilonewtonmeters;
            return new Torque(value, TorqueUnit.KilonewtonMeter);
        }

        /// <summary>
        ///     Get Torque from KilonewtonMillimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilonewtonMillimeters(double kilonewtonmillimeters)
#else
        public static Torque FromKilonewtonMillimeters(QuantityValue kilonewtonmillimeters)
#endif
        {
            double value = (double) kilonewtonmillimeters;
            return new Torque(value, TorqueUnit.KilonewtonMillimeter);
        }

        /// <summary>
        ///     Get Torque from KilopoundForceFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilopoundForceFeet(double kilopoundforcefeet)
#else
        public static Torque FromKilopoundForceFeet(QuantityValue kilopoundforcefeet)
#endif
        {
            double value = (double) kilopoundforcefeet;
            return new Torque(value, TorqueUnit.KilopoundForceFoot);
        }

        /// <summary>
        ///     Get Torque from KilopoundForceInches.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromKilopoundForceInches(double kilopoundforceinches)
#else
        public static Torque FromKilopoundForceInches(QuantityValue kilopoundforceinches)
#endif
        {
            double value = (double) kilopoundforceinches;
            return new Torque(value, TorqueUnit.KilopoundForceInch);
        }

        /// <summary>
        ///     Get Torque from MeganewtonCentimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromMeganewtonCentimeters(double meganewtoncentimeters)
#else
        public static Torque FromMeganewtonCentimeters(QuantityValue meganewtoncentimeters)
#endif
        {
            double value = (double) meganewtoncentimeters;
            return new Torque(value, TorqueUnit.MeganewtonCentimeter);
        }

        /// <summary>
        ///     Get Torque from MeganewtonMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromMeganewtonMeters(double meganewtonmeters)
#else
        public static Torque FromMeganewtonMeters(QuantityValue meganewtonmeters)
#endif
        {
            double value = (double) meganewtonmeters;
            return new Torque(value, TorqueUnit.MeganewtonMeter);
        }

        /// <summary>
        ///     Get Torque from MeganewtonMillimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromMeganewtonMillimeters(double meganewtonmillimeters)
#else
        public static Torque FromMeganewtonMillimeters(QuantityValue meganewtonmillimeters)
#endif
        {
            double value = (double) meganewtonmillimeters;
            return new Torque(value, TorqueUnit.MeganewtonMillimeter);
        }

        /// <summary>
        ///     Get Torque from MegapoundForceFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromMegapoundForceFeet(double megapoundforcefeet)
#else
        public static Torque FromMegapoundForceFeet(QuantityValue megapoundforcefeet)
#endif
        {
            double value = (double) megapoundforcefeet;
            return new Torque(value, TorqueUnit.MegapoundForceFoot);
        }

        /// <summary>
        ///     Get Torque from MegapoundForceInches.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromMegapoundForceInches(double megapoundforceinches)
#else
        public static Torque FromMegapoundForceInches(QuantityValue megapoundforceinches)
#endif
        {
            double value = (double) megapoundforceinches;
            return new Torque(value, TorqueUnit.MegapoundForceInch);
        }

        /// <summary>
        ///     Get Torque from NewtonCentimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromNewtonCentimeters(double newtoncentimeters)
#else
        public static Torque FromNewtonCentimeters(QuantityValue newtoncentimeters)
#endif
        {
            double value = (double) newtoncentimeters;
            return new Torque(value, TorqueUnit.NewtonCentimeter);
        }

        /// <summary>
        ///     Get Torque from NewtonMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromNewtonMeters(double newtonmeters)
#else
        public static Torque FromNewtonMeters(QuantityValue newtonmeters)
#endif
        {
            double value = (double) newtonmeters;
            return new Torque(value, TorqueUnit.NewtonMeter);
        }

        /// <summary>
        ///     Get Torque from NewtonMillimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromNewtonMillimeters(double newtonmillimeters)
#else
        public static Torque FromNewtonMillimeters(QuantityValue newtonmillimeters)
#endif
        {
            double value = (double) newtonmillimeters;
            return new Torque(value, TorqueUnit.NewtonMillimeter);
        }

        /// <summary>
        ///     Get Torque from PoundForceFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromPoundForceFeet(double poundforcefeet)
#else
        public static Torque FromPoundForceFeet(QuantityValue poundforcefeet)
#endif
        {
            double value = (double) poundforcefeet;
            return new Torque(value, TorqueUnit.PoundForceFoot);
        }

        /// <summary>
        ///     Get Torque from PoundForceInches.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromPoundForceInches(double poundforceinches)
#else
        public static Torque FromPoundForceInches(QuantityValue poundforceinches)
#endif
        {
            double value = (double) poundforceinches;
            return new Torque(value, TorqueUnit.PoundForceInch);
        }

        /// <summary>
        ///     Get Torque from TonneForceCentimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromTonneForceCentimeters(double tonneforcecentimeters)
#else
        public static Torque FromTonneForceCentimeters(QuantityValue tonneforcecentimeters)
#endif
        {
            double value = (double) tonneforcecentimeters;
            return new Torque(value, TorqueUnit.TonneForceCentimeter);
        }

        /// <summary>
        ///     Get Torque from TonneForceMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromTonneForceMeters(double tonneforcemeters)
#else
        public static Torque FromTonneForceMeters(QuantityValue tonneforcemeters)
#endif
        {
            double value = (double) tonneforcemeters;
            return new Torque(value, TorqueUnit.TonneForceMeter);
        }

        /// <summary>
        ///     Get Torque from TonneForceMillimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Torque FromTonneForceMillimeters(double tonneforcemillimeters)
#else
        public static Torque FromTonneForceMillimeters(QuantityValue tonneforcemillimeters)
#endif
        {
            double value = (double) tonneforcemillimeters;
            return new Torque(value, TorqueUnit.TonneForceMillimeter);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TorqueUnit" /> to <see cref="Torque" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Torque unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Torque From(double value, TorqueUnit fromUnit)
#else
        public static Torque From(QuantityValue value, TorqueUnit fromUnit)
#endif
        {
            return new Torque((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(TorqueUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Torque)) throw new ArgumentException("Expected type Torque.", nameof(obj));

            return CompareTo((Torque)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Torque other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals($quantityName, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Torque))
                return false;

            var objQuantity = (Torque)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Torque within the given absolute or relative tolerance.
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
        public bool Equals(Torque other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another Torque by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(Torque, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(Torque other, Torque maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TorqueUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Torque to another Torque with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Torque with the specified unit.</returns>
        public Torque ToUnit(TorqueUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Torque(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case TorqueUnit.KilogramForceCentimeter: return _value*0.0980665019960652;
                case TorqueUnit.KilogramForceMeter: return _value*9.80665019960652;
                case TorqueUnit.KilogramForceMillimeter: return _value*0.00980665019960652;
                case TorqueUnit.KilonewtonCentimeter: return (_value*0.01) * 1e3d;
                case TorqueUnit.KilonewtonMeter: return (_value) * 1e3d;
                case TorqueUnit.KilonewtonMillimeter: return (_value*0.001) * 1e3d;
                case TorqueUnit.KilopoundForceFoot: return (_value*1.3558179483314) * 1e3d;
                case TorqueUnit.KilopoundForceInch: return (_value*1.129848290276167e-1) * 1e3d;
                case TorqueUnit.MeganewtonCentimeter: return (_value*0.01) * 1e6d;
                case TorqueUnit.MeganewtonMeter: return (_value) * 1e6d;
                case TorqueUnit.MeganewtonMillimeter: return (_value*0.001) * 1e6d;
                case TorqueUnit.MegapoundForceFoot: return (_value*1.3558179483314) * 1e6d;
                case TorqueUnit.MegapoundForceInch: return (_value*1.129848290276167e-1) * 1e6d;
                case TorqueUnit.NewtonCentimeter: return _value*0.01;
                case TorqueUnit.NewtonMeter: return _value;
                case TorqueUnit.NewtonMillimeter: return _value*0.001;
                case TorqueUnit.PoundForceFoot: return _value*1.3558179483314;
                case TorqueUnit.PoundForceInch: return _value*1.129848290276167e-1;
                case TorqueUnit.TonneForceCentimeter: return _value*98.0665019960652;
                case TorqueUnit.TonneForceMeter: return _value*9806.65019960653;
                case TorqueUnit.TonneForceMillimeter: return _value*9.80665019960652;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(TorqueUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case TorqueUnit.KilogramForceCentimeter: return baseUnitValue*10.1971619222242;
                case TorqueUnit.KilogramForceMeter: return baseUnitValue*0.101971619222242;
                case TorqueUnit.KilogramForceMillimeter: return baseUnitValue*101.971619222242;
                case TorqueUnit.KilonewtonCentimeter: return (baseUnitValue*100) / 1e3d;
                case TorqueUnit.KilonewtonMeter: return (baseUnitValue) / 1e3d;
                case TorqueUnit.KilonewtonMillimeter: return (baseUnitValue*1000) / 1e3d;
                case TorqueUnit.KilopoundForceFoot: return (baseUnitValue/1.3558179483314) / 1e3d;
                case TorqueUnit.KilopoundForceInch: return (baseUnitValue/1.129848290276167e-1) / 1e3d;
                case TorqueUnit.MeganewtonCentimeter: return (baseUnitValue*100) / 1e6d;
                case TorqueUnit.MeganewtonMeter: return (baseUnitValue) / 1e6d;
                case TorqueUnit.MeganewtonMillimeter: return (baseUnitValue*1000) / 1e6d;
                case TorqueUnit.MegapoundForceFoot: return (baseUnitValue/1.3558179483314) / 1e6d;
                case TorqueUnit.MegapoundForceInch: return (baseUnitValue/1.129848290276167e-1) / 1e6d;
                case TorqueUnit.NewtonCentimeter: return baseUnitValue*100;
                case TorqueUnit.NewtonMeter: return baseUnitValue;
                case TorqueUnit.NewtonMillimeter: return baseUnitValue*1000;
                case TorqueUnit.PoundForceFoot: return baseUnitValue/1.3558179483314;
                case TorqueUnit.PoundForceInch: return baseUnitValue/1.129848290276167e-1;
                case TorqueUnit.TonneForceCentimeter: return baseUnitValue*0.0101971619222242;
                case TorqueUnit.TonneForceMeter: return baseUnitValue*0.000101971619222242;
                case TorqueUnit.TonneForceMillimeter: return baseUnitValue*0.101971619222242;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

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
        public static Torque Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Torque result)
        {
            return TryParse(str, null, out result);
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
        public static TorqueUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from other .NET targets.")]
        public static TorqueUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        #endregion

        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        /// <summary>
        ///     Set the default unit used by ToString(). Default is NewtonMeter
        /// </summary>
        public static TorqueUnit ToStringDefaultUnit { get; set; } = TorqueUnit.NewtonMeter;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(TorqueUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Torque
        /// </summary>
        public static Torque MaxValue => new Torque(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Torque
        /// </summary>
        public static Torque MinValue => new Torque(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Torque.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Torque.BaseDimensions;
    }
}
