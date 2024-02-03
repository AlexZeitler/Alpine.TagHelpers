using Newtonsoft.Json;

namespace Alpine.TagHelpers.Tests;

public class TestObject
{
  public string Name { get; set; }

  [JsonConverter(typeof(RawStringConverter))]
  public string OnClick { get; set; }
}

public class JavaScriptConverterTests
{
  [Fact]
  public void ShouldSerializeObject()
  {
    var result = JavaScriptConverter.SerializeObject(
        new
        {
          Name = "Jane"
        }
      )
      .ToString();
    result.ShouldBe("{name:'Jane'}");
  }

  [Fact]
  public void ShouldSerializeRaw()
  {
    var result = JavaScriptConverter.SerializeObject(
        new TestObject
        {
          Name = "Jane",
          OnClick = "function() { return 'Hello'; }"
        }
      )
      .ToString();
    result.ShouldBe("{name:'Jane',onClick:function() { return 'Hello'; }}");
  }
}
