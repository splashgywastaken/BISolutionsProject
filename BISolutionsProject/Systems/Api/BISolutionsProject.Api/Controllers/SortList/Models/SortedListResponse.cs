using AutoMapper;
using BISolutionsProject.Services.ThirdAppResponse.Model;

namespace BISolutionsProject.Api.Controllers.SortList.Models;

/// <summary>
/// A model used for responses from controller 
/// </summary>
public class SortedListResponse
{
    /// <summary>
    /// List itself
    /// </summary>
    public List<int> List { get; set; } = null!;
}

/// <summary>
/// Mapping profile class for sorted list response
/// </summary>
public class SortListResponseProfile : Profile
{
    /// <summary>
    /// Constructor with mapping definitions
    /// </summary>
    public SortListResponseProfile()
    {
        CreateMap<SortedListResponseModel, SortedListResponse>()
            .ForMember(
                dest => dest.List,
                opt => 
                    opt.MapFrom(val => val.List.ToList())
            );
    }
}