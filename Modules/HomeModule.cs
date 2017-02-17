using Nancy;
using System.Collections.Generic;
using RepeatCounterApp.Objects;


namespace RepeatCounterApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/result"] = _ => {
               string givenString = Request.Form["given-string"];
               string givenWord = Request.Form["given-word"];
               RepeatCounter model = new RepeatCounter(givenWord, givenString);
               return View["result.cshtml", model];
           };
        }
    }
}
