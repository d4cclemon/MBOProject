using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static MyHomePage.Constants.ConstantBase;

namespace MyHomePage.Repositories
{
    /// <summary>
    /// 一覧リポジトリ
    /// </summary>
    public class IndexRepository : RepositoryBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IndexRepository() : base(ConnectionStr)
        {

        }
    }
}