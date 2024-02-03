namespace Alpine.TagHelpers.Tests;

public class JavaScriptConverterTests
{
  [Fact]
  public void ShouldSerializeObject()
  {
    var result = JavaScriptConverter.SerializeObject(new { Name = "Jane" }).ToString();
    result.ShouldBe("{name:'Jane'}");
  }
}
