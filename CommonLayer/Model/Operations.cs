namespace CommonLayer.Model
{
    /// <summary>
    /// Enum For Length Conversion Operations. 
    /// </summary>
    public enum Length 
    {
        InchToFeet, InchToYard, FeetToInch,
        FeetToYard, YardToInch, YardToFeet  
    }

    /// <summary>
    /// Enum For Weight Conversion Operations.
    /// </summary>
    public enum Weight
    { 
        GramToKilogram, GramtoTonne, KilogramToGram,
        KilogramToTonne, TonneToGram, TonneToKilogram
    }

    /// <summary>
    /// Enum For Volume Conversion Operations.
    /// </summary>
    public enum Volume
    { 
       LitreToMillilitre, MillilitreToLitre 
    }

    /// <summary>
    /// Enum For Temperature Conversion Operations.
    /// </summary>
    public enum Temperature
    { 
        CelsiusToFahrenheit, FahrenheitToCelsius
    }
}