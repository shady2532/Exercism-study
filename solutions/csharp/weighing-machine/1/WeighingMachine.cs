using System;
using System.Globalization;
class WeighingMachine(int precision)
{
    // TODO: define the 'Precision' property
    public int Precision { get; private set; } = precision;
    // TODO: define the 'Weight' property
    private double _weight;

    public double Weight
    {
        get => _weight;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _weight = value;
        }
    }
    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get
        {
            var format = new NumberFormatInfo() { NumberDecimalDigits = this.Precision };
            var weightString = (this.Weight - this.TareAdjustment).ToString("f", format);
            return $"{weightString} kg";
        }
    }
    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; } = 5.0;

}
