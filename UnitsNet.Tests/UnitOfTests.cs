// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests;

public class UnitOfTests
{
    // 1 furlong = 201.168 m, so there are 1000/201168 furlongs in a meter.
    private static readonly UnitOf<Length> Furlong = new("Furlong", "Furlongs", BaseUnits.Undefined, QuantityValue.FromTerms(1000, 201168));

    // Same conversions as TemperatureUnit.DegreeFahrenheit, to compare against.
    private static readonly UnitOf<Temperature> Fahrenheit = new("Fahrenheit", "Fahrenheits", BaseUnits.Undefined,
        new ConversionExpression(coefficient: QuantityValue.FromTerms(9, 5), constantTerm: QuantityValue.FromTerms(-45967, 100)),
        new ConversionExpression(coefficient: QuantityValue.FromTerms(5, 9), constantTerm: QuantityValue.FromTerms(45967, 180)));

    [Fact]
    public void Constructor_WithCoefficient_DerivesTheInverseConversion()
    {
        Assert.Equal("Furlong", Furlong.Name);
        Assert.Equal("Furlongs", Furlong.PluralName);
        Assert.Equal(BaseUnits.Undefined, Furlong.BaseUnits);
        Assert.Equal(QuantityValue.FromTerms(1000, 201168), Furlong.ConversionFromBase.Evaluate(QuantityValue.One));
        Assert.Equal(QuantityValue.FromTerms(201168, 1000), Furlong.ConversionToBase.Evaluate(QuantityValue.One));
    }

    [Fact]
    public void Constructor_WithNullArguments_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new UnitOf<Length>(null!, "Furlongs", BaseUnits.Undefined, 1));
        Assert.Throws<ArgumentNullException>(() => new UnitOf<Length>("Furlong", null!, BaseUnits.Undefined, 1));
        Assert.Throws<ArgumentNullException>(() => new UnitOf<Length>("Furlong", "Furlongs", null!, 1));
    }

    [Fact]
    public void ToString_ReturnsName()
    {
        Assert.Equal("Furlong", Furlong.ToString());
    }

    [Fact]
    public void As_ReturnsValueInThatUnit()
    {
        Assert.Equal(QuantityValue.One, Length.FromFeet(660).As(Furlong));
        Assert.Equal(new QuantityValue(8), Length.FromMiles(1).As(Furlong));
    }

    [Fact]
    public void As_AffineUnit_ReturnsValueInThatUnit()
    {
        Temperature temperature = Temperature.FromDegreesCelsius(37);

        Assert.Equal(temperature.DegreesFahrenheit, temperature.As(Fahrenheit));
    }

    [Fact]
    public void As_NullUnit_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Length.FromMeters(1).As((UnitOf<Length>)null!));
    }

    [Fact]
    public void From_ReturnsQuantityInBaseUnit()
    {
        Length length = Length.Info.From(2, Furlong);

        Assert.Equal(LengthUnit.Meter, length.Unit);
        Assert.Equal(QuantityValue.FromTerms(402336, 1000), length.Value);
    }

    [Fact]
    public void From_AffineUnit_ReturnsQuantityInBaseUnit()
    {
        Temperature temperature = Temperature.Info.From(QuantityValue.FromTerms(986, 10), Fahrenheit);

        Assert.Equal(Temperature.BaseUnit, temperature.Unit);
        Assert.Equal(Temperature.FromDegreesFahrenheit(QuantityValue.FromTerms(986, 10)).Kelvins, temperature.Value);
    }

    [Fact]
    public void From_RoundTripsWithAs()
    {
        Assert.Equal(new QuantityValue(42), Length.Info.From(42, Furlong).As(Furlong));
    }

    [Fact]
    public void From_NullUnit_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => Length.Info.From(1, (UnitOf<Length>)null!));
    }
}
