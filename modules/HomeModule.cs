using Nancy;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
     {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/result"] = _ => {
    
        return View["results.cshtml"];
      };
 }
}
}
