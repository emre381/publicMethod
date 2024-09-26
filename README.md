
---

# Public Method and Property Example in C#

## Description

This program demonstrates the use of public methods and properties in C#. It defines a class `Insan` (Human) with attributes like `isim` (name) and `yas` (age), as well as methods to change and retrieve these attributes, and to simulate a walking action.

## Features

- Public properties to store and manage an individual's name and age.
- Methods to modify and display the properties.
- A method to simulate a simple action (walking) for the individual.

## Requirements

- .NET SDK (Core or Framework) installed on your machine.

## Usage

1. Clone or download the repository to your local machine.
2. Open the project in your preferred C# IDE (like Visual Studio or Visual Studio Code).
3. Build the project.
4. Run the application to see the public methods and properties in action.

## Code Explanation

### Class: `Insan`

- **Attributes**:
  - `public string isim`: Holds the name of the person.
  - `public int yas`: Holds the age of the person.

- **Methods**:
  - `yurume()`: Prints "Yürüyor" (Walking) to the console, simulating a walking action.
  - `isimVeYasDegistirme(string isim, int yas)`: Allows changing the `isim` (name) and `yas` (age) properties of the `Insan` instance.
  - `isimVeYasiSoyle()`: Returns a string combining the person's `isim` and `yas`.

### Main Method

1. An object `i1` of the `Insan` class is created.
2. The method `isimVeYasDegistirme("Emre Çınar", 54)` is called to set the name to "Emre Çınar" and age to 54.
3. The method `isimVeYasiSoyle()` is called to display the name and age of the individual.
4. The method `yurume()` is invoked to simulate the walking action.

## Example

Here is an example output of the program:

```
Emre Çınar 54
Yürüyor.
```

## License

This project is open-source and available under the MIT License.

---

