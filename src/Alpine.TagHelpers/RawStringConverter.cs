using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alpine.TagHelpers;

/// <summary>
/// Converts a string to a raw JavaScript value.
/// </summary>
public class RawStringConverter : JsonConverter
{
  public override bool CanConvert(
    Type objectType
  ) =>
    objectType == typeof(string);

  public override bool CanRead => false;

  /// <summary>
  /// Read the raw value from the JSON reader.
  /// </summary>
  /// <param name="reader"></param>
  /// <param name="objectType"></param>
  /// <param name="existingValue"></param>
  /// <param name="serializer"></param>
  /// <returns>Raw string</returns>
  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer
  ) =>
    JRaw
      .Create(reader)
      .ToString();

  /// <summary>
  /// Write the raw value to the JSON writer.
  /// </summary>
  /// <param name="writer"></param>
  /// <param name="value"></param>
  /// <param name="serializer"></param>
  public override void WriteJson(
    JsonWriter writer,
    object value,
    JsonSerializer serializer
  ) =>
    writer.WriteRawValue((string)value);
}
