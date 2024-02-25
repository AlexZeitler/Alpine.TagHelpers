using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc.Razor;

[assembly: AspMvcViewLocationFormat("~/Features/{1}/{0}.cshtml")]
[assembly: AspMvcViewLocationFormat("~/Components/{0}/{0}.cshtml")]
[assembly: AspMvcViewLocationFormat("~/Components/{1}/{0}.cshtml")]
[assembly: AspMvcViewLocationFormat("~/Layouts/{0}.cshtml")]
[assembly: AspMvcPartialViewLocationFormat("~/Features/{1}/{0}.cshtml")]
[assembly: AspMvcPartialViewLocationFormat("~/Layouts/{0}.cshtml")]
[assembly: AspMvcPartialViewLocationFormat("~/Components/{0}/{0}.cshtml")]
[assembly: AspMvcPartialViewLocationFormat("~/Components/{1}/{0}.cshtml")]

namespace Alpine.TagHelpers.Samples;

public class FeatureFolderLocationExpander : IViewLocationExpander
{
  public void PopulateValues(
    ViewLocationExpanderContext context
  )
  {
    // Don't need anything here, but required by the interface
  }

  public IEnumerable<string> ExpandViewLocations(
    ViewLocationExpanderContext context,
    IEnumerable<string> viewLocations
  )
  {
    return new[]
    {
      "~/Features/{1}/{0}.cshtml", "~/Layouts/{0}.cshtml", "~/Components/{0}/{0}.cshtml",
      "~/Components/{1}/{0}.cshtml"
    };
  }
}
