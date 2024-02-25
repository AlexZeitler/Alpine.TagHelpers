using Microsoft.AspNetCore.Mvc;

namespace Alpine.TagHelpers.Samples.Features.GetDocumentation;

public class GetDocumentationController : Controller
{
  [Route("/documentation/introduction")]
  public IActionResult GetIntroduction() => View();
}
