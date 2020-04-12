using UnityEngine;
using GoogleMobileAds.Api;
public class ADMOBADS : MonoBehaviour
{
    private BannerView AdBanner;
    private string idApp, idBanner;

    void Start()
    {
        idApp = "ca-app-pub-3424045410261496~5181532852";
        idBanner = "ca-app-pub-3424045410261496/2861371714";

        MobileAds.Initialize(idApp);
        RequestBannerAd();
    }

    #region Banner Methods
    public void RequestBannerAd()
    {
        AdBanner = new BannerView(idBanner, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = adRequestBuild();
        AdBanner.LoadAd(request);
    }

    public void DestroyBannerAd()
    {
        if (AdBanner != null)
            AdBanner.Destroy();
    }
    #endregion


    //--------------------------------------------                                                    
    AdRequest adRequestBuild()
    {
        return new AdRequest.Builder().Build();
    }
}
