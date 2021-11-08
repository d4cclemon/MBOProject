using MyHomePage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Models.View
{
    /// <summary>
    /// 記事ビューモデル
    /// </summary>
    public class ArticleViewModel : ViewModelBase
    {
        /// <summary>
        /// 記事情報
        /// </summary>
        public Article ArticleInfo { get; set; }

    }
}