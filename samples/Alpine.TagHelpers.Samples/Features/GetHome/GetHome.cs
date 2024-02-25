using System.Diagnostics;
using Alpine.TagHelpers.Samples.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alpine.TagHelpers.Samples.Features.GetHome;

public class GetHomeController : Controller
{
  public IActionResult GetHome()
  {
    return View();
  }

  [ResponseCache(
    Duration = 0,
    Location = ResponseCacheLocation.None,
    NoStore = true
  )]
  public IActionResult Error()
  {
    return View(
      new ErrorViewModel
      {
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
      }
    );
  }
}
