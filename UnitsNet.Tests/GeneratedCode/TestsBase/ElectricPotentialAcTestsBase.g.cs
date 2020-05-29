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
    /// Test of ElectricPotentialAc.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricPotentialAcTestsBase
    {
        protected abstract double KilovoltsAcInOneVoltAc { get; }
        protected abstract double MegavoltsAcInOneVoltAc { get; }
        protected abstract double MicrovoltsAcInOneVoltAc { get; }
        protected abstract double MillivoltsAcInOneVoltAc { get; }
        protected abstract double VoltsAcInOneVoltAc { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltsAcTolerance { get { return 1e-5; } }
        protected virtual double MegavoltsAcTolerance { get { return 1e-5; } }
        protected virtual double MicrovoltsAcTolerance { get { return 1e-5; } }
        protected virtual double MillivoltsAcTolerance { get { return 1e-5; } }
        protected virtual double VoltsAcTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotentialAc((double)0.0, ElectricPotentialAcUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricPotentialAc();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricPotentialAcUnit.VoltAc, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotentialAc(double.PositiveInfinity, ElectricPotentialAcUnit.VoltAc));
            Assert.Throws<ArgumentException>(() => new ElectricPotentialAc(double.NegativeInfinity, ElectricPotentialAcUnit.VoltAc));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricPotentialAc(double.NaN, ElectricPotentialAcUnit.VoltAc));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricPotentialAc(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void ElectricPotentialAc_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricPotentialAc(1, ElectricPotentialAcUnit.VoltAc);

            QuantityInfo<ElectricPotentialAcUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricPotentialAc.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricPotentialAc", quantityInfo.Name);
            Assert.Equal(QuantityType.ElectricPotentialAc, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ElectricPotentialAcUnit>().Except(new[] {ElectricPotentialAcUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void VoltAcToElectricPotentialAcUnits()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(KilovoltsAcInOneVoltAc, voltac.KilovoltsAc, KilovoltsAcTolerance);
            AssertEx.EqualTolerance(MegavoltsAcInOneVoltAc, voltac.MegavoltsAc, MegavoltsAcTolerance);
            AssertEx.EqualTolerance(MicrovoltsAcInOneVoltAc, voltac.MicrovoltsAc, MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(MillivoltsAcInOneVoltAc, voltac.MillivoltsAc, MillivoltsAcTolerance);
            AssertEx.EqualTolerance(VoltsAcInOneVoltAc, voltac.VoltsAc, VoltsAcTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricPotentialAc.From(1, ElectricPotentialAcUnit.KilovoltAc);
            AssertEx.EqualTolerance(1, quantity00.KilovoltsAc, KilovoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.KilovoltAc, quantity00.Unit);

            var quantity01 = ElectricPotentialAc.From(1, ElectricPotentialAcUnit.MegavoltAc);
            AssertEx.EqualTolerance(1, quantity01.MegavoltsAc, MegavoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MegavoltAc, quantity01.Unit);

            var quantity02 = ElectricPotentialAc.From(1, ElectricPotentialAcUnit.MicrovoltAc);
            AssertEx.EqualTolerance(1, quantity02.MicrovoltsAc, MicrovoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MicrovoltAc, quantity02.Unit);

            var quantity03 = ElectricPotentialAc.From(1, ElectricPotentialAcUnit.MillivoltAc);
            AssertEx.EqualTolerance(1, quantity03.MillivoltsAc, MillivoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MillivoltAc, quantity03.Unit);

            var quantity04 = ElectricPotentialAc.From(1, ElectricPotentialAcUnit.VoltAc);
            AssertEx.EqualTolerance(1, quantity04.VoltsAc, VoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.VoltAc, quantity04.Unit);

        }

        [Fact]
        public void FromVoltsAc_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricPotentialAc.FromVoltsAc(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricPotentialAc.FromVoltsAc(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltsAc_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricPotentialAc.FromVoltsAc(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltac = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(KilovoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.KilovoltAc), KilovoltsAcTolerance);
            AssertEx.EqualTolerance(MegavoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.MegavoltAc), MegavoltsAcTolerance);
            AssertEx.EqualTolerance(MicrovoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.MicrovoltAc), MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(MillivoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.MillivoltAc), MillivoltsAcTolerance);
            AssertEx.EqualTolerance(VoltsAcInOneVoltAc, voltac.As(ElectricPotentialAcUnit.VoltAc), VoltsAcTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var voltac = ElectricPotentialAc.FromVoltsAc(1);

            var kilovoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.KilovoltAc);
            AssertEx.EqualTolerance(KilovoltsAcInOneVoltAc, (double)kilovoltacQuantity.Value, KilovoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.KilovoltAc, kilovoltacQuantity.Unit);

            var megavoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.MegavoltAc);
            AssertEx.EqualTolerance(MegavoltsAcInOneVoltAc, (double)megavoltacQuantity.Value, MegavoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MegavoltAc, megavoltacQuantity.Unit);

            var microvoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.MicrovoltAc);
            AssertEx.EqualTolerance(MicrovoltsAcInOneVoltAc, (double)microvoltacQuantity.Value, MicrovoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MicrovoltAc, microvoltacQuantity.Unit);

            var millivoltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.MillivoltAc);
            AssertEx.EqualTolerance(MillivoltsAcInOneVoltAc, (double)millivoltacQuantity.Value, MillivoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.MillivoltAc, millivoltacQuantity.Unit);

            var voltacQuantity = voltac.ToUnit(ElectricPotentialAcUnit.VoltAc);
            AssertEx.EqualTolerance(VoltsAcInOneVoltAc, (double)voltacQuantity.Value, VoltsAcTolerance);
            Assert.Equal(ElectricPotentialAcUnit.VoltAc, voltacQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromKilovoltsAc(voltac.KilovoltsAc).VoltsAc, KilovoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromMegavoltsAc(voltac.MegavoltsAc).VoltsAc, MegavoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromMicrovoltsAc(voltac.MicrovoltsAc).VoltsAc, MicrovoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromMillivoltsAc(voltac.MillivoltsAc).VoltsAc, MillivoltsAcTolerance);
            AssertEx.EqualTolerance(1, ElectricPotentialAc.FromVoltsAc(voltac.VoltsAc).VoltsAc, VoltsAcTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricPotentialAc v = ElectricPotentialAc.FromVoltsAc(1);
            AssertEx.EqualTolerance(-1, -v.VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialAc.FromVoltsAc(3)-v).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, (ElectricPotentialAc.FromVoltsAc(10)/5).VoltsAc, VoltsAcTolerance);
            AssertEx.EqualTolerance(2, ElectricPotentialAc.FromVoltsAc(10)/ElectricPotentialAc.FromVoltsAc(5), VoltsAcTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricPotentialAc oneVoltAc = ElectricPotentialAc.FromVoltsAc(1);
            ElectricPotentialAc twoVoltsAc = ElectricPotentialAc.FromVoltsAc(2);

            Assert.True(oneVoltAc < twoVoltsAc);
            Assert.True(oneVoltAc <= twoVoltsAc);
            Assert.True(twoVoltsAc > oneVoltAc);
            Assert.True(twoVoltsAc >= oneVoltAc);

            Assert.False(oneVoltAc > twoVoltsAc);
            Assert.False(oneVoltAc >= twoVoltsAc);
            Assert.False(twoVoltsAc < oneVoltAc);
            Assert.False(twoVoltsAc <= oneVoltAc);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Equal(0, voltac.CompareTo(voltac));
            Assert.True(voltac.CompareTo(ElectricPotentialAc.Zero) > 0);
            Assert.True(ElectricPotentialAc.Zero.CompareTo(voltac) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Throws<ArgumentException>(() => voltac.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Throws<ArgumentNullException>(() => voltac.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricPotentialAc.FromVoltsAc(1);
            var b = ElectricPotentialAc.FromVoltsAc(2);

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
            var a = ElectricPotentialAc.FromVoltsAc(1);
            var b = ElectricPotentialAc.FromVoltsAc(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ElectricPotentialAc.FromVoltsAc(1);
            object b = ElectricPotentialAc.FromVoltsAc(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricPotentialAc.FromVoltsAc(1);
            Assert.True(v.Equals(ElectricPotentialAc.FromVoltsAc(1), VoltsAcTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricPotentialAc.Zero, VoltsAcTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricPotentialAc.FromVoltsAc(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricPotentialAc.FromVoltsAc(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.False(voltac.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricPotentialAc voltac = ElectricPotentialAc.FromVoltsAc(1);
            Assert.False(voltac.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricPotentialAcUnit.Undefined, ElectricPotentialAc.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricPotentialAcUnit)).Cast<ElectricPotentialAcUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricPotentialAcUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricPotentialAc.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.KilovoltAc).ToString());
                Assert.Equal("1 MVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.MegavoltAc).ToString());
                Assert.Equal("1 µVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.MicrovoltAc).ToString());
                Assert.Equal("1 mVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.MillivoltAc).ToString());
                Assert.Equal("1 Vac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.VoltAc).ToString());
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

            Assert.Equal("1 kVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.KilovoltAc).ToString(swedishCulture));
            Assert.Equal("1 MVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.MegavoltAc).ToString(swedishCulture));
            Assert.Equal("1 µVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.MicrovoltAc).ToString(swedishCulture));
            Assert.Equal("1 mVac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.MillivoltAc).ToString(swedishCulture));
            Assert.Equal("1 Vac", new ElectricPotentialAc(1, ElectricPotentialAcUnit.VoltAc).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s1"));
                Assert.Equal("0.12 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s2"));
                Assert.Equal("0.123 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s3"));
                Assert.Equal("0.1235 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s4"));
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
            Assert.Equal("0.1 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s1", culture));
            Assert.Equal("0.12 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s2", culture));
            Assert.Equal("0.123 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s3", culture));
            Assert.Equal("0.1235 Vac", new ElectricPotentialAc(0.123456, ElectricPotentialAcUnit.VoltAc).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentCulture()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentCulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricPotentialAc)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricPotentialAcUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(QuantityType.ElectricPotentialAc, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(ElectricPotentialAc.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(1.0);
            Assert.Equal(new {ElectricPotentialAc.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricPotentialAc.FromVoltsAc(value);
            Assert.Equal(ElectricPotentialAc.FromVoltsAc(-value), -quantity);
        }

    }
}
