using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using BISolutionsProject.Api.Controllers.SumOfTwo.Models;
using BISolutionsProject.Services.FirstApp;
using BISolutionsProject.Services.FirstApp.Models;
using BISolutionsProject.Services.FirstAppResponse;
using BISolutionsProject.Services.FirstAppResponse.Models;
using Newtonsoft.Json;

namespace BISolutionsProject.Api.Controllers.SumOfTwo;

/// <summary>
/// Controller thats whole purpose is to perform actions related to first task
/// </summary>
[ApiController]
[Produces("application/json")]
[Route("api/v{version:apiVersion}/firstApp")]
[ApiVersion("0.1")]
public class SumOfTwoController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILogger<SumOfTwoController> _logger;
    private readonly IFirstAppService _firstAppService;
    private readonly IFirstAppResponseService _firstAppResponseService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="mapper"></param>
    /// <param name="logger"></param>
    /// <param name="firstAppService"></param>
    /// <param name="firstAppResponseService"></param>
    public SumOfTwoController(
        IMapper mapper, 
        ILogger<SumOfTwoController> logger,
        IFirstAppService firstAppService,
        IFirstAppResponseService firstAppResponseService
        )
    {
        _mapper = mapper;
        _logger = logger;
        _firstAppService = firstAppService;
        _firstAppResponseService = firstAppResponseService;
    }

    /// <summary>
    /// Executes main logic for controller
    /// </summary>
    /// <returns></returns>
    [HttpPost("sumOfTwo")]
    [ProducesResponseType(typeof(int), 200)]
    [MapToApiVersion("0.1")]
    public Task<SumOfNumbersResponse> GetSumOfTwo([FromBody] ListOfNumbersModel list)
    {
        var serviceResult = _firstAppService.SumOfEverySecondEvenNumbers(list);
        var serviceResponse = _firstAppResponseService.GenerateResponseForSumOfNumbers(serviceResult);
        var response = _mapper.Map<SumOfNumbersResponse>(serviceResponse);

        return Task.FromResult(response);
    }
}