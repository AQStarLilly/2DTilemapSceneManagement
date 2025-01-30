using UnityEngine;

public class SceneTransitionManager : MonoBehaviour
{
    public static SceneTransitionManager Instance;
    private string nextSpawnPoint;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSpawnPoint(string spawnPoint)
    {
        nextSpawnPoint = spawnPoint;
    }

    public string GetSpawnPoint()
    {
        return nextSpawnPoint;
    }
}