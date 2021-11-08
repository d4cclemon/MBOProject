using MyHomePage.Models.Data.Shared;
using MyHomePage.Models.Params;
using MyHomePage.Models.View;

namespace MyHomePage.Services
{
    /// <summary>
    /// ServiceBase
    /// </summary>
    /// <typeparam name="V"></typeparam>
    /// <typeparam name="D"></typeparam>
    /// <typeparam name="P"></typeparam>
    public abstract class ServiceBase<V, D, P> : IServiceBase<V, P>
                                                        where V : ViewModelBase,  new() 
                                                        where D : DataModelBase,  new() 
                                                        where P : ParameterBase
    {
        /// <summary>
        /// 実行処理
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public V Do(P param)
        {
            D data;
            data = GetData(param);
            return CreateViewModel(data);
        }

        /// <summary>
        /// 情報取得
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual D GetData(P param)
        {
            var data = new D();
            data.Params = param;
            return data;
        }

        /// <summary>
        /// ビューモデル作成
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public virtual V CreateViewModel(D data)
        {
            var model = new V();
            model.LeftMenuViewModel = new LeftMenuViewModel(data);

            return model;
        }
    }
}