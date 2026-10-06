// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Diagnostics;

namespace UnitsNet;

/// <summary>
///     A unit of <typeparamref name="TQuantity" />, described by its names and conversions, such as a furlong of
///     <see cref="Length" />.
/// </summary>
/// <remarks>
///     Quantities can be converted to and from the unit with
///     <see cref="QuantityExtensions.As{TQuantity}(TQuantity, UnitOf{TQuantity})" /> and
///     <see cref="QuantityInfoBase{TQuantity, TUnit, TUnitInfo}.From(QuantityValue, UnitOf{TQuantity})" />.
///     Since the unit is tied to its quantity, using it with another quantity doesn't compile.
/// </remarks>
/// <typeparam name="TQuantity">The quantity this is a unit of, such as <see cref="Length" />.</typeparam>
[DebuggerDisplay("{Name}")]
public sealed class UnitOf<TQuantity> : IUnitDefinition
    where TQuantity : IQuantity
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="UnitOf{TQuantity}" /> class.
    /// </summary>
    /// <param name="singularName">The singular name of the unit, such as "Furlong".</param>
    /// <param name="pluralName">The plural name of the unit, such as "Furlongs".</param>
    /// <param name="conversionFromBase">
    ///     The conversion coefficient from the base unit of the quantity to this unit, such as 100 for centimeters of a
    ///     length.
    /// </param>
    /// <exception cref="ArgumentNullException">
    ///     Thrown when <paramref name="singularName" /> or <paramref name="pluralName" /> is <c>null</c>.
    /// </exception>
    public UnitOf(string singularName, string pluralName, QuantityValue conversionFromBase)
        : this(singularName, pluralName, conversionFromBase, QuantityValue.Inverse(conversionFromBase))
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="UnitOf{TQuantity}" /> class.
    /// </summary>
    /// <param name="singularName">The singular name of the unit, such as "Furlong".</param>
    /// <param name="pluralName">The plural name of the unit, such as "Furlongs".</param>
    /// <param name="conversionFromBase">The conversion expression from the base unit of the quantity to this unit.</param>
    /// <param name="conversionToBase">The conversion expression from this unit to the base unit of the quantity.</param>
    /// <exception cref="ArgumentNullException">
    ///     Thrown when <paramref name="singularName" /> or <paramref name="pluralName" /> is <c>null</c>.
    /// </exception>
    public UnitOf(string singularName, string pluralName, ConversionExpression conversionFromBase, ConversionExpression conversionToBase)
    {
        Name = singularName ?? throw new ArgumentNullException(nameof(singularName));
        PluralName = pluralName ?? throw new ArgumentNullException(nameof(pluralName));
        ConversionFromBase = conversionFromBase;
        ConversionToBase = conversionToBase;
    }

    /// <summary>
    ///     The singular name of the unit, such as "Furlong".
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     The plural name of the unit, such as "Furlongs".
    /// </summary>
    public string PluralName { get; }

    /// <inheritdoc />
    public ConversionExpression ConversionFromBase { get; }

    /// <inheritdoc />
    public ConversionExpression ConversionToBase { get; }

    /// <summary>
    ///     Always <see cref="UnitsNet.BaseUnits.Undefined" />, since base units are made of the units that UnitsNet defines.
    /// </summary>
    BaseUnits IUnitDefinition.BaseUnits => BaseUnits.Undefined;

    /// <summary>
    ///     Returns the name of the unit.
    /// </summary>
    public override string ToString()
    {
        return Name;
    }
}
