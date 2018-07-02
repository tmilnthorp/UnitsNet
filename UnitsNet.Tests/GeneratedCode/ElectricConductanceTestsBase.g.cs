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
    /// Test of ElectricConductance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricConductanceTestsBase
    {
        protected abstract double MicrosiemensInOneSiemens { get; }
        protected abstract double MillisiemensInOneSiemens { get; }
        protected abstract double SiemensInOneSiemens { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double MicrosiemensTolerance { get { return 1e-5; } }
        protected virtual double MillisiemensTolerance { get { return 1e-5; } }
        protected virtual double SiemensTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void SiemensToElectricConductanceUnits()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(MicrosiemensInOneSiemens, siemens.Microsiemens, MicrosiemensTolerance);
            AssertEx.EqualTolerance(MillisiemensInOneSiemens, siemens.Millisiemens, MillisiemensTolerance);
            AssertEx.EqualTolerance(SiemensInOneSiemens, siemens.Siemens, SiemensTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricConductance.From(1, ElectricConductanceUnit.Microsiemens).Microsiemens, MicrosiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.From(1, ElectricConductanceUnit.Millisiemens).Millisiemens, MillisiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.From(1, ElectricConductanceUnit.Siemens).Siemens, SiemensTolerance);
        }

        [Fact]
        public void As()
        {
            var siemens = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(MicrosiemensInOneSiemens, siemens.As(ElectricConductanceUnit.Microsiemens), MicrosiemensTolerance);
            AssertEx.EqualTolerance(MillisiemensInOneSiemens, siemens.As(ElectricConductanceUnit.Millisiemens), MillisiemensTolerance);
            AssertEx.EqualTolerance(SiemensInOneSiemens, siemens.As(ElectricConductanceUnit.Siemens), SiemensTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var siemens = ElectricConductance.FromSiemens(1);

            var microsiemensQuantity = siemens.ToUnit(ElectricConductanceUnit.Microsiemens);
            AssertEx.EqualTolerance(MicrosiemensInOneSiemens, (double)microsiemensQuantity.Value, MicrosiemensTolerance);
            Assert.Equal(ElectricConductanceUnit.Microsiemens, microsiemensQuantity.Unit);

            var millisiemensQuantity = siemens.ToUnit(ElectricConductanceUnit.Millisiemens);
            AssertEx.EqualTolerance(MillisiemensInOneSiemens, (double)millisiemensQuantity.Value, MillisiemensTolerance);
            Assert.Equal(ElectricConductanceUnit.Millisiemens, millisiemensQuantity.Unit);

            var siemensQuantity = siemens.ToUnit(ElectricConductanceUnit.Siemens);
            AssertEx.EqualTolerance(SiemensInOneSiemens, (double)siemensQuantity.Value, SiemensTolerance);
            Assert.Equal(ElectricConductanceUnit.Siemens, siemensQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(1, ElectricConductance.FromMicrosiemens(siemens.Microsiemens).Siemens, MicrosiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.FromMillisiemens(siemens.Millisiemens).Siemens, MillisiemensTolerance);
            AssertEx.EqualTolerance(1, ElectricConductance.FromSiemens(siemens.Siemens).Siemens, SiemensTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricConductance v = ElectricConductance.FromSiemens(1);
            AssertEx.EqualTolerance(-1, -v.Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductance.FromSiemens(3)-v).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, (v + v).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(10, (v*10).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(10, (10*v).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductance.FromSiemens(10)/5).Siemens, SiemensTolerance);
            AssertEx.EqualTolerance(2, ElectricConductance.FromSiemens(10)/ElectricConductance.FromSiemens(5), SiemensTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricConductance oneSiemens = ElectricConductance.FromSiemens(1);
            ElectricConductance twoSiemens = ElectricConductance.FromSiemens(2);

            Assert.True(oneSiemens < twoSiemens);
            Assert.True(oneSiemens <= twoSiemens);
            Assert.True(twoSiemens > oneSiemens);
            Assert.True(twoSiemens >= oneSiemens);

            Assert.False(oneSiemens > twoSiemens);
            Assert.False(oneSiemens >= twoSiemens);
            Assert.False(twoSiemens < oneSiemens);
            Assert.False(twoSiemens <= oneSiemens);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.Equal(0, siemens.CompareTo(siemens));
            Assert.True(siemens.CompareTo(ElectricConductance.Zero) > 0);
            Assert.True(ElectricConductance.Zero.CompareTo(siemens) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.Throws<ArgumentException>(() => siemens.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.Throws<ArgumentNullException>(() => siemens.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricConductance a = ElectricConductance.FromSiemens(1);
            ElectricConductance b = ElectricConductance.FromSiemens(2);

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
            ElectricConductance v = ElectricConductance.FromSiemens(1);
            Assert.True(v.Equals(ElectricConductance.FromSiemens(1), ElectricConductance.FromSiemens(SiemensTolerance)));
            Assert.False(v.Equals(ElectricConductance.Zero, ElectricConductance.FromSiemens(SiemensTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.False(siemens.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricConductance siemens = ElectricConductance.FromSiemens(1);
            Assert.False(siemens.Equals(null));
        }
    }
}
