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
    /// Test of VitaminA.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VitaminATestsBase
    {
        protected abstract double InternationalUnitsInOneInternationalUnit { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double InternationalUnitsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VitaminA((double)0.0, VitaminAUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new VitaminA();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(VitaminAUnit.InternationalUnit, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VitaminA(double.PositiveInfinity, VitaminAUnit.InternationalUnit));
            Assert.Throws<ArgumentException>(() => new VitaminA(double.NegativeInfinity, VitaminAUnit.InternationalUnit));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VitaminA(double.NaN, VitaminAUnit.InternationalUnit));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new VitaminA(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void VitaminA_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new VitaminA(1, VitaminAUnit.InternationalUnit);

            QuantityInfo<VitaminAUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(VitaminA.Zero, quantityInfo.Zero);
            Assert.Equal("VitaminA", quantityInfo.Name);
            Assert.Equal(QuantityType.VitaminA, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<VitaminAUnit>().Except(new[] {VitaminAUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void InternationalUnitToVitaminAUnits()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, internationalunit.InternationalUnits, InternationalUnitsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = VitaminA.From(1, VitaminAUnit.InternationalUnit);
            AssertEx.EqualTolerance(1, quantity00.InternationalUnits, InternationalUnitsTolerance);
            Assert.Equal(VitaminAUnit.InternationalUnit, quantity00.Unit);

        }

        [Fact]
        public void FromInternationalUnits_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VitaminA.FromInternationalUnits(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => VitaminA.FromInternationalUnits(double.NegativeInfinity));
        }

        [Fact]
        public void FromInternationalUnits_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VitaminA.FromInternationalUnits(double.NaN));
        }

        [Fact]
        public void As()
        {
            var internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, internationalunit.As(VitaminAUnit.InternationalUnit), InternationalUnitsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var internationalunit = VitaminA.FromInternationalUnits(1);

            var internationalunitQuantity = internationalunit.ToUnit(VitaminAUnit.InternationalUnit);
            AssertEx.EqualTolerance(InternationalUnitsInOneInternationalUnit, (double)internationalunitQuantity.Value, InternationalUnitsTolerance);
            Assert.Equal(VitaminAUnit.InternationalUnit, internationalunitQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(1, VitaminA.FromInternationalUnits(internationalunit.InternationalUnits).InternationalUnits, InternationalUnitsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VitaminA v = VitaminA.FromInternationalUnits(1);
            AssertEx.EqualTolerance(-1, -v.InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, (VitaminA.FromInternationalUnits(3)-v).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, (v + v).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(10, (v*10).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(10, (10*v).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, (VitaminA.FromInternationalUnits(10)/5).InternationalUnits, InternationalUnitsTolerance);
            AssertEx.EqualTolerance(2, VitaminA.FromInternationalUnits(10)/VitaminA.FromInternationalUnits(5), InternationalUnitsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VitaminA oneInternationalUnit = VitaminA.FromInternationalUnits(1);
            VitaminA twoInternationalUnits = VitaminA.FromInternationalUnits(2);

            Assert.True(oneInternationalUnit < twoInternationalUnits);
            Assert.True(oneInternationalUnit <= twoInternationalUnits);
            Assert.True(twoInternationalUnits > oneInternationalUnit);
            Assert.True(twoInternationalUnits >= oneInternationalUnit);

            Assert.False(oneInternationalUnit > twoInternationalUnits);
            Assert.False(oneInternationalUnit >= twoInternationalUnits);
            Assert.False(twoInternationalUnits < oneInternationalUnit);
            Assert.False(twoInternationalUnits <= oneInternationalUnit);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Equal(0, internationalunit.CompareTo(internationalunit));
            Assert.True(internationalunit.CompareTo(VitaminA.Zero) > 0);
            Assert.True(VitaminA.Zero.CompareTo(internationalunit) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentException>(() => internationalunit.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentNullException>(() => internationalunit.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = VitaminA.FromInternationalUnits(1);
            var b = VitaminA.FromInternationalUnits(2);

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
            var a = VitaminA.FromInternationalUnits(1);
            var b = VitaminA.FromInternationalUnits(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = VitaminA.FromInternationalUnits(1);
            object b = VitaminA.FromInternationalUnits(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = VitaminA.FromInternationalUnits(1);
            Assert.True(v.Equals(VitaminA.FromInternationalUnits(1), InternationalUnitsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(VitaminA.Zero, InternationalUnitsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = VitaminA.FromInternationalUnits(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(VitaminA.FromInternationalUnits(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.False(internationalunit.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VitaminA internationalunit = VitaminA.FromInternationalUnits(1);
            Assert.False(internationalunit.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(VitaminAUnit.Undefined, VitaminA.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(VitaminAUnit)).Cast<VitaminAUnit>();
            foreach(var unit in units)
            {
                if(unit == VitaminAUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(VitaminA.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 IU", new VitaminA(1, VitaminAUnit.InternationalUnit).ToString());
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

            Assert.Equal("1 IU", new VitaminA(1, VitaminAUnit.InternationalUnit).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s1"));
                Assert.Equal("0.12 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s2"));
                Assert.Equal("0.123 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s3"));
                Assert.Equal("0.1235 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s4"));
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
            Assert.Equal("0.1 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s1", culture));
            Assert.Equal("0.12 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s2", culture));
            Assert.Equal("0.123 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s3", culture));
            Assert.Equal("0.1235 IU", new VitaminA(0.123456, VitaminAUnit.InternationalUnit).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentCulture()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentCulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(VitaminA)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(VitaminAUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(QuantityType.VitaminA, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(VitaminA.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = VitaminA.FromInternationalUnits(1.0);
            Assert.Equal(new {VitaminA.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = VitaminA.FromInternationalUnits(value);
            Assert.Equal(VitaminA.FromInternationalUnits(-value), -quantity);
        }

    }
}
