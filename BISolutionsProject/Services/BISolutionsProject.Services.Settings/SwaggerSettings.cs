namespace BISolutionsProject.Services.Settings;

public class SwaggerSettings
{
    /// <summary>
    /// Boolean check to know if swagger need to be enabled or not
    /// </summary>
    public bool Enabled { get; private set; }

    /// <summary>
    /// Default constructor that sets check as false
    /// </summary>
    public SwaggerSettings()
    {
        Enabled = false;
    }
}