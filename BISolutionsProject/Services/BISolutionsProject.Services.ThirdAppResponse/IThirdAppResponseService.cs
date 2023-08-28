using BISolutionsProject.Services.ThirdApp.Models;
using BISolutionsProject.Services.ThirdAppResponse.Model;

namespace BISolutionsProject.Services.ThirdAppResponse;

/// <summary>
/// Contains defenitions for third app's service methods
/// </summary>
public interface IThirdAppResponseService
{
    /// <summary>
    /// Generates data based on given SortedListModel listModel 
    /// </summary>
    /// <param name="listModel"></param>
    /// <returns></returns>
    public SortedListResponseModel GenerateResponse(SortedListModel listModel);
}