using System.Collections.Generic;
using AntDesign;
using Microsoft.AspNetCore.Components;
using TTShang.Blazor.Models;

namespace TTShang.Blazor.Pages.Account.Center
{
    public partial class Projects
    {
        private readonly ListGridType _listGridType = new ListGridType
        {
            Gutter = 24,
            Column = 4
        };

        [Parameter]
        public IList<ListItemDataType> List { get; set; }
    }
}