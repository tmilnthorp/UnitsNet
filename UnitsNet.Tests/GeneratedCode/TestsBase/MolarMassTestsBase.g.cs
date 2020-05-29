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
    /// Test of MolarMass.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarMassTestsBase
    {
        protected abstract double CentigramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double DecagramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double DecigramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double GramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double HectogramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double KilogramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double KilopoundsPerMoleInOneKilogramPerMole { get; }
        protected abstract double MegapoundsPerMoleInOneKilogramPerMole { get; }
        protected abstract double MicrogramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double MilligramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double NanogramsPerMoleInOneKilogramPerMole { get; }
        protected abstract double PoundsPerMoleInOneKilogramPerMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentigramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double DecagramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double DecigramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double GramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double HectogramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double MegapoundsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double NanogramsPerMoleTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerMoleTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarMass((double)0.0, MolarMassUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MolarMass();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MolarMassUnit.KilogramPerMole, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarMass(double.PositiveInfinity, MolarMassUnit.KilogramPerMole));
            Assert.Throws<ArgumentException>(() => new MolarMass(double.NegativeInfinity, MolarMassUnit.KilogramPerMole));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarMass(double.NaN, MolarMassUnit.KilogramPerMole));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MolarMass(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void MolarMass_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MolarMass(1, MolarMassUnit.KilogramPerMole);

            QuantityInfo<MolarMassUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MolarMass.Zero, quantityInfo.Zero);
            Assert.Equal("MolarMass", quantityInfo.Name);
            Assert.Equal(QuantityType.MolarMass, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<MolarMassUnit>().Except(new[] {MolarMassUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KilogramPerMoleToMolarMassUnits()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            AssertEx.EqualTolerance(CentigramsPerMoleInOneKilogramPerMole, kilogrampermole.CentigramsPerMole, CentigramsPerMoleTolerance);
            AssertEx.EqualTolerance(DecagramsPerMoleInOneKilogramPerMole, kilogrampermole.DecagramsPerMole, DecagramsPerMoleTolerance);
            AssertEx.EqualTolerance(DecigramsPerMoleInOneKilogramPerMole, kilogrampermole.DecigramsPerMole, DecigramsPerMoleTolerance);
            AssertEx.EqualTolerance(GramsPerMoleInOneKilogramPerMole, kilogrampermole.GramsPerMole, GramsPerMoleTolerance);
            AssertEx.EqualTolerance(HectogramsPerMoleInOneKilogramPerMole, kilogrampermole.HectogramsPerMole, HectogramsPerMoleTolerance);
            AssertEx.EqualTolerance(KilogramsPerMoleInOneKilogramPerMole, kilogrampermole.KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(KilopoundsPerMoleInOneKilogramPerMole, kilogrampermole.KilopoundsPerMole, KilopoundsPerMoleTolerance);
            AssertEx.EqualTolerance(MegapoundsPerMoleInOneKilogramPerMole, kilogrampermole.MegapoundsPerMole, MegapoundsPerMoleTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMoleInOneKilogramPerMole, kilogrampermole.MicrogramsPerMole, MicrogramsPerMoleTolerance);
            AssertEx.EqualTolerance(MilligramsPerMoleInOneKilogramPerMole, kilogrampermole.MilligramsPerMole, MilligramsPerMoleTolerance);
            AssertEx.EqualTolerance(NanogramsPerMoleInOneKilogramPerMole, kilogrampermole.NanogramsPerMole, NanogramsPerMoleTolerance);
            AssertEx.EqualTolerance(PoundsPerMoleInOneKilogramPerMole, kilogrampermole.PoundsPerMole, PoundsPerMoleTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MolarMass.From(1, MolarMassUnit.CentigramPerMole);
            AssertEx.EqualTolerance(1, quantity00.CentigramsPerMole, CentigramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.CentigramPerMole, quantity00.Unit);

            var quantity01 = MolarMass.From(1, MolarMassUnit.DecagramPerMole);
            AssertEx.EqualTolerance(1, quantity01.DecagramsPerMole, DecagramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.DecagramPerMole, quantity01.Unit);

            var quantity02 = MolarMass.From(1, MolarMassUnit.DecigramPerMole);
            AssertEx.EqualTolerance(1, quantity02.DecigramsPerMole, DecigramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.DecigramPerMole, quantity02.Unit);

            var quantity03 = MolarMass.From(1, MolarMassUnit.GramPerMole);
            AssertEx.EqualTolerance(1, quantity03.GramsPerMole, GramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.GramPerMole, quantity03.Unit);

            var quantity04 = MolarMass.From(1, MolarMassUnit.HectogramPerMole);
            AssertEx.EqualTolerance(1, quantity04.HectogramsPerMole, HectogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.HectogramPerMole, quantity04.Unit);

            var quantity05 = MolarMass.From(1, MolarMassUnit.KilogramPerMole);
            AssertEx.EqualTolerance(1, quantity05.KilogramsPerMole, KilogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.KilogramPerMole, quantity05.Unit);

            var quantity06 = MolarMass.From(1, MolarMassUnit.KilopoundPerMole);
            AssertEx.EqualTolerance(1, quantity06.KilopoundsPerMole, KilopoundsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.KilopoundPerMole, quantity06.Unit);

            var quantity07 = MolarMass.From(1, MolarMassUnit.MegapoundPerMole);
            AssertEx.EqualTolerance(1, quantity07.MegapoundsPerMole, MegapoundsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.MegapoundPerMole, quantity07.Unit);

            var quantity08 = MolarMass.From(1, MolarMassUnit.MicrogramPerMole);
            AssertEx.EqualTolerance(1, quantity08.MicrogramsPerMole, MicrogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.MicrogramPerMole, quantity08.Unit);

            var quantity09 = MolarMass.From(1, MolarMassUnit.MilligramPerMole);
            AssertEx.EqualTolerance(1, quantity09.MilligramsPerMole, MilligramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.MilligramPerMole, quantity09.Unit);

            var quantity10 = MolarMass.From(1, MolarMassUnit.NanogramPerMole);
            AssertEx.EqualTolerance(1, quantity10.NanogramsPerMole, NanogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.NanogramPerMole, quantity10.Unit);

            var quantity11 = MolarMass.From(1, MolarMassUnit.PoundPerMole);
            AssertEx.EqualTolerance(1, quantity11.PoundsPerMole, PoundsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.PoundPerMole, quantity11.Unit);

        }

        [Fact]
        public void FromKilogramsPerMole_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MolarMass.FromKilogramsPerMole(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MolarMass.FromKilogramsPerMole(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerMole_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MolarMass.FromKilogramsPerMole(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            AssertEx.EqualTolerance(CentigramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.CentigramPerMole), CentigramsPerMoleTolerance);
            AssertEx.EqualTolerance(DecagramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.DecagramPerMole), DecagramsPerMoleTolerance);
            AssertEx.EqualTolerance(DecigramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.DecigramPerMole), DecigramsPerMoleTolerance);
            AssertEx.EqualTolerance(GramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.GramPerMole), GramsPerMoleTolerance);
            AssertEx.EqualTolerance(HectogramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.HectogramPerMole), HectogramsPerMoleTolerance);
            AssertEx.EqualTolerance(KilogramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.KilogramPerMole), KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(KilopoundsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.KilopoundPerMole), KilopoundsPerMoleTolerance);
            AssertEx.EqualTolerance(MegapoundsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.MegapoundPerMole), MegapoundsPerMoleTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.MicrogramPerMole), MicrogramsPerMoleTolerance);
            AssertEx.EqualTolerance(MilligramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.MilligramPerMole), MilligramsPerMoleTolerance);
            AssertEx.EqualTolerance(NanogramsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.NanogramPerMole), NanogramsPerMoleTolerance);
            AssertEx.EqualTolerance(PoundsPerMoleInOneKilogramPerMole, kilogrampermole.As(MolarMassUnit.PoundPerMole), PoundsPerMoleTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogrampermole = MolarMass.FromKilogramsPerMole(1);

            var centigrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.CentigramPerMole);
            AssertEx.EqualTolerance(CentigramsPerMoleInOneKilogramPerMole, (double)centigrampermoleQuantity.Value, CentigramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.CentigramPerMole, centigrampermoleQuantity.Unit);

            var decagrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.DecagramPerMole);
            AssertEx.EqualTolerance(DecagramsPerMoleInOneKilogramPerMole, (double)decagrampermoleQuantity.Value, DecagramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.DecagramPerMole, decagrampermoleQuantity.Unit);

            var decigrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.DecigramPerMole);
            AssertEx.EqualTolerance(DecigramsPerMoleInOneKilogramPerMole, (double)decigrampermoleQuantity.Value, DecigramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.DecigramPerMole, decigrampermoleQuantity.Unit);

            var grampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.GramPerMole);
            AssertEx.EqualTolerance(GramsPerMoleInOneKilogramPerMole, (double)grampermoleQuantity.Value, GramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.GramPerMole, grampermoleQuantity.Unit);

            var hectogrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.HectogramPerMole);
            AssertEx.EqualTolerance(HectogramsPerMoleInOneKilogramPerMole, (double)hectogrampermoleQuantity.Value, HectogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.HectogramPerMole, hectogrampermoleQuantity.Unit);

            var kilogrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.KilogramPerMole);
            AssertEx.EqualTolerance(KilogramsPerMoleInOneKilogramPerMole, (double)kilogrampermoleQuantity.Value, KilogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.KilogramPerMole, kilogrampermoleQuantity.Unit);

            var kilopoundpermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.KilopoundPerMole);
            AssertEx.EqualTolerance(KilopoundsPerMoleInOneKilogramPerMole, (double)kilopoundpermoleQuantity.Value, KilopoundsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.KilopoundPerMole, kilopoundpermoleQuantity.Unit);

            var megapoundpermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.MegapoundPerMole);
            AssertEx.EqualTolerance(MegapoundsPerMoleInOneKilogramPerMole, (double)megapoundpermoleQuantity.Value, MegapoundsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.MegapoundPerMole, megapoundpermoleQuantity.Unit);

            var microgrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.MicrogramPerMole);
            AssertEx.EqualTolerance(MicrogramsPerMoleInOneKilogramPerMole, (double)microgrampermoleQuantity.Value, MicrogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.MicrogramPerMole, microgrampermoleQuantity.Unit);

            var milligrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.MilligramPerMole);
            AssertEx.EqualTolerance(MilligramsPerMoleInOneKilogramPerMole, (double)milligrampermoleQuantity.Value, MilligramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.MilligramPerMole, milligrampermoleQuantity.Unit);

            var nanogrampermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.NanogramPerMole);
            AssertEx.EqualTolerance(NanogramsPerMoleInOneKilogramPerMole, (double)nanogrampermoleQuantity.Value, NanogramsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.NanogramPerMole, nanogrampermoleQuantity.Unit);

            var poundpermoleQuantity = kilogrampermole.ToUnit(MolarMassUnit.PoundPerMole);
            AssertEx.EqualTolerance(PoundsPerMoleInOneKilogramPerMole, (double)poundpermoleQuantity.Value, PoundsPerMoleTolerance);
            Assert.Equal(MolarMassUnit.PoundPerMole, poundpermoleQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            AssertEx.EqualTolerance(1, MolarMass.FromCentigramsPerMole(kilogrampermole.CentigramsPerMole).KilogramsPerMole, CentigramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromDecagramsPerMole(kilogrampermole.DecagramsPerMole).KilogramsPerMole, DecagramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromDecigramsPerMole(kilogrampermole.DecigramsPerMole).KilogramsPerMole, DecigramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromGramsPerMole(kilogrampermole.GramsPerMole).KilogramsPerMole, GramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromHectogramsPerMole(kilogrampermole.HectogramsPerMole).KilogramsPerMole, HectogramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromKilogramsPerMole(kilogrampermole.KilogramsPerMole).KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromKilopoundsPerMole(kilogrampermole.KilopoundsPerMole).KilogramsPerMole, KilopoundsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromMegapoundsPerMole(kilogrampermole.MegapoundsPerMole).KilogramsPerMole, MegapoundsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromMicrogramsPerMole(kilogrampermole.MicrogramsPerMole).KilogramsPerMole, MicrogramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromMilligramsPerMole(kilogrampermole.MilligramsPerMole).KilogramsPerMole, MilligramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromNanogramsPerMole(kilogrampermole.NanogramsPerMole).KilogramsPerMole, NanogramsPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarMass.FromPoundsPerMole(kilogrampermole.PoundsPerMole).KilogramsPerMole, PoundsPerMoleTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MolarMass v = MolarMass.FromKilogramsPerMole(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(2, (MolarMass.FromKilogramsPerMole(3)-v).KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(2, (MolarMass.FromKilogramsPerMole(10)/5).KilogramsPerMole, KilogramsPerMoleTolerance);
            AssertEx.EqualTolerance(2, MolarMass.FromKilogramsPerMole(10)/MolarMass.FromKilogramsPerMole(5), KilogramsPerMoleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MolarMass oneKilogramPerMole = MolarMass.FromKilogramsPerMole(1);
            MolarMass twoKilogramsPerMole = MolarMass.FromKilogramsPerMole(2);

            Assert.True(oneKilogramPerMole < twoKilogramsPerMole);
            Assert.True(oneKilogramPerMole <= twoKilogramsPerMole);
            Assert.True(twoKilogramsPerMole > oneKilogramPerMole);
            Assert.True(twoKilogramsPerMole >= oneKilogramPerMole);

            Assert.False(oneKilogramPerMole > twoKilogramsPerMole);
            Assert.False(oneKilogramPerMole >= twoKilogramsPerMole);
            Assert.False(twoKilogramsPerMole < oneKilogramPerMole);
            Assert.False(twoKilogramsPerMole <= oneKilogramPerMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            Assert.Equal(0, kilogrampermole.CompareTo(kilogrampermole));
            Assert.True(kilogrampermole.CompareTo(MolarMass.Zero) > 0);
            Assert.True(MolarMass.Zero.CompareTo(kilogrampermole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            Assert.Throws<ArgumentException>(() => kilogrampermole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampermole.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MolarMass.FromKilogramsPerMole(1);
            var b = MolarMass.FromKilogramsPerMole(2);

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
            var a = MolarMass.FromKilogramsPerMole(1);
            var b = MolarMass.FromKilogramsPerMole(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = MolarMass.FromKilogramsPerMole(1);
            object b = MolarMass.FromKilogramsPerMole(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = MolarMass.FromKilogramsPerMole(1);
            Assert.True(v.Equals(MolarMass.FromKilogramsPerMole(1), KilogramsPerMoleTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MolarMass.Zero, KilogramsPerMoleTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = MolarMass.FromKilogramsPerMole(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(MolarMass.FromKilogramsPerMole(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            Assert.False(kilogrampermole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MolarMass kilogrampermole = MolarMass.FromKilogramsPerMole(1);
            Assert.False(kilogrampermole.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MolarMassUnit.Undefined, MolarMass.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MolarMassUnit)).Cast<MolarMassUnit>();
            foreach(var unit in units)
            {
                if(unit == MolarMassUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MolarMass.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cg/mol", new MolarMass(1, MolarMassUnit.CentigramPerMole).ToString());
                Assert.Equal("1 dag/mol", new MolarMass(1, MolarMassUnit.DecagramPerMole).ToString());
                Assert.Equal("1 dg/mol", new MolarMass(1, MolarMassUnit.DecigramPerMole).ToString());
                Assert.Equal("1 g/mol", new MolarMass(1, MolarMassUnit.GramPerMole).ToString());
                Assert.Equal("1 hg/mol", new MolarMass(1, MolarMassUnit.HectogramPerMole).ToString());
                Assert.Equal("1 kg/mol", new MolarMass(1, MolarMassUnit.KilogramPerMole).ToString());
                Assert.Equal("1 klb/mol", new MolarMass(1, MolarMassUnit.KilopoundPerMole).ToString());
                Assert.Equal("1 Mlb/mol", new MolarMass(1, MolarMassUnit.MegapoundPerMole).ToString());
                Assert.Equal("1 µg/mol", new MolarMass(1, MolarMassUnit.MicrogramPerMole).ToString());
                Assert.Equal("1 mg/mol", new MolarMass(1, MolarMassUnit.MilligramPerMole).ToString());
                Assert.Equal("1 ng/mol", new MolarMass(1, MolarMassUnit.NanogramPerMole).ToString());
                Assert.Equal("1 lb/mol", new MolarMass(1, MolarMassUnit.PoundPerMole).ToString());
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

            Assert.Equal("1 cg/mol", new MolarMass(1, MolarMassUnit.CentigramPerMole).ToString(swedishCulture));
            Assert.Equal("1 dag/mol", new MolarMass(1, MolarMassUnit.DecagramPerMole).ToString(swedishCulture));
            Assert.Equal("1 dg/mol", new MolarMass(1, MolarMassUnit.DecigramPerMole).ToString(swedishCulture));
            Assert.Equal("1 g/mol", new MolarMass(1, MolarMassUnit.GramPerMole).ToString(swedishCulture));
            Assert.Equal("1 hg/mol", new MolarMass(1, MolarMassUnit.HectogramPerMole).ToString(swedishCulture));
            Assert.Equal("1 kg/mol", new MolarMass(1, MolarMassUnit.KilogramPerMole).ToString(swedishCulture));
            Assert.Equal("1 klb/mol", new MolarMass(1, MolarMassUnit.KilopoundPerMole).ToString(swedishCulture));
            Assert.Equal("1 Mlb/mol", new MolarMass(1, MolarMassUnit.MegapoundPerMole).ToString(swedishCulture));
            Assert.Equal("1 µg/mol", new MolarMass(1, MolarMassUnit.MicrogramPerMole).ToString(swedishCulture));
            Assert.Equal("1 mg/mol", new MolarMass(1, MolarMassUnit.MilligramPerMole).ToString(swedishCulture));
            Assert.Equal("1 ng/mol", new MolarMass(1, MolarMassUnit.NanogramPerMole).ToString(swedishCulture));
            Assert.Equal("1 lb/mol", new MolarMass(1, MolarMassUnit.PoundPerMole).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s1"));
                Assert.Equal("0.12 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s2"));
                Assert.Equal("0.123 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s3"));
                Assert.Equal("0.1235 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s4"));
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
            Assert.Equal("0.1 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s1", culture));
            Assert.Equal("0.12 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s2", culture));
            Assert.Equal("0.123 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s3", culture));
            Assert.Equal("0.1235 kg/mol", new MolarMass(0.123456, MolarMassUnit.KilogramPerMole).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentCulture()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentCulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(MolarMass)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MolarMassUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(QuantityType.MolarMass, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(MolarMass.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = MolarMass.FromKilogramsPerMole(1.0);
            Assert.Equal(new {MolarMass.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = MolarMass.FromKilogramsPerMole(value);
            Assert.Equal(MolarMass.FromKilogramsPerMole(-value), -quantity);
        }

    }
}
