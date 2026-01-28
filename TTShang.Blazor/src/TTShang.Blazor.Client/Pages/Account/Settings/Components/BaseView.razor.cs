using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TTShang.Blazor.Models;
using TTShang.Blazor.Services;

namespace TTShang.Blazor.Pages.Account.Settings
{
    public partial class BaseView
    {
        private CurrentUser _currentUser = new CurrentUser();

        [Inject] protected IUserService UserService { get; set; }

        private void HandleFinish()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _currentUser = await UserService.GetCurrentUserAsync();
        }
    }
}