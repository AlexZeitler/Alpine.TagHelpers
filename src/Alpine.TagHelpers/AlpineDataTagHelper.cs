using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Alpine.TagHelpers;

/// <summary>
/// Targets any element that has alpine-data attribute.
/// It will render a x-data attribute.
/// This will ultimately hold the javascript serialized object without property name quotes.
/// </summary>
[HtmlTargetElement("*", Attributes = "alpine-data")]
public class AlpineDataTagHelper : TagHelper
{
  /// <inheritdoc />
  public override void Process(
    TagHelperContext context,
    TagHelperOutput output
  )
  {
    output.Attributes.Add("x-data", JavaScriptConverter.SerializeObject(Data));
    base.Process(context, output);
  }

  /// <summary>
  /// The .NET object to serialize as JavaScript object without property name quotes.
  /// </summary>
  [HtmlAttributeName("alpine-data")] public object Data { get; set; } = null!;
}
