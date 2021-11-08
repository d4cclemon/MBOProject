using MyHomePage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHomePage.Models.View
{
    /// <summary>
    /// 基底ビューモデル
    /// </summary>
    public abstract class ViewModelBase
    {
        /// <summary>
        /// 左メニュービューモデル
        /// </summary>
        public LeftMenuViewModel LeftMenuViewModel { get; set; }
    }
}