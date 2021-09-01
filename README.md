# Valigator
<!-- TOC -->

- [Concepts](#concepts)
    - [Value Validator](#value-validator)
    - [State Validator](#state-validator)
    - [Validation Error Format](#validation-error-format)
- [Valigator Packages](#valigator-packages)
    - [Valigator.Core](#valigatorcore)
    - [Valigator.AspNetCore](#valigatoraspnetcore)
- [Usage](#usage)
- [Random Things To Move to Better Places](#random-things-to-move-to-better-places)
    - [Custom Validations](#custom-validations)
- [Gotchas](#gotchas)

<!-- /TOC -->

Valigator is .NET suite of libraries that enabled the declaration of complex validation rules directly on model properties.

## Concepts
Valigator.AspNetCore provides a JsonConverter and attaches to the AspNetCore deserialization process.

Any model to be validated by Valigator must have the `[ValigatorModel]` attribute. This will result in any property decorated by the `Data<T>` being validated by the converter.

Usage of the `Data<T>` decorator is governed by a few rules:
- All properties must have a declared setter. This setter may be private.
- Data must be one of `Required`, `Optional`, or `Defaulted`
    - `Required` 
        - A value must be provided.
        - If a value is not provided, an error is produced.
        - Whether this is nullable or not is dictated by nullability (See XXXXX below).
        - This value is stored in `Data<T>`
        - Example: 
        ```C#
        Data<int> RequiredInt { get; set; } = Data.Required<int>().GreaterThan(1);
        ```
    - `Optional`
        - A value does not need to be provided. 
        - If a vlaue is not provided, `Option.None<T>` is produced.
        - Whether this is nullable or not is dictated by nullability (See XXXXX below).
        - This value is stored in `Data<Option<T>>`
        - Example:
        ```C#
        Data<Option<int>> OptionalInt { get; set; } = Data.Optional<int>().GreaterThan(1);
        ```
    - `Defaulted`
        - A value does not need to be provided.
        - When a value is not provided, a default value is used instead.
        - Whether this is nullable or not is dictated by nullability (See XXXXX below).
        - This value is stored in `Data<T>`
        - Example:
        ```C#
        public Data<int> DefaultedInt { get; set; } = Data.Defaulted<int>(3).GreaterThan(1);
        ```
- Nullability means that `null` is a valid input value
    - Nullable value are indicated by adding `Nullable()`.
        - Nullable Required means that a value must be provided, but it can be null.
        - Nullable Optional means that a value does not need to be provided, but if it is, it may be null.
        - Nullable Default means that a value does not need to be provided, but if it is, it may be null.
    - Nullable implies `Option<T>`
    - A nullable collection means that the collection itself may be null
    - TODO: Items Nullable Information
    - Examples:
    ```C#
    public Data<Option<int>> NullableRequiredInt { get; set; } = Data.Required<int>().Nullable().GreaterThan(1);
    ```
- Collections are defined slightly differently than regular `Data` fields.
    ```C#
    public Data<int[]> RequiredIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).Required();

    public Data<int[]> DefaultedIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).Defaulted(new[]{1, 2, 3});

    public Data<int[]> DefaultEmptyIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).DefaultedToEmpty();

    public Data<Option<int[]>> OptionalIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).Optional();
    ```
- Validating Non-`Data` Fields
Apply the `[ValidateContents]` attribute to the property or field to be validated. This will cause Valigator to run validations upon whatever object is contained in this field or property.

    Example:
    ```C#
    [ValidateContents]
    private readonly object _value;
    ```
- Any anonymous type with Valigator properties (properties of type `Data<T>`) must be converted to a `ValigatorModel<T>`. The easiest way to do this is to use the `.ToValigatorModel()` extension method from `Valigator.Newtonsoft.Json`.
    ```C#
    new { Type = "A Type", UnitCost = Data.Require<int>() }.ToValigatorModel()
    ```

When a Valigator model is deserialized, it deserializes into one of two states:
- Set - Data was provided and passes all validations
- Unset - No data was provided. This is equivalent to skipping a field. Passing in `null` is not Unset, that is either Valid or Invalid.


### Value Validator

### State Validator

### Validation Error Format

## Valigator Packages

### Valigator.Core
The core library of Valigator.

### Valigator.AspNetCore
Library specifically to make adding to an AspNetCore application easy.

## Usage
- Install the appropriate Valigator packages from the list above.
- In configure Valigator service
    ```C#
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddValigator(InputErrorHandler, OutputErrorHandler);
    }
    ```
- Add the input error handler. This handler will be run when a validation error occurs deserializing into the object.
    ```C#
    private IActionResult InputErrorHandler(Valigator.ValidationError[] errors)
        => errors.ToUnexpectedError().ToActionResult();
    ```
- Add the output error handler. This handler will be run when a validation error occurs serializing objects.
    ```C#
    private IActionResult OutputErrorHandler(ModelError[] errors)
        => errors.ToValidationError().ToActionResult();
    ```
    
## Random Things To Move to Better Places

### Custom Validations
Examples:
```C#
public Data<Option<int>> IntegerValue { get; set; } = Data.Required<int>().Nullable().Assert("A meaningful description", value => value > 1)
```

## Gotchas
1) All properties must have a setter. This setter may be `private`.

