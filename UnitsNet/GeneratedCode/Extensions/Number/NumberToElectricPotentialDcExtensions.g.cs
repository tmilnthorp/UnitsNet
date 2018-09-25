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
namespace UnitsNet.Extensions.NumberToElectricPotentialDc
{
    public static class NumberToElectricPotentialDcExtensions
    {
        #region KilovoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc KilovoltsDc<T>(this T value) => ElectricPotentialDc.FromKilovoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromKilovoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc? KilovoltsDc<T>(this T? value) where T : struct => ElectricPotentialDc.FromKilovoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegavoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc MegavoltsDc<T>(this T value) => ElectricPotentialDc.FromMegavoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMegavoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc? MegavoltsDc<T>(this T? value) where T : struct => ElectricPotentialDc.FromMegavoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrovoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc MicrovoltsDc<T>(this T value) => ElectricPotentialDc.FromMicrovoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMicrovoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc? MicrovoltsDc<T>(this T? value) where T : struct => ElectricPotentialDc.FromMicrovoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillivoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc MillivoltsDc<T>(this T value) => ElectricPotentialDc.FromMillivoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromMillivoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc? MillivoltsDc<T>(this T? value) where T : struct => ElectricPotentialDc.FromMillivoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region VoltDc

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc VoltsDc<T>(this T value) => ElectricPotentialDc.FromVoltsDc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialDc.FromVoltsDc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialDc? VoltsDc<T>(this T? value) where T : struct => ElectricPotentialDc.FromVoltsDc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
