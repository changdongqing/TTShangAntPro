using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using TTShang.Blazor.Models;

namespace TTShang.Blazor.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}