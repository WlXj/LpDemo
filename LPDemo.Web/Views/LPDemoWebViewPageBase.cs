using Abp.Web.Mvc.Views;

namespace LPDemo.Web.Views
{
    public abstract class LPDemoWebViewPageBase : LPDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class LPDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LPDemoWebViewPageBase()
        {
            LocalizationSourceName = LPDemoConsts.LocalizationSourceName;
        }
    }
}