# LayoutConstants Generator

This generator is used to generate a *LayoutConstants.cs* file containing padding, margin and other spacing definitions similar to [Bootstrap 5](https://getbootstrap.com/docs/5.0/utilities/spacing/) spacing utilities.

The tool is uses *Xamarin.Forms*.

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

Run the console application and the file *LayoutConstants.Generated.cs* inside the project will be updated.
Make sure to check the timestamp in the generated file.
