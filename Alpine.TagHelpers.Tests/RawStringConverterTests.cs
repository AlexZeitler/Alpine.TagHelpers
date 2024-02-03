using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Alpine.TagHelpers.Tests;

public class RawStringConverterTests
{
  [Fact]
  public void should_convert_function_as_raw()
  {
    // Arrange
    const string function = "function() { return 'Hello'; }";
    const string expected = "function() { return 'Hello'; }";
    var converter = new RawStringConverter();
    var stringWriter = new StringWriter();
    var jsonWriter = new JsonTextWriter(stringWriter);
    var serializer = new JsonSerializer
    {
      ContractResolver = new CamelCasePropertyNamesContractResolver()
    };
    jsonWriter.QuoteName = false;
    jsonWriter.QuoteChar = '\'';
    
    converter.WriteJson(jsonWriter, function, serializer);
    var actual = stringWriter.ToString();
   
    actual.ShouldBe(expected);
  }
}
