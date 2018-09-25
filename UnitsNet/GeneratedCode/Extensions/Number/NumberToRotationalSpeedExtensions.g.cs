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
namespace UnitsNet.Extensions.NumberToRotationalSpeed
{
    public static class NumberToRotationalSpeedExtensions
    {
        #region CentiradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed CentiradiansPerSecond<T>(this T value) => RotationalSpeed.FromCentiradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromCentiradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? CentiradiansPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromCentiradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DeciradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DeciradiansPerSecond<T>(this T value) => RotationalSpeed.FromDeciradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromDeciradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DeciradiansPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromDeciradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreePerMinute

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerMinute<T>(this T value) => RotationalSpeed.FromDegreesPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerMinute<T>(this T? value) where T : struct => RotationalSpeed.FromDegreesPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed DegreesPerSecond<T>(this T value) => RotationalSpeed.FromDegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromDegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? DegreesPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromDegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrodegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicrodegreesPerSecond<T>(this T value) => RotationalSpeed.FromMicrodegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMicrodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicrodegreesPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromMicrodegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicroradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MicroradiansPerSecond<T>(this T value) => RotationalSpeed.FromMicroradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMicroradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MicroradiansPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromMicroradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillidegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MillidegreesPerSecond<T>(this T value) => RotationalSpeed.FromMillidegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMillidegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MillidegreesPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromMillidegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilliradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed MilliradiansPerSecond<T>(this T value) => RotationalSpeed.FromMilliradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromMilliradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? MilliradiansPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromMilliradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanodegreePerSecond

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanodegreesPerSecond<T>(this T value) => RotationalSpeed.FromNanodegreesPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromNanodegreesPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanodegreesPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromNanodegreesPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanoradianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed NanoradiansPerSecond<T>(this T value) => RotationalSpeed.FromNanoradiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromNanoradiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? NanoradiansPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromNanoradiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RadianPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RadiansPerSecond<T>(this T value) => RotationalSpeed.FromRadiansPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromRadiansPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RadiansPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromRadiansPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RevolutionPerMinute

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerMinute<T>(this T value) => RotationalSpeed.FromRevolutionsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerMinute(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerMinute<T>(this T? value) where T : struct => RotationalSpeed.FromRevolutionsPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RevolutionPerSecond

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed RevolutionsPerSecond<T>(this T value) => RotationalSpeed.FromRevolutionsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalSpeed.FromRevolutionsPerSecond(UnitsNet.QuantityValue)" />
        public static RotationalSpeed? RevolutionsPerSecond<T>(this T? value) where T : struct => RotationalSpeed.FromRevolutionsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
