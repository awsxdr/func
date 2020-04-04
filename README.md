# FunCSharp

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

FunCSharp (funk-sharp) is a library designed to expand C#'s functional programming capabilities.

## Contents

* [Usage](#usage)
  * [Options](#options)

## Usage

_This section will be filled out as functionality is added to the library._

### Options

Options represent a way of marking a value as optional. Optional items offer benefits over nullable items because they enforce checking for a value and thus remove the possibility of ending up with the dreaded `NullReferenceException`s.

```csharp
public class Example
{
    public static string GetDescription(Option<int> value) =>
        value switch
        {
            Some<int> x when x.Value > 10 => "Huge",
            Some<int> x when x.Value > 5 => "Big",
            Some<int> x when x.Value < 1 => "Tiny",
            Some<int> x when x.Value < 5 => "Small",
            Some<int> _ => "Average",
            None _ => "Empty",
            _ => "Unexpected!"
        };

    public void Test()
    {
        GetDescription(Some(11));    // "Huge"
        GetDescription(Some(8));     // "Big"
        GetDescription(None<int>()); // "Empty"
    }
}
```

The above example shows a function which expects either an integer or nothing. The `Value` property can only be retrieved once the `Option` has been cast to `Some`.

Also supported is passing values when the type isn't specified. In the below example, any type can be passed in.

```csharp
public class Example
{
    public static string GetDescription(Option value) =>
        value switch
        {
            Some<int> _ => "Number",
            Some<double> _ => "Number",
            Some<string> _ => "Text",
            Some _ => "Something else",
            None _ => "Empty",
            _ => "Unexpected!"
        };

    public void Test()
    {
        GetDescription(Some(11));      // "Number"
        GetDescription(Some(8.42));    // "Number"
        GetDescription(Some("Hello")); // "Text"
        GetDescription(Some(false));   // "Something else"
        GetDescription(None());        // "Empty"
    }
}
```