using AutoMapper;
using BISolutionsProject.Api.Controllers.SortList.Models;
using BISolutionsProject.Api.Controllers.SumOfTwo.Models;
using BISolutionsProject.Services.ThirdApp;
using BISolutionsProject.Services.ThirdApp.Models;
using BISolutionsProject.Services.ThirdAppResponse;
using Microsoft.AspNetCore.Mvc;

namespace BISolutionsProject.Api.Controllers.SortList;

/// <summary>
/// Controller for third task (third app) which used to sort List using Tree
/// </summary>
[ApiController]
[Produces("application/json")]
[Route("api/v{version:apiVersion}/third-app")]
[ApiVersion("0.1")]
public class SortListController : ControllerBase
{
    private readonly ILogger<SortListController> _logger;
    private readonly IMapper _mapper;
    private readonly IThirdAppService _thirdAppService;
    private readonly IThirdAppResponseService _thirdAppResponseService;

    /// <summary>
    /// Constructor for DI
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="mapper"></param>
    /// <param name="thirdAppService"></param>
    /// <param name="thirdAppResponseService"></param>
    public SortListController(
        ILogger<SortListController> logger,
        IMapper mapper, 
        IThirdAppService thirdAppService, 
        IThirdAppResponseService thirdAppResponseService
        )
    {
        _logger = logger;
        _mapper = mapper;
        _thirdAppService = thirdAppService;
        _thirdAppResponseService = thirdAppResponseService;
    }

    /// <summary>
    /// Method that sorts list of integers using binary tree
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpPost("sort-list")]
    [ProducesResponseType(typeof(SortedListResponse), 200)]
    [MapToApiVersion("0.1")]
    public Task<SortedListResponse> SortList([FromBody] ListDataModel list)
    {
        var serviceResult = _thirdAppService.SortList(list);
        var serviceResponse = _thirdAppResponseService.GenerateResponse(serviceResult);
        var response = _mapper.Map<SortedListResponse>(serviceResponse);

        return Task.FromResult(response);
    }
}