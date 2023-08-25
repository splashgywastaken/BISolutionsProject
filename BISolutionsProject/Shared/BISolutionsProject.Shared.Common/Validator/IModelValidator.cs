namespace BISolutionsProject.Shared.Common.Validator;

public interface IModelValidator<in T> where T : class
{
    /// <summary>
    /// Method used to check model validity
    /// </summary>
    /// <param name="model"></param>
    void Check(T model);
}