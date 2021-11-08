using MyHomePage.Models.Entities;
using MyHomePage.Models.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Models.Data.Shared
{
    /// <summary>
    /// 基底モデルクラス
    /// </summary>
    public abstract class DataModelBase
    {
        /// <summary>
        /// パラメータ
        /// </summary>
        public ParameterBase Params{get;set;}
        
        /// <summary>
        /// 記事
        /// </summary>
        public IEnumerable<Article> Articles { get; set; }

    }
}