using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;

    public float spawnRandom;

    Vector3 spawnPos;

    private void Start()
    {
        Instantiate(platformPrefab, spawnPos, Quaternion.identity);

        generateRandom();
        spawnPlatform();

        spawnPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
    }

    void spawnPlatform()
    {
        generateRandom();
        Instantiate(platformPrefab, spawnPos, Quaternion.identity);

        Invoke("spawnPlatform", spawnRandom);
    }

    void generateRandom()
    {
        UIManager uiManager = new UIManager();

        if(uiManager.Score < 1500)
        {
            spawnRandom = Random.Range(6f, 9f);
        }

        if (uiManager.Score > 1500)
        {
            spawnRandom = Random.Range(2f, 5f);
        }
        
    }
}
