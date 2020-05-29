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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToDynamicViscosity
{
    /// <summary>
    /// A number to DynamicViscosity Extensions
    /// </summary>
    public static class NumberToDynamicViscosityExtensions
    {
        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(UnitsNet.QuantityValue)" />
        public static DynamicViscosity Centipoise<T>(this T value) =>
            DynamicViscosity.FromCentipoise(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromMicropascalSeconds(UnitsNet.QuantityValue)" />
        public static DynamicViscosity MicropascalSeconds<T>(this T value) =>
            DynamicViscosity.FromMicropascalSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(UnitsNet.QuantityValue)" />
        public static DynamicViscosity MillipascalSeconds<T>(this T value) =>
            DynamicViscosity.FromMillipascalSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(UnitsNet.QuantityValue)" />
        public static DynamicViscosity NewtonSecondsPerMeterSquared<T>(this T value) =>
            DynamicViscosity.FromNewtonSecondsPerMeterSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(UnitsNet.QuantityValue)" />
        public static DynamicViscosity PascalSeconds<T>(this T value) =>
            DynamicViscosity.FromPascalSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromPoise(UnitsNet.QuantityValue)" />
        public static DynamicViscosity Poise<T>(this T value) =>
            DynamicViscosity.FromPoise(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromPoundsForceSecondPerSquareFoot(UnitsNet.QuantityValue)" />
        public static DynamicViscosity PoundsForceSecondPerSquareFoot<T>(this T value) =>
            DynamicViscosity.FromPoundsForceSecondPerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromPoundsForceSecondPerSquareInch(UnitsNet.QuantityValue)" />
        public static DynamicViscosity PoundsForceSecondPerSquareInch<T>(this T value) =>
            DynamicViscosity.FromPoundsForceSecondPerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromReyns(UnitsNet.QuantityValue)" />
        public static DynamicViscosity Reyns<T>(this T value) =>
            DynamicViscosity.FromReyns(Convert.ToDouble(value));

    }
}
