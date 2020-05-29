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
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Force.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceTestsBase
    {
        protected abstract double DecanewtonsInOneNewton { get; }
        protected abstract double DyneInOneNewton { get; }
        protected abstract double KilogramsForceInOneNewton { get; }
        protected abstract double KilonewtonsInOneNewton { get; }
        protected abstract double KiloPondsInOneNewton { get; }
        protected abstract double KilopoundsForceInOneNewton { get; }
        protected abstract double MeganewtonsInOneNewton { get; }
        protected abstract double MicronewtonsInOneNewton { get; }
        protected abstract double MillinewtonsInOneNewton { get; }
        protected abstract double NewtonsInOneNewton { get; }
        protected abstract double OunceForceInOneNewton { get; }
        protected abstract double PoundalsInOneNewton { get; }
        protected abstract double PoundsForceInOneNewton { get; }
        protected abstract double TonnesForceInOneNewton { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecanewtonsTolerance { get { return 1e-5; } }
        protected virtual double DyneTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForceTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsTolerance { get { return 1e-5; } }
        protected virtual double KiloPondsTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsForceTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonsTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsTolerance { get { return 1e-5; } }
        protected virtual double NewtonsTolerance { get { return 1e-5; } }
        protected virtual double OunceForceTolerance { get { return 1e-5; } }
        protected virtual double PoundalsTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceTolerance { get { return 1e-5; } }
        protected virtual double TonnesForceTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Force((double)0.0, ForceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Force();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ForceUnit.Newton, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Force(double.PositiveInfinity, ForceUnit.Newton));
            Assert.Throws<ArgumentException>(() => new Force(double.NegativeInfinity, ForceUnit.Newton));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Force(double.NaN, ForceUnit.Newton));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Force(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void Force_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Force(1, ForceUnit.Newton);

            QuantityInfo<ForceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Force.Zero, quantityInfo.Zero);
            Assert.Equal("Force", quantityInfo.Name);
            Assert.Equal(QuantityType.Force, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ForceUnit>().Except(new[] {ForceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void NewtonToForceUnits()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.Dyne, DyneTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(KilopoundsForceInOneNewton, newton.KilopoundsForce, KilopoundsForceTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, newton.Micronewtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, newton.Millinewtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(OunceForceInOneNewton, newton.OunceForce, OunceForceTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.TonnesForce, TonnesForceTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Force.From(1, ForceUnit.Decanewton);
            AssertEx.EqualTolerance(1, quantity00.Decanewtons, DecanewtonsTolerance);
            Assert.Equal(ForceUnit.Decanewton, quantity00.Unit);

            var quantity01 = Force.From(1, ForceUnit.Dyn);
            AssertEx.EqualTolerance(1, quantity01.Dyne, DyneTolerance);
            Assert.Equal(ForceUnit.Dyn, quantity01.Unit);

            var quantity02 = Force.From(1, ForceUnit.KilogramForce);
            AssertEx.EqualTolerance(1, quantity02.KilogramsForce, KilogramsForceTolerance);
            Assert.Equal(ForceUnit.KilogramForce, quantity02.Unit);

            var quantity03 = Force.From(1, ForceUnit.Kilonewton);
            AssertEx.EqualTolerance(1, quantity03.Kilonewtons, KilonewtonsTolerance);
            Assert.Equal(ForceUnit.Kilonewton, quantity03.Unit);

            var quantity04 = Force.From(1, ForceUnit.KiloPond);
            AssertEx.EqualTolerance(1, quantity04.KiloPonds, KiloPondsTolerance);
            Assert.Equal(ForceUnit.KiloPond, quantity04.Unit);

            var quantity05 = Force.From(1, ForceUnit.KilopoundForce);
            AssertEx.EqualTolerance(1, quantity05.KilopoundsForce, KilopoundsForceTolerance);
            Assert.Equal(ForceUnit.KilopoundForce, quantity05.Unit);

            var quantity06 = Force.From(1, ForceUnit.Meganewton);
            AssertEx.EqualTolerance(1, quantity06.Meganewtons, MeganewtonsTolerance);
            Assert.Equal(ForceUnit.Meganewton, quantity06.Unit);

            var quantity07 = Force.From(1, ForceUnit.Micronewton);
            AssertEx.EqualTolerance(1, quantity07.Micronewtons, MicronewtonsTolerance);
            Assert.Equal(ForceUnit.Micronewton, quantity07.Unit);

            var quantity08 = Force.From(1, ForceUnit.Millinewton);
            AssertEx.EqualTolerance(1, quantity08.Millinewtons, MillinewtonsTolerance);
            Assert.Equal(ForceUnit.Millinewton, quantity08.Unit);

            var quantity09 = Force.From(1, ForceUnit.Newton);
            AssertEx.EqualTolerance(1, quantity09.Newtons, NewtonsTolerance);
            Assert.Equal(ForceUnit.Newton, quantity09.Unit);

            var quantity10 = Force.From(1, ForceUnit.OunceForce);
            AssertEx.EqualTolerance(1, quantity10.OunceForce, OunceForceTolerance);
            Assert.Equal(ForceUnit.OunceForce, quantity10.Unit);

            var quantity11 = Force.From(1, ForceUnit.Poundal);
            AssertEx.EqualTolerance(1, quantity11.Poundals, PoundalsTolerance);
            Assert.Equal(ForceUnit.Poundal, quantity11.Unit);

            var quantity12 = Force.From(1, ForceUnit.PoundForce);
            AssertEx.EqualTolerance(1, quantity12.PoundsForce, PoundsForceTolerance);
            Assert.Equal(ForceUnit.PoundForce, quantity12.Unit);

            var quantity13 = Force.From(1, ForceUnit.TonneForce);
            AssertEx.EqualTolerance(1, quantity13.TonnesForce, TonnesForceTolerance);
            Assert.Equal(ForceUnit.TonneForce, quantity13.Unit);

        }

        [Fact]
        public void FromNewtons_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Force.FromNewtons(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Force.FromNewtons(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtons_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Force.FromNewtons(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.As(ForceUnit.Decanewton), DecanewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.As(ForceUnit.Dyn), DyneTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.As(ForceUnit.KilogramForce), KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.As(ForceUnit.Kilonewton), KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.As(ForceUnit.KiloPond), KiloPondsTolerance);
            AssertEx.EqualTolerance(KilopoundsForceInOneNewton, newton.As(ForceUnit.KilopoundForce), KilopoundsForceTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.As(ForceUnit.Meganewton), MeganewtonsTolerance);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, newton.As(ForceUnit.Micronewton), MicronewtonsTolerance);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, newton.As(ForceUnit.Millinewton), MillinewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.As(ForceUnit.Newton), NewtonsTolerance);
            AssertEx.EqualTolerance(OunceForceInOneNewton, newton.As(ForceUnit.OunceForce), OunceForceTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.As(ForceUnit.Poundal), PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.As(ForceUnit.PoundForce), PoundsForceTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.As(ForceUnit.TonneForce), TonnesForceTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newton = Force.FromNewtons(1);

            var decanewtonQuantity = newton.ToUnit(ForceUnit.Decanewton);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, (double)decanewtonQuantity.Value, DecanewtonsTolerance);
            Assert.Equal(ForceUnit.Decanewton, decanewtonQuantity.Unit);

            var dynQuantity = newton.ToUnit(ForceUnit.Dyn);
            AssertEx.EqualTolerance(DyneInOneNewton, (double)dynQuantity.Value, DyneTolerance);
            Assert.Equal(ForceUnit.Dyn, dynQuantity.Unit);

            var kilogramforceQuantity = newton.ToUnit(ForceUnit.KilogramForce);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, (double)kilogramforceQuantity.Value, KilogramsForceTolerance);
            Assert.Equal(ForceUnit.KilogramForce, kilogramforceQuantity.Unit);

            var kilonewtonQuantity = newton.ToUnit(ForceUnit.Kilonewton);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, (double)kilonewtonQuantity.Value, KilonewtonsTolerance);
            Assert.Equal(ForceUnit.Kilonewton, kilonewtonQuantity.Unit);

            var kilopondQuantity = newton.ToUnit(ForceUnit.KiloPond);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, (double)kilopondQuantity.Value, KiloPondsTolerance);
            Assert.Equal(ForceUnit.KiloPond, kilopondQuantity.Unit);

            var kilopoundforceQuantity = newton.ToUnit(ForceUnit.KilopoundForce);
            AssertEx.EqualTolerance(KilopoundsForceInOneNewton, (double)kilopoundforceQuantity.Value, KilopoundsForceTolerance);
            Assert.Equal(ForceUnit.KilopoundForce, kilopoundforceQuantity.Unit);

            var meganewtonQuantity = newton.ToUnit(ForceUnit.Meganewton);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, (double)meganewtonQuantity.Value, MeganewtonsTolerance);
            Assert.Equal(ForceUnit.Meganewton, meganewtonQuantity.Unit);

            var micronewtonQuantity = newton.ToUnit(ForceUnit.Micronewton);
            AssertEx.EqualTolerance(MicronewtonsInOneNewton, (double)micronewtonQuantity.Value, MicronewtonsTolerance);
            Assert.Equal(ForceUnit.Micronewton, micronewtonQuantity.Unit);

            var millinewtonQuantity = newton.ToUnit(ForceUnit.Millinewton);
            AssertEx.EqualTolerance(MillinewtonsInOneNewton, (double)millinewtonQuantity.Value, MillinewtonsTolerance);
            Assert.Equal(ForceUnit.Millinewton, millinewtonQuantity.Unit);

            var newtonQuantity = newton.ToUnit(ForceUnit.Newton);
            AssertEx.EqualTolerance(NewtonsInOneNewton, (double)newtonQuantity.Value, NewtonsTolerance);
            Assert.Equal(ForceUnit.Newton, newtonQuantity.Unit);

            var ounceforceQuantity = newton.ToUnit(ForceUnit.OunceForce);
            AssertEx.EqualTolerance(OunceForceInOneNewton, (double)ounceforceQuantity.Value, OunceForceTolerance);
            Assert.Equal(ForceUnit.OunceForce, ounceforceQuantity.Unit);

            var poundalQuantity = newton.ToUnit(ForceUnit.Poundal);
            AssertEx.EqualTolerance(PoundalsInOneNewton, (double)poundalQuantity.Value, PoundalsTolerance);
            Assert.Equal(ForceUnit.Poundal, poundalQuantity.Unit);

            var poundforceQuantity = newton.ToUnit(ForceUnit.PoundForce);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, (double)poundforceQuantity.Value, PoundsForceTolerance);
            Assert.Equal(ForceUnit.PoundForce, poundforceQuantity.Unit);

            var tonneforceQuantity = newton.ToUnit(ForceUnit.TonneForce);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, (double)tonneforceQuantity.Value, TonnesForceTolerance);
            Assert.Equal(ForceUnit.TonneForce, tonneforceQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(1, Force.FromDecanewtons(newton.Decanewtons).Newtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromDyne(newton.Dyne).Newtons, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilogramsForce(newton.KilogramsForce).Newtons, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilonewtons(newton.Kilonewtons).Newtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromKiloPonds(newton.KiloPonds).Newtons, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilopoundsForce(newton.KilopoundsForce).Newtons, KilopoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromMeganewtons(newton.Meganewtons).Newtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMicronewtons(newton.Micronewtons).Newtons, MicronewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMillinewtons(newton.Millinewtons).Newtons, MillinewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromNewtons(newton.Newtons).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromOunceForce(newton.OunceForce).Newtons, OunceForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundals(newton.Poundals).Newtons, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundsForce(newton.PoundsForce).Newtons, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromTonnesForce(newton.TonnesForce).Newtons, TonnesForceTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Force v = Force.FromNewtons(1);
            AssertEx.EqualTolerance(-1, -v.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(3)-v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(10)/5).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, Force.FromNewtons(10)/Force.FromNewtons(5), NewtonsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Force oneNewton = Force.FromNewtons(1);
            Force twoNewtons = Force.FromNewtons(2);

            Assert.True(oneNewton < twoNewtons);
            Assert.True(oneNewton <= twoNewtons);
            Assert.True(twoNewtons > oneNewton);
            Assert.True(twoNewtons >= oneNewton);

            Assert.False(oneNewton > twoNewtons);
            Assert.False(oneNewton >= twoNewtons);
            Assert.False(twoNewtons < oneNewton);
            Assert.False(twoNewtons <= oneNewton);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Equal(0, newton.CompareTo(newton));
            Assert.True(newton.CompareTo(Force.Zero) > 0);
            Assert.True(Force.Zero.CompareTo(newton) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentException>(() => newton.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentNullException>(() => newton.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Force.FromNewtons(1);
            var b = Force.FromNewtons(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = Force.FromNewtons(1);
            var b = Force.FromNewtons(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Force.FromNewtons(1);
            object b = Force.FromNewtons(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Force.FromNewtons(1);
            Assert.True(v.Equals(Force.FromNewtons(1), NewtonsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Force.Zero, NewtonsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Force.FromNewtons(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Force.FromNewtons(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ForceUnit.Undefined, Force.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ForceUnit)).Cast<ForceUnit>();
            foreach(var unit in units)
            {
                if(unit == ForceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Force.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 daN", new Force(1, ForceUnit.Decanewton).ToString());
                Assert.Equal("1 dyn", new Force(1, ForceUnit.Dyn).ToString());
                Assert.Equal("1 kgf", new Force(1, ForceUnit.KilogramForce).ToString());
                Assert.Equal("1 kN", new Force(1, ForceUnit.Kilonewton).ToString());
                Assert.Equal("1 kp", new Force(1, ForceUnit.KiloPond).ToString());
                Assert.Equal("1 kipf", new Force(1, ForceUnit.KilopoundForce).ToString());
                Assert.Equal("1 MN", new Force(1, ForceUnit.Meganewton).ToString());
                Assert.Equal("1 µN", new Force(1, ForceUnit.Micronewton).ToString());
                Assert.Equal("1 mN", new Force(1, ForceUnit.Millinewton).ToString());
                Assert.Equal("1 N", new Force(1, ForceUnit.Newton).ToString());
                Assert.Equal("1 ozf", new Force(1, ForceUnit.OunceForce).ToString());
                Assert.Equal("1 pdl", new Force(1, ForceUnit.Poundal).ToString());
                Assert.Equal("1 lbf", new Force(1, ForceUnit.PoundForce).ToString());
                Assert.Equal("1 Ton", new Force(1, ForceUnit.TonneForce).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 daN", new Force(1, ForceUnit.Decanewton).ToString(swedishCulture));
            Assert.Equal("1 dyn", new Force(1, ForceUnit.Dyn).ToString(swedishCulture));
            Assert.Equal("1 kgf", new Force(1, ForceUnit.KilogramForce).ToString(swedishCulture));
            Assert.Equal("1 kN", new Force(1, ForceUnit.Kilonewton).ToString(swedishCulture));
            Assert.Equal("1 kp", new Force(1, ForceUnit.KiloPond).ToString(swedishCulture));
            Assert.Equal("1 kipf", new Force(1, ForceUnit.KilopoundForce).ToString(swedishCulture));
            Assert.Equal("1 MN", new Force(1, ForceUnit.Meganewton).ToString(swedishCulture));
            Assert.Equal("1 µN", new Force(1, ForceUnit.Micronewton).ToString(swedishCulture));
            Assert.Equal("1 mN", new Force(1, ForceUnit.Millinewton).ToString(swedishCulture));
            Assert.Equal("1 N", new Force(1, ForceUnit.Newton).ToString(swedishCulture));
            Assert.Equal("1 ozf", new Force(1, ForceUnit.OunceForce).ToString(swedishCulture));
            Assert.Equal("1 pdl", new Force(1, ForceUnit.Poundal).ToString(swedishCulture));
            Assert.Equal("1 lbf", new Force(1, ForceUnit.PoundForce).ToString(swedishCulture));
            Assert.Equal("1 Ton", new Force(1, ForceUnit.TonneForce).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 N", new Force(0.123456, ForceUnit.Newton).ToString("s1"));
                Assert.Equal("0.12 N", new Force(0.123456, ForceUnit.Newton).ToString("s2"));
                Assert.Equal("0.123 N", new Force(0.123456, ForceUnit.Newton).ToString("s3"));
                Assert.Equal("0.1235 N", new Force(0.123456, ForceUnit.Newton).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 N", new Force(0.123456, ForceUnit.Newton).ToString("s1", culture));
            Assert.Equal("0.12 N", new Force(0.123456, ForceUnit.Newton).ToString("s2", culture));
            Assert.Equal("0.123 N", new Force(0.123456, ForceUnit.Newton).ToString("s3", culture));
            Assert.Equal("0.1235 N", new Force(0.123456, ForceUnit.Newton).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentCulture()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentCulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Force)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ForceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(QuantityType.Force, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(Force.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Force.FromNewtons(1.0);
            Assert.Equal(new {Force.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Force.FromNewtons(value);
            Assert.Equal(Force.FromNewtons(-value), -quantity);
        }

    }
}
