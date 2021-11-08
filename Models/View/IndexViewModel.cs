using MyHomePage.Models.Entities;
using MyHomePage.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Models.View
{
    /// <summary>
    /// 一覧ビューモデル
    /// </summary>
    public class IndexViewModel : ViewModelBase
    {
        /// <summary>
        /// 記事一覧リスト
        /// </summary>
        public IEnumerable<Article> IndexArticleList { get; set; }
    }

    
}