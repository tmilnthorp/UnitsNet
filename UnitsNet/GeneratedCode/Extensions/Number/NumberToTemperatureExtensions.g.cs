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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToTemperature
{
    public static class NumberToTemperatureExtensions
    {
        #region DegreeCelsius

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(UnitsNet.QuantityValue)" />
        public static Temperature DegreesCelsius<T>(this T value) => Temperature.FromDegreesCelsius(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesCelsius(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesCelsius<T>(this T? value) where T : struct => Temperature.FromDegreesCelsius(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeDelisle

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(UnitsNet.QuantityValue)" />
        public static Temperature DegreesDelisle<T>(this T value) => Temperature.FromDegreesDelisle(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesDelisle(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesDelisle<T>(this T? value) where T : struct => Temperature.FromDegreesDelisle(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeFahrenheit

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(UnitsNet.QuantityValue)" />
        public static Temperature DegreesFahrenheit<T>(this T value) => Temperature.FromDegreesFahrenheit(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesFahrenheit(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesFahrenheit<T>(this T? value) where T : struct => Temperature.FromDegreesFahrenheit(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeNewton

        /// <inheritdoc cref="Temperature.FromDegreesNewton(UnitsNet.QuantityValue)" />
        public static Temperature DegreesNewton<T>(this T value) => Temperature.FromDegreesNewton(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesNewton(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesNewton<T>(this T? value) where T : struct => Temperature.FromDegreesNewton(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeRankine

        /// <inheritdoc cref="Temperature.FromDegreesRankine(UnitsNet.QuantityValue)" />
        public static Temperature DegreesRankine<T>(this T value) => Temperature.FromDegreesRankine(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesRankine(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesRankine<T>(this T? value) where T : struct => Temperature.FromDegreesRankine(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeReaumur

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(UnitsNet.QuantityValue)" />
        public static Temperature DegreesReaumur<T>(this T value) => Temperature.FromDegreesReaumur(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesReaumur(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesReaumur<T>(this T? value) where T : struct => Temperature.FromDegreesReaumur(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeRoemer

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(UnitsNet.QuantityValue)" />
        public static Temperature DegreesRoemer<T>(this T value) => Temperature.FromDegreesRoemer(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromDegreesRoemer(UnitsNet.QuantityValue)" />
        public static Temperature? DegreesRoemer<T>(this T? value) where T : struct => Temperature.FromDegreesRoemer(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kelvin

        /// <inheritdoc cref="Temperature.FromKelvins(UnitsNet.QuantityValue)" />
        public static Temperature Kelvins<T>(this T value) => Temperature.FromKelvins(Convert.ToDouble(value));

        /// <inheritdoc cref="Temperature.FromKelvins(UnitsNet.QuantityValue)" />
        public static Temperature? Kelvins<T>(this T? value) where T : struct => Temperature.FromKelvins(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
