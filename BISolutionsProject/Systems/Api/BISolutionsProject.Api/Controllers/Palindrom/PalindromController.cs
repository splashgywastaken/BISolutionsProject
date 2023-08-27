using AutoMapper;
using BISolutionsProject.Api.Controllers.Palindrom.Models;
using BISolutionsProject.Services.SecondApp;
using BISolutionsProject.Services.SecondApp.Models;
using BISolutionsProject.Services.SecondAppResponse;
using Microsoft.AspNetCore.Mvc;

namespace BISolutionsProject.Api.Controllers.Palindrom;

/// <summary>
/// A controller used for second task 
/// </summary>
[Produces("application/json")]
[Route("api/v{version:apiVersion}/secondApp")]
[ApiController]
[ApiVersion("0.1")]
public class PalindromController : ControllerBase
{
    private readonly ILogger<PalindromController> _logger;
    private readonly IMapper _mapper;
    private readonly ISecondAppService _secondAppService;
    private readonly ISecondAppResponseService _secondAppResponseService;

    /// <summary>
    /// A constructor used for intialization of PalindromController through DI
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="mapper"></param>
    /// <param name="secondAppService"></param>
    /// <param name="secondAppResponseService"></param>
    public PalindromController(
        ILogger<PalindromController> logger, 
        IMapper mapper, 
        ISecondAppService secondAppService, 
        ISecondAppResponseService secondAppResponseService
        )
    {
        _logger = logger;
        _mapper = mapper;
        _secondAppService = secondAppService;
        _secondAppResponseService = secondAppResponseService;
    }

    /// <summary>
    /// Method used to check a string for being a palinrom 
    /// </summary>
    /// <returns></returns>
    [HttpGet("palindrom")]
    public async Task<PalindromCheckResponse> CheckStringForBeingPalindrom(
        [FromQuery] PalindromCheckModel palindromCheckModel
        )
    {
        var serviceResult = _secondAppService.CheckStringForPalindrom(palindromCheckModel);
        var serviceResponse = _secondAppResponseService.GeneratePalindromCheckResponse(serviceResult);
        var response = _mapper.Map<PalindromCheckResponse>(serviceResponse);

        return response;
    }
}