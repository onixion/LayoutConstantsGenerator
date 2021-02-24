# LayoutConstantsGenerator

This generator is used to generate a *LayoutConstants.cs* file containing padding and margin definitions similar to [Bootstraps](https://getbootstrap.com/docs/4.0/utilities/spacing/) spacing utilities.

```csharp
public static class LayoutConstants
{
    ///<summary>
    /// Margin Uniform x1.
    ///</summary>
    public const Thickness M1 = new Thickness(
        left:   10,
        top:    10,
        right:  10,
        bottom: 10);
        
    ///<summary>
    /// Margin Uniform x2.
    ///</summary>
    public const Thickness M2 = new Thickness(
        left:   20,
        top:    20,
        right:  20,
        bottom: 20);
        
    ...
}

```
