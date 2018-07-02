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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LinearDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LinearDensityTestsBase
    {
        protected abstract double GramsPerMeterInOneKilogramPerMeter { get; }
        protected abstract double KilogramsPerMeterInOneKilogramPerMeter { get; }
        protected abstract double PoundsPerFootInOneKilogramPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerFootTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void KilogramPerMeterToLinearDensityUnits()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(GramsPerMeterInOneKilogramPerMeter, kilogrampermeter.GramsPerMeter, GramsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerMeterInOneKilogramPerMeter, kilogrampermeter.KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(PoundsPerFootInOneKilogramPerMeter, kilogrampermeter.PoundsPerFoot, PoundsPerFootTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, LinearDensity.From(1, LinearDensityUnit.GramPerMeter).GramsPerMeter, GramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.From(1, LinearDensityUnit.KilogramPerMeter).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.From(1, LinearDensityUnit.PoundPerFoot).PoundsPerFoot, PoundsPerFootTolerance);
        }

        [Fact]
        public void As()
        {
            var kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(GramsPerMeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.GramPerMeter), GramsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerMeterInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.KilogramPerMeter), KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(PoundsPerFootInOneKilogramPerMeter, kilogrampermeter.As(LinearDensityUnit.PoundPerFoot), PoundsPerFootTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);

            var grampermeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.GramPerMeter);
            AssertEx.EqualTolerance(GramsPerMeterInOneKilogramPerMeter, (double)grampermeterQuantity.Value, GramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.GramPerMeter, grampermeterQuantity.Unit);

            var kilogrampermeterQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.KilogramPerMeter);
            AssertEx.EqualTolerance(KilogramsPerMeterInOneKilogramPerMeter, (double)kilogrampermeterQuantity.Value, KilogramsPerMeterTolerance);
            Assert.Equal(LinearDensityUnit.KilogramPerMeter, kilogrampermeterQuantity.Unit);

            var poundperfootQuantity = kilogrampermeter.ToUnit(LinearDensityUnit.PoundPerFoot);
            AssertEx.EqualTolerance(PoundsPerFootInOneKilogramPerMeter, (double)poundperfootQuantity.Value, PoundsPerFootTolerance);
            Assert.Equal(LinearDensityUnit.PoundPerFoot, poundperfootQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(1, LinearDensity.FromGramsPerMeter(kilogrampermeter.GramsPerMeter).KilogramsPerMeter, GramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromKilogramsPerMeter(kilogrampermeter.KilogramsPerMeter).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(1, LinearDensity.FromPoundsPerFoot(kilogrampermeter.PoundsPerFoot).KilogramsPerMeter, PoundsPerFootTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LinearDensity v = LinearDensity.FromKilogramsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (LinearDensity.FromKilogramsPerMeter(3)-v).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (LinearDensity.FromKilogramsPerMeter(10)/5).KilogramsPerMeter, KilogramsPerMeterTolerance);
            AssertEx.EqualTolerance(2, LinearDensity.FromKilogramsPerMeter(10)/LinearDensity.FromKilogramsPerMeter(5), KilogramsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LinearDensity oneKilogramPerMeter = LinearDensity.FromKilogramsPerMeter(1);
            LinearDensity twoKilogramsPerMeter = LinearDensity.FromKilogramsPerMeter(2);

            Assert.True(oneKilogramPerMeter < twoKilogramsPerMeter);
            Assert.True(oneKilogramPerMeter <= twoKilogramsPerMeter);
            Assert.True(twoKilogramsPerMeter > oneKilogramPerMeter);
            Assert.True(twoKilogramsPerMeter >= oneKilogramPerMeter);

            Assert.False(oneKilogramPerMeter > twoKilogramsPerMeter);
            Assert.False(oneKilogramPerMeter >= twoKilogramsPerMeter);
            Assert.False(twoKilogramsPerMeter < oneKilogramPerMeter);
            Assert.False(twoKilogramsPerMeter <= oneKilogramPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.Equal(0, kilogrampermeter.CompareTo(kilogrampermeter));
            Assert.True(kilogrampermeter.CompareTo(LinearDensity.Zero) > 0);
            Assert.True(LinearDensity.Zero.CompareTo(kilogrampermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampermeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            LinearDensity a = LinearDensity.FromKilogramsPerMeter(1);
            LinearDensity b = LinearDensity.FromKilogramsPerMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            LinearDensity v = LinearDensity.FromKilogramsPerMeter(1);
            Assert.True(v.Equals(LinearDensity.FromKilogramsPerMeter(1), LinearDensity.FromKilogramsPerMeter(KilogramsPerMeterTolerance)));
            Assert.False(v.Equals(LinearDensity.Zero, LinearDensity.FromKilogramsPerMeter(KilogramsPerMeterTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.False(kilogrampermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LinearDensity kilogrampermeter = LinearDensity.FromKilogramsPerMeter(1);
            Assert.False(kilogrampermeter.Equals(null));
        }
    }
}
