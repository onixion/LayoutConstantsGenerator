# LayoutConstants Generator

This generator is used to generate a LayoutConstants.cs file containing padding, margin, and other spacing definitions similar to [Bootstrap 5](https://getbootstrap.com/docs/5.0/utilities/spacing/) spacing utilities. 

This tool generates two files:

- *LayoutConstants.Generated.cs*: This file contains a static class containing all spacing constants.
- *LayoutConstantsConverter.Generated.cs*: This file contains a converter class, that can convert a given string to the correct spacing constant value. You might need to adapt the converter for your needs.

This generator tool aims for the *Xamarin.Forms* framework, but the code can easily be changed to work with any other framework.

```csharp
public static class LayoutConstants
{
    /// <summary>
    /// Margin Uniform x1.
    /// </summary>
    public static readonly Thickness M1 = new Thickness(
        left:   10,
        top:    10,
        right:  10,
        bottom: 10);
        
    /// <summary>
    /// Margin Uniform x2.
    /// </summary>
    public static readonly Thickness M2 = new Thickness(
        left:   20,
        top:    20,
        right:  20,
        bottom: 20);
        
    ...
    
    /// <summary>
    /// Spacing x1.
    /// </summary>
    public const double S1 = 10.0;
    
    /// <summary>
    /// Spacing x1.
    /// </summary>
    public const double S2 = 20.0;
    
    ...
}

```

## How to use it?

Run the console application and the two files *LayoutConstants.Generated.cs* and *LayoutConstantConverter.Generated.cs* will be updated.
Make sure to check the timestamps of the generated files.
