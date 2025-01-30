using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Transform spawnPoint = GameObject.Find(SceneTransitionManager.Instance.GetSpawnPoint())?.transform;
            if (spawnPoint != null)
            {
                player.transform.position = spawnPoint.position;
            }
            else
            {
                Debug.LogWarning("Spawn point not found!");
            }
        }
    }
}
