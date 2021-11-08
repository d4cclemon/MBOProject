using MyHomePage.Models.Data.Home;
using MyHomePage.Models.Params;
using MyHomePage.Models.View;

namespace MyHomePage.Services
{
    interface IArticleService : IServiceBase<ArticleViewModel, ArticleParameter>
    {

    }

    /// <summary>
    /// ArticleService
    /// </summary>
    public class ArticleService : ServiceBase<ArticleViewModel, ArticleDataModel, ArticleParameter>, IArticleService
    {
        /// <summary>
        /// 情報取得
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public override ArticleDataModel GetData(ArticleParameter param)
        {
            var data = base.GetData(param);
            return data;
        }

        /// <summary>
        /// ビューモデル作成
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override ArticleViewModel CreateViewModel(ArticleDataModel data)
        {
            var model = base.CreateViewModel(data);

            return model;
        }
    }
}