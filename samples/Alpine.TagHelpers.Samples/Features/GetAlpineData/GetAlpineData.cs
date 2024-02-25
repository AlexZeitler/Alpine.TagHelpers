using Microsoft.AspNetCore.Mvc;

namespace Alpine.TagHelpers.Samples.Features.GetAlpineData;

public class GetAlpineDataController: Controller
{
  [HttpGet("/tag-helpers/alpine-data-tag-helper")]
  public IActionResult GetAlpineData() => View();
}
