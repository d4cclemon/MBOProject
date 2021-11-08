using MyHomePage.Models.Data.Shared;
using MyHomePage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Models.Data.Home
{
    /// <summary>
    /// 記事モデルクラス
    /// </summary>
    public class ArticleDataModel : DataModelBase
    {
        public Article ArticleInfo { get; set; }
    }
}