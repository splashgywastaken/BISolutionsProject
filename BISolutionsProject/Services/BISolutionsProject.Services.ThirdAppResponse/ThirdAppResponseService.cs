using AutoMapper;
using BISolutionsProject.Services.ThirdApp.Models;
using BISolutionsProject.Services.ThirdAppResponse.Model;

namespace BISolutionsProject.Services.ThirdAppResponse;

/// <summary>
/// Contains implementations for methods described in IThirdAppResponseService
/// </summary>
public class ThirdAppResponseService : IThirdAppResponseService
{
    private readonly IMapper _mapper;

    /// <summary>
    /// Constructor for DI
    /// </summary>
    /// <param name="mapper"></param>
    public ThirdAppResponseService(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <inheritdoc />
    public SortedListResponseModel GenerateResponse(SortedListModel listModel)
    {
        var serviceResponse = _mapper.Map<SortedListResponseModel>(listModel);

        return serviceResponse;
    }
}