using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCommonBase
{
  public class BlazorComponentCommon : BlazorComponent
  {
    #region parameters

    [Parameter] public string param1 { get; set; } = null;
    [Parameter] public string param2 { get; set; } = null;
    [Parameter] public string param3 { get; set; } = null;
    [Parameter] public string param4 { get; set; } = null;
    [Parameter] public string param5 { get; set; } = null;
    [Parameter] public string param6 { get; set; } = null;

    #endregion ------------------------------------------------------------------------------------

    #region variables

    public string title = String.Empty;

    #endregion

    #region functions

    public virtual void SetParameterValues()
    {

    }

    #endregion ------------------------------------------------------------------------------------

    #region function overrides

    protected override void OnParametersSet()
    {
      SetParameterValues();
    }
    #endregion ------------------------------------------------------------------------------------

  }
}
