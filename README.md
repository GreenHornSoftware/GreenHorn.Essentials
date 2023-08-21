## GreenHorn.Essentials
A .NET Library With Utility Classes, Methods and common functionality to be used across multiple projects and project types.

## Motivation
Application development tends to be reliant on common or repetative system of logic or `core copentency`. The motivation behind this library is to provide a single source of common functionality in a single tested and testable location that can be used across a myrid of application projects.
 

## Code style
[![js-standard-style](https://img.shields.io/badge/code%20style-standard-brightgreen.svg?style=flat)](https://github.com/feross/standard)
 

## Tech/framework used

<b>Built with</b>
-C# 
-.Net Framework 4.0

<b>Test Framework with</b>
-C# 
-.Net Framework 4.5

## Features
Generic Retry Logic.

```csharp
GreenHorn.Essentials.Core Essentials = new GreenHorn.Essentials.Core();

var result = Essentials.Retry(() => {
    return GetValueFrom(8, 2);
}, new RetryInfo() {
    Attempts = 2,
    Timeout = 30,
    WaitTime = 50
});

public double GetValueFrom(double one, double two) => (one * two);
//Results 16
```
## Code Example
usage: 

`C#`

```csharp
var result = new GreenHorn.Essentials.Core().Retry(() => {
    return GetValueFrom(8, 2);
}, new RetryInfo() {
    Attempts = 2,
    Timeout = 30,
    WaitTime = 50
});
```



[//]: # (## Installation)
[//]: # (Provide step by step series of examples and explanations about how to get a development env running.)

[//]: # (## API Reference)

[//]: # (Depending on the size of the project, if it is small and simple enough the reference docs can be added to the README. For medium size to larger projects it is important to at least provide a link to where the API reference docs live.)

## Tests
Tests have been created as part of the GreenHorn project using the Microsoft Testing Framework.

Example: 

```csharp
[TestMethod]
public void Core_Retry_pass_in_primitive_return_type_method_returns_primitive_value()
{
    var result = _core.Retry(GetName, new RetryInfo());

    Assert.AreEqual(
        expected: "Name",
        actual: result);
}
```


## How to use?

1. Start by cloning this project into Visual Studio. 
2. Build the project. 
3. Copy the resulting GreenHorn.Essentials into your client prject. 
4. Add a reference to the GreenHorn.Essentials.dll.
5. Implment needed logic based on above `Code Example`.

## Contribute

Contributions are always welcome!
 
### Contribution Guidelines
Please ensure your pull request adheres to the following guidelines:

- Alphabetize your entry.
- Search previous suggestions before making a new one, as yours may be a duplicate.
- Suggested READMEs should be beautiful or stand out in some way.
- Make an individual pull request for each suggestion.
- New categories, or improvements to the existing categorization are welcome.
- Keep descriptions short and simple, but descriptive.
- Start the description with a capital and end with a full stop/period.
- Check your spelling and grammar.
- Make sure your text editor is set to remove trailing whitespace.

Thank you for your suggestions!

## License
[![GitHub license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/GreenHornSoftware/GreenHorn.Essentials/blob/master/LICENSE)

