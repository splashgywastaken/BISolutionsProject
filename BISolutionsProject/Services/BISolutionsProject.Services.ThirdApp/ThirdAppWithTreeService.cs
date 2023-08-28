using BISolutionsProject.Services.ThirdApp.Models;
using BISolutionsProject.Services.ThirdApp.Tools;

namespace BISolutionsProject.Services.ThirdApp;

/// <summary>
/// Implementations and logic for third task (third app)
/// </summary>
public class ThirdAppWithTreeService : IThirdAppService
{
    /// <inheritdoc />
    public SortedListModel SortList(ListDataModel list)
    {
        var sortResult = TreeTools.TreeSort(list.List);
        return new SortedListModel
        {
            List = sortResult
        };
    }
}