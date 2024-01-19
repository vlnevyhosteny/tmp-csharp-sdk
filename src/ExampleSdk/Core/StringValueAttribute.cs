/**
 * Sample Business API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: acme@example.com
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Reflection;

namespace ExampleSdk.Core;

// Taken from https://stackoverflow.com/a/8588476

/// <summary>
/// This attribute is used to represent a string value
/// for a value in an enum.
/// </summary>
public class StringValueAttribute : Attribute {
  public string StringValue { get; protected set; }

  /// <summary>
  /// Constructor used to init a StringValue Attribute
  /// </summary>
  /// <param name="value"></param>
  public StringValueAttribute(string value) {
      this.StringValue = value;
  }
}

public static class StringValueExtensions {
  /// <summary>
  /// Will get the string value for a given enums value, this will
  /// only work if you assign the StringValue attribute to
  /// the items in your enum.
  /// </summary>
  /// <param name="value"></param>
  /// <returns></returns>
  public static string? GetStringValue(this Enum value) {
    // Get the type
    Type type = value.GetType();

    // Get fieldinfo for this type
    FieldInfo? fieldInfo = type.GetField(value.ToString());

    // Get the stringvalue attributes
    StringValueAttribute[]? attribs = fieldInfo?.GetCustomAttributes(
      typeof(StringValueAttribute), false) as StringValueAttribute[];

    // Return the first if there was a match.
    return attribs?.Length > 0 ? attribs[0].StringValue : null;
  }
}
