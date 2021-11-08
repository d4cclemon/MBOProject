using MyHomePage.Models.Params;
using MyHomePage.Models.View;

namespace MyHomePage.Services
{
    /// <summary>
    /// IServiceBase
    /// </summary>
    /// <typeparam name="V"></typeparam>
    /// <typeparam name="P"></typeparam>
    public interface IServiceBase<V, P> 
                                        where V : ViewModelBase 
                                        where P : ParameterBase
    {
        V Do(P param);
    }
}