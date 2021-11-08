using MyHomePage.Models.Data.Home;
using MyHomePage.Models.Entities;
using MyHomePage.Models.Params;
using MyHomePage.Models.View;
using System.Collections.Generic;
using System.Linq;

namespace MyHomePage.Services
{
    interface IIndexService : IServiceBase<IndexViewModel, IndexParameter>
    {

    }

    /// <summary>
    /// IndexService
    /// </summary>
    public class IndexService : ServiceBase<IndexViewModel, IndexDataModel, IndexParameter>, IIndexService
    {
        /// <summary>
        /// 情報取得
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public override IndexDataModel GetData(IndexParameter param)
        {
            var data = base.GetData(param);
            return data;
        }

        /// <summary>
        /// ビューモデル作成
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override IndexViewModel CreateViewModel(IndexDataModel data)
        {
            var model = base.CreateViewModel(data);
            //model.IndexArticleList = GetIndexArticleList(data);

            return model;
        }

        /// <summary>
        /// 一覧記事リスト取得
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public IEnumerable<Article> GetIndexArticleList(IndexDataModel data)
        {
            return data.Articles.Take(4);
        }

    }
}