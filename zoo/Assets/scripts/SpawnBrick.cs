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
        StartCoroutine(brickWave()); //starts spawning bricks
    }

    private void spawnEnemy()
    {
        //creates a brick, spawns it in the ceiling area and rotates it randomly
        GameObject b = Instantiate(brickPrefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-6.5f, 10.5f), 24);
        b.transform.Rotate(Vector3.forward * Random.Range(90, -90));
    }

    IEnumerator brickWave()
    {
        while (true)
        {
            //spawns a brick after respawntime
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
        
    }
}
