using MyHomePage.Models.Data.Home;
using MyHomePage.Models.Params;
using MyHomePage.Models.View;

namespace MyHomePage.Services
{
    interface IIntroductionService : IServiceBase<IntroductionViewModel, IntroductionParameter>
    {

    }

    /// <summary>
    /// IntroductionService
    /// </summary>
    public class IntroductionService : ServiceBase<IntroductionViewModel, IntroductionDataModel, IntroductionParameter>, IIntroductionService
    {
        /// <summary>
        /// 情報取得
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public override IntroductionDataModel GetData(IntroductionParameter param)
        {
            var data = base.GetData(param);
            return data;
        }

        /// <summary>
        /// ビューモデル作成
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public override IntroductionViewModel CreateViewModel(IntroductionDataModel data)
        {
            var model = base.CreateViewModel(data);

            return model;
        }

    }
}