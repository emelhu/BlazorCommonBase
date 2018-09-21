using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCommonBase.Pages
{
  public class IndexBase : BlazorComponentCommon
  {
    protected override void OnInit()
    {
      Console.WriteLine("BlazorCommonBase --- OnInit()");

      title = "Welcome in BlazorCommonBase app. :)";
    }
  }
}
