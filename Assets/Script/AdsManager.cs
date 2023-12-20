using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    // Coloque o seu ID de jogo do Unity Ads aqui
    private string gameId = "5319137";
    private bool testMode = true; // Defina como false para produção

    private void Start()
    {
        InitializeAds();
    }

    private void InitializeAds()
    {
        if (!Advertisement.isInitialized)
        {
            Advertisement.Initialize(gameId, testMode);
        }
    }
}
