using BlazorApp.ViewModels.Base;
using System.Threading.Tasks;

namespace BlazorApp.Services.Base
{
    public interface ISendService
    {
        Task<object> SendService(IBaseViewModel model = null);
    }
}
