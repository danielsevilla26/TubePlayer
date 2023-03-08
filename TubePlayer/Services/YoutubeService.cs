using Maui.Apps.Framework.Services;
using MonkeyCache;
using TubePlayer.IServices;

namespace TubePlayer.Services
{
    public class YoutubeService : RestServiceBase, IApiService
    {
        public YoutubeService(IConnectivity connectivity, IBarrel cacheBarrel) : base(connectivity, cacheBarrel)
        {

        }
    }
}
