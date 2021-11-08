using static MyHomePage.Constants.ConstantBase;

namespace MyHomePage.Repositories
{
    /// <summary>
    /// 自己紹介リポジトリ
    /// </summary>
    public class IntroductionRepository : RepositoryBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IntroductionRepository() : base(ConnectionStr)
        {

        }
    }
}