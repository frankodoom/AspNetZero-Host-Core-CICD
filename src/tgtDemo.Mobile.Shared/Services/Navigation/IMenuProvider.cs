using System.Collections.Generic;
using MvvmHelpers;
using tgtDemo.Models.NavigationMenu;

namespace tgtDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}