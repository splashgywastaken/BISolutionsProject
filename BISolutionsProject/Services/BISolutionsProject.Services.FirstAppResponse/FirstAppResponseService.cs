using AutoMapper;
using BISolutionsProject.Services.FirstApp.Models;
using BISolutionsProject.Services.FirstAppResponse.Models;

namespace BISolutionsProject.Services.FirstAppResponse;

/// <summary>
/// Implementations for methods described in IFirstAppResponseService.
/// Generates responses for FirstAppService service
/// </summary>
public class FirstAppResponseService : IFirstAppResponseService
{
    private readonly IMapper _mapper;

    /// <summary>
    /// Constructor for FirstAppResponseService, used for DI
    /// </summary>
    /// <param name="mapper"></param>
    public FirstAppResponseService(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// Generates response for FirstAppService
    /// </summary>
    /// <param name="sumOfNumbers"></param>
    /// <returns></returns>
    public SumOfNumbersResponseModel GenerateResponseForSumOfNumbers(SumOfNumbersModel sumOfNumbers)
    {

        var response = _mapper.Map<SumOfNumbersResponseModel>(sumOfNumbers);

        return response;
    }
}