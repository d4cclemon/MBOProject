using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Models.Params
{
    /// <summary>
    /// 基底パラメータ
    /// </summary>
    public abstract class ParameterBase
    {
        /// <summary>
        /// 記事ID
        /// </summary>
        public int ArticleId { get; set; }

    }
}