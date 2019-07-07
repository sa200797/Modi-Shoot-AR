
using UnityEngine;
using GoogleMobileAds.Api;


public class Add_Manager : MonoBehaviour
{
     
    private BannerView bannerView;
    private InterstitialAd Ad;

[SerializeField] private string appId = " ca-app-pub-9211203779392904~6811138280";

    [SerializeField] private string bannerid = "ca-app-pub-9211203779392904/3468102729";
    [SerializeField] private string videoAddid = "ca-app-pub-9211203779392904/4333272467";


    private void Awake()
    {
        MobileAds.Initialize(appId);
    }

    public void ShowBannerAdd()
    {
        this.RequestBanner();
    }

   

    void RequestBanner()
    {
        bannerView = new BannerView(bannerid, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
        

    }
    public void CLOSEbANNER()
    {
        bannerView.Hide();
        bannerView.Destroy();
        

    }


    public void requestVideo()
    {
         Ad = new InterstitialAd(videoAddid);
        AdRequest request = new AdRequest.Builder().Build();

        Ad.LoadAd(request);
    }

    public void ShowVideoAdd()
    {
        if (Ad.IsLoaded())
        {
            Ad.Show();
        }


        // this.requestVideo();
    }
    private void Start()
    {
        requestVideo();
    }
}
