﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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

namespace UnitsNet
{
    public partial struct VolumeFlow
    {
        public static Volume operator *(VolumeFlow volumeFlow, TimeSpan timeSpan)
        {
            return Volume.FromCubicMeters(volumeFlow.CubicMetersPerSecond * timeSpan.TotalSeconds);
        }

        public static Volume operator *(VolumeFlow volumeFlow, Duration duration)
        {
            return Volume.FromCubicMeters(volumeFlow.CubicMetersPerSecond * duration.Seconds);
        }

        public static Speed operator /(VolumeFlow volumeFlow, Area area)
        {
            return Speed.FromMetersPerSecond(volumeFlow.CubicMetersPerSecond / area.SquareMeters);
        }

        public static Area operator /(VolumeFlow volumeFlow, Speed speed)
        {
            return Area.FromSquareMeters(volumeFlow.CubicMetersPerSecond / speed.MetersPerSecond);
        }

        public static MassFlow operator *(VolumeFlow volumeFlow, Density density)
        {
            return MassFlow.FromKilogramsPerSecond(volumeFlow.CubicMetersPerSecond * density.KilogramsPerCubicMeter);
        }

        public static MassFlow operator *(Density density, VolumeFlow volumeFlow)
        {
            return MassFlow.FromKilogramsPerSecond(volumeFlow.CubicMetersPerSecond * density.KilogramsPerCubicMeter);
        }
    }
}
