using BISolutionsProject.Services.ThirdApp.Models;

namespace BISolutionsProject.Services.ThirdApp;

/// <summary>
/// Defenitions for methods for third task (third app)
/// </summary>
public interface IThirdAppService
{
    /// <summary>
    /// Method used 
    /// </summary>
    /// <returns></returns>
    public SortedListModel SortList(ListDataModel list);
}