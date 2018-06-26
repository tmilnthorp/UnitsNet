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
    /// Test of SpecificVolume.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificVolumeTestsBase
    {
        protected abstract double CubicMetersPerKilogramInOneCubicMeterPerKilogram { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicMetersPerKilogramTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void CubicMeterPerKilogramToSpecificVolumeUnits()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, SpecificVolume.From(1, SpecificVolumeUnit.CubicMeterPerKilogram).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void As()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, cubicmeterperkilogram.As(SpecificVolumeUnit.CubicMeterPerKilogram), CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void AsQuantity()
        {
            var cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);

            var cubicmeterperkilogramQuantity = cubicmeterperkilogram.AsQuantity(SpecificVolumeUnit.CubicMeterPerKilogram);
            AssertEx.EqualTolerance(CubicMetersPerKilogramInOneCubicMeterPerKilogram, (double)cubicmeterperkilogramQuantity.Value, CubicMetersPerKilogramTolerance);
            Assert.Equal(SpecificVolumeUnit.CubicMeterPerKilogram, cubicmeterperkilogramQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(1, SpecificVolume.FromCubicMetersPerKilogram(cubicmeterperkilogram.CubicMetersPerKilogram).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificVolume v = SpecificVolume.FromCubicMetersPerKilogram(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(3)-v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificVolume.FromCubicMetersPerKilogram(10)/5).CubicMetersPerKilogram, CubicMetersPerKilogramTolerance);
            AssertEx.EqualTolerance(2, SpecificVolume.FromCubicMetersPerKilogram(10)/SpecificVolume.FromCubicMetersPerKilogram(5), CubicMetersPerKilogramTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificVolume oneCubicMeterPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            SpecificVolume twoCubicMetersPerKilogram = SpecificVolume.FromCubicMetersPerKilogram(2);

            Assert.True(oneCubicMeterPerKilogram < twoCubicMetersPerKilogram);
            Assert.True(oneCubicMeterPerKilogram <= twoCubicMetersPerKilogram);
            Assert.True(twoCubicMetersPerKilogram > oneCubicMeterPerKilogram);
            Assert.True(twoCubicMetersPerKilogram >= oneCubicMeterPerKilogram);

            Assert.False(oneCubicMeterPerKilogram > twoCubicMetersPerKilogram);
            Assert.False(oneCubicMeterPerKilogram >= twoCubicMetersPerKilogram);
            Assert.False(twoCubicMetersPerKilogram < oneCubicMeterPerKilogram);
            Assert.False(twoCubicMetersPerKilogram <= oneCubicMeterPerKilogram);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Equal(0, cubicmeterperkilogram.CompareTo(cubicmeterperkilogram));
            Assert.True(cubicmeterperkilogram.CompareTo(SpecificVolume.Zero) > 0);
            Assert.True(SpecificVolume.Zero.CompareTo(cubicmeterperkilogram) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentException>(() => cubicmeterperkilogram.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterperkilogram.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            SpecificVolume a = SpecificVolume.FromCubicMetersPerKilogram(1);
            SpecificVolume b = SpecificVolume.FromCubicMetersPerKilogram(2);

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
            SpecificVolume v = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.True(v.Equals(SpecificVolume.FromCubicMetersPerKilogram(1), SpecificVolume.FromCubicMetersPerKilogram(CubicMetersPerKilogramTolerance)));
            Assert.False(v.Equals(SpecificVolume.Zero, SpecificVolume.FromCubicMetersPerKilogram(CubicMetersPerKilogramTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificVolume cubicmeterperkilogram = SpecificVolume.FromCubicMetersPerKilogram(1);
            Assert.False(cubicmeterperkilogram.Equals(null));
        }
    }
}
