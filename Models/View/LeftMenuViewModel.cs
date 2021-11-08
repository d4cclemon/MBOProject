using MyHomePage.Models.Data.Shared;
using MyHomePage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static MyHomePage.Models.View.ArchiveArticleInfo;

namespace MyHomePage.Models.View
{
    /// <summary>
    /// 左メニュービューモデル
    /// </summary>
    public class LeftMenuViewModel : ViewModelBase
    {
        /// <summary>
        /// 記事ランキングリスト
        /// </summary>
        public readonly IEnumerable<Article> RankingArticleList;

        /// <summary>
        /// 最近の記事
        /// </summary>
        public readonly IEnumerable<Article> RecentlyUpdateArticles;

        /// <summary>
        /// アーカイブ
        /// </summary>
        public IEnumerable<ArchiveArticleInfo> ArchiveArticleInfo;

        public LeftMenuViewModel(DataModelBase data)
        {
            //RankingArticleList = GetRankingArticleList(data);
            //RecentlyUpdateArticles = GetRecentlyUpdateArticles(data);
            //ArchiveArticleInfo = GetArchiveArticleInfo(data);
        }
        
        /// <summary>
        /// 閲覧数上位3位取得
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private IEnumerable<Article> GetRankingArticleList(DataModelBase data)
        {
            return data.Articles.OrderByDescending(article => article.ViewCount).Take(3);
        }

        /// <summary>
        /// 直近更新3記事取得
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private IEnumerable<Article> GetRecentlyUpdateArticles(DataModelBase data)
        {
            return data.Articles.OrderByDescending(artcle => artcle.UpDate).Take(3);
        }

        /// <summary>
        /// アーカイブ情報取得
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private IEnumerable<ArchiveArticleInfo> GetArchiveArticleInfo(DataModelBase data)
        {
            return data.Articles.GroupBy(article => new
                    {
                        Year = article.Date.Year,
                        Month = article.Date.Month
                    })
                    .Select(x => new ArchiveArticleInfo(new DateInfo(x.Key.Year, x.Key.Month), x.Count()));
        }
    }

    /// <summary>
    /// アーカイブ情報
    /// </summary>
    public class ArchiveArticleInfo
    {
        /// <summary>
        /// 日付情報
        /// </summary>
        public DateInfo DateInfo { get; }

        /// <summary>
        /// 閲覧数
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="info"></param>
        /// <param name="count"></param>
        public ArchiveArticleInfo(DateInfo info, int count)
        {
            DateInfo = info;
            Count = count;
        }
    }

    /// <summary>
    /// 日付情報
    /// </summary>
    public class DateInfo
    {
        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public DateInfo(int year, int month)
        {
            Year = year;
            Month = month;
        }
    }
}