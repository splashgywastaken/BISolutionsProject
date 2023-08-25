namespace BISolutionsProject.Common.Responses;

public class ErrorResponse
{
#pragma warning disable CS1591
    public int ErrorCode { get; set; }
    public string Message { get; set; }
    public IEnumerable<ErrorResponseFieldInfo> FieldErrors { get; set; }
#pragma warning restore CS1591
}

/// <summary>
/// Error response field DTO model, contains data about name of error field and it's message
/// </summary>
public class ErrorResponseFieldInfo
{
#pragma warning disable CS1591
    public string FieldName { get; set; }
    public string Message { get; set; }
#pragma warning restore CS1591
}