﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Xunit;
using UnitsNet.Units;

namespace UnitsNet.Tests.CustomCode
{
    public class TemperatureTests : TemperatureTestsBase
    {
        protected override double DegreesCelsiusInOneKelvin => -272.15;

        protected override double DegreesDelisleInOneKelvin => 558.2249999999999;

        protected override double DegreesFahrenheitInOneKelvin => -457.87;

        protected override double DegreesNewtonInOneKelvin => -89.8095;

        protected override double DegreesRankineInOneKelvin => 1.8;

        protected override double DegreesReaumurInOneKelvin => -217.72;

        protected override double DegreesRoemerInOneKelvin => -135.378750000;

        protected override double KelvinsInOneKelvin => 1;

        [SuppressMessage("ReSharper", "ImpureMethodCallOnReadonlyValueField",
            Justification = "R# incorrectly identifies method as impure, due to internal method calls.")]
        [Theory]
        [InlineData(TemperatureUnit.DegreeCelsius, 10, 1, "10 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, 10, 5, "2 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, 10, -10, "-1 °C")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 10, 1, "10 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 10, 5, "2 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 10, -10, "-1 °F")]
        public void DividedByTemperatureDeltaEqualsTemperature(TemperatureUnit unit, int temperatureVal, int divisor, string expected)
        {
            Temperature temperature = Temperature.From(temperatureVal, unit);

            // Act
            Temperature resultTemp = temperature.Divide(divisor, unit);

            var resultTempInUnit = resultTemp.ToUnit(unit);
            var actual = string.Format(CultureInfo.InvariantCulture, "{0:0} {1:a}", resultTempInUnit.Value, resultTempInUnit);
            Assert.Equal(expected, actual);
        }

        [SuppressMessage("ReSharper", "ImpureMethodCallOnReadonlyValueField",
            Justification = "R# incorrectly identifies method as impure, due to internal method calls.")]
        [Theory]
        [InlineData(TemperatureUnit.DegreeCelsius, 10, 0, "0 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, 10, 5, "50 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, 10, -5, "-50 °C")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 10, 0, "0 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 10, 5, "50 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 10, -5, "-50 °F")]
        public void MultiplyByTemperatureDeltaEqualsTemperature(TemperatureUnit unit, int temperatureVal, int factor, string expected)
        {
            Temperature temperature = Temperature.From(temperatureVal, unit);

            // Act
            Temperature resultTemp = temperature.Multiply(factor, unit);

            var resultTempInUnit = resultTemp.ToUnit(unit);
            var actual = string.Format(CultureInfo.InvariantCulture, "{0:0} {1:a}", resultTempInUnit.Value, resultTempInUnit);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(TemperatureUnit.DegreeCelsius, -10, 0, "-10 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, -10, 10, "0 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, -10, 20, "10 °C")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, -10, 0, "-10 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, -10, 10, "0 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, -10, 20, "10 °F")]
        public void TemperatureDeltaPlusTemperatureEqualsTemperature(TemperatureUnit unit, int deltaVal, int temperatureVal, string expected)
        {
            Temperature temperature = Temperature.From(temperatureVal, unit);
            TemperatureDelta delta = TemperatureDelta.From(deltaVal, (TemperatureDeltaUnit)Enum.Parse(typeof(TemperatureDeltaUnit), unit.ToString()));

            // Act
            Temperature resultTemp = delta + temperature;

            var resultTempInUnit = resultTemp.ToUnit(unit);
            var actual = string.Format(CultureInfo.InvariantCulture, "{0:0} {1:a}", resultTempInUnit.Value, resultTempInUnit);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(TemperatureUnit.DegreeCelsius, 20, 10, "10 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, 20, 20, "0 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, 20, 30, "-10 °C")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 20, 10, "10 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 20, 20, "0 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, 20, 30, "-10 °F")]
        public void TemperatureMinusTemperatureDeltaEqualsTemperature(TemperatureUnit unit, int temperatureVal, int deltaVal, string expected)
        {
            Temperature temperature = Temperature.From(temperatureVal, unit);
            TemperatureDelta delta = TemperatureDelta.From(deltaVal, (TemperatureDeltaUnit)Enum.Parse(typeof(TemperatureDeltaUnit), unit.ToString()));

            // Act
            Temperature resultTemp = temperature - delta;

            var resultTempInUnit = resultTemp.ToUnit(unit);
            var actual = string.Format(CultureInfo.InvariantCulture, "{0:0} {1:a}", resultTempInUnit.Value, resultTempInUnit);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(TemperatureUnit.DegreeCelsius, -10, 0, "-10 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, -10, 10, "0 °C")]
        [InlineData(TemperatureUnit.DegreeCelsius, -10, 20, "10 °C")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, -10, 0, "-10 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, -10, 10, "0 °F")]
        [InlineData(TemperatureUnit.DegreeFahrenheit, -10, 20, "10 °F")]
        public void TemperaturePlusTemperatureDeltaEqualsTemperature(TemperatureUnit unit, int temperatureVal, int deltaVal, string expected)
        {
            Temperature temperature = Temperature.From(temperatureVal, unit);
            TemperatureDelta delta = TemperatureDelta.From(deltaVal, (TemperatureDeltaUnit)Enum.Parse(typeof(TemperatureDeltaUnit), unit.ToString()));

            // Act
            Temperature resultTemp = temperature + delta;

            var resultTempInUnit = resultTemp.ToUnit(unit);
            var actual = string.Format(CultureInfo.InvariantCulture, "{0:0} {1:a}", resultTempInUnit.Value, resultTempInUnit);
            Assert.Equal(expected, actual);
        }
    }
}
