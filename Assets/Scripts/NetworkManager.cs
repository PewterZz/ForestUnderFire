using Photon.Fusion;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    void Start()
    {
        // Initialize Photon Fusion
        NetworkRunner.StartGame(new StartGameArgs
        {
            GameMode = GameMode.AutoHostOrClient,
            SessionName = "MyGameSession"
        });
    }
}

