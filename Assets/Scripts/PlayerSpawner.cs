using Photon.Fusion;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour, INetworkRunnerCallbacks
{
    public GameObject playerPrefab;

    public void OnConnectedToServer(NetworkRunner runner)
    {
        // Spawn the player
        if (runner.IsServer)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            runner.Spawn(playerPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Implement other INetworkRunnerCallbacks methods as needed
    // ...
}
