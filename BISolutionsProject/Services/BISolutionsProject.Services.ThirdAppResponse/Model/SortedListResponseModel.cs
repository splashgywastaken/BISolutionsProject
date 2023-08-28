using AutoMapper;
using BISolutionsProject.Services.ThirdApp.Models;

namespace BISolutionsProject.Services.ThirdAppResponse.Model;

/// <summary>
/// Model used to keep generated response
/// </summary>
public class SortedListResponseModel
{
    /// <summary>
    /// Sorted list itself
    /// </summary>
    public IEnumerable<int> List { get; set; } = null!;
}

/// <summary>
/// Mapping profile class for sorted list response model
/// </summary>
public class SortedListResponseModelProfile : Profile
{
    /// <summary>
    /// Constructor with mapping definitions
    /// </summary>
    public SortedListResponseModelProfile()
    {
        CreateMap<SortedListModel, SortedListResponseModel>();
    }
}