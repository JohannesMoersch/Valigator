# Valigator
<!-- TOC -->

- [Concepts](#concepts)
    - [Value Validator](#value-validator)
    - [State Validator](#state-validator)
    - [Validation Error Format](#validation-error-format)
- [Valigator.Core](#valigatorcore)
- [Valigator.AspNetCore](#valigatoraspnetcore)
- [Random Things To Move to Better Places](#random-things-to-move-to-better-places)
    - [Collections](#collections)
    - [Validating Non-`Data` Fields](#validating-non-data-fields)
    - [Custom Validations](#custom-validations)
- [Gotchas](#gotchas)

<!-- /TOC -->

Valigator is .NET suite of libraries that enabled the declaration of complex validation rules directly on model properties.

## Concepts
- Valigator.AspNetCore provides a JsonConverter and attaches to the AspNetCore deserialization process
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
    - deserializes into one of two states:

        - Set - Data was provided and passes all validations
        - Unset - No data was provided. This is equivalent to skipping a field. Passing in `null` is not Unset, that is either Valid or Invalid.

### Value Validator
### State Validator
### Validation Error Format

## Valigator.Core
The core library of Valigator.

## Valigator.AspNetCore
Library specifically to make adding to an AspNetCore application easy.

## Random Things To Move to Better Places

### Collections
Collections are defined slightly differently than regular `Data` fields.

Examples:
```C#
public Data<int[]> RequiredIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).Required();

public Data<int[]> DefaultedIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).Defaulted(new[]{1, 2, 3});

public Data<int[]> DefaultEmptyIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).DefaultedToEmpty();

public Data<Option<int[]>> OptionalIntegerCollection { get; set; } = Data.Collection<int>(x => x.GreaterThan(1)).Optional();
```

### Validating Non-`Data` Fields
Apply the `[ValidateContents]` attribute to the property or field to be validated. This will cause Valigator to run validations upon whatever object is contained in this field or property.

Example:
```C#
[ValidateContents]
private readonly object _value;
```

### Custom Validations
Examples:
```C#
public Data<Option<int>> IntegerValue { get; set; } = Data.Required<int>().Nullable().Assert("A meaningful description", value => value > 1)
```


## Gotchas
1) All properties must have a setter. This setter may be `private`.

