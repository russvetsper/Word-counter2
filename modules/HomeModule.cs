using Nancy;
// using System.Collections.Generic;

namespace WordCountering
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
     {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/result"] = _ => {
        WordCounter  newWord = new WordCounter  ( Request.Form["new-word"], Request.Form["new-sentence"]);
        return View["results.cshtml", newWord];
      };
    }
  }
}
