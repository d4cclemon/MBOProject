using static MyHomePage.Constants.ConstantBase;

namespace MyHomePage.Repositories
{
    /// <summary>
    /// 記事リポジトリ
    /// </summary>
    public class ArticleRepository : RepositoryBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ArticleRepository() : base(ConnectionStr)
        {

        }
    }
}