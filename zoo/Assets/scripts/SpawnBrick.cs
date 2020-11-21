using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBrick : MonoBehaviour
{
    public GameObject brickPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(brickWave());
    }

    private void spawnEnemy()
    {
        GameObject b = Instantiate(brickPrefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-5, 2), 24);
        b.transform.Rotate(Vector3.forward * Random.Range(90, -90));
    }

    IEnumerator brickWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
        
    }
}
