using System.IO;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alpine.TagHelpers;

/// <summary>
/// Serializes a .NET object to JavaScript as IHtmlContext for use in Razor Views.
/// </summary>
public static class JavaScriptConverter
{
  /// <summary>
  /// Serializes a .NET object to JavaScript.
  /// </summary>
  /// <remarks>The result is not JSON.</remarks>
  public static IHtmlContent SerializeObject(
    object value
  )
  {
    using var stringWriter = new StringWriter();
    using var jsonWriter = new JsonTextWriter(stringWriter);

    var serializer = new JsonSerializer
    {
      ContractResolver = new CamelCasePropertyNamesContractResolver()
    };

    jsonWriter.QuoteName = false;
    jsonWriter.QuoteChar = '\'';
    serializer.Serialize(jsonWriter, value);

    return new HtmlString(stringWriter.ToString());
  }
}
