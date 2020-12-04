using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class godestination : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform destination;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y>destination.position.y)
        {
            print("到终点了");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

        }
        
    }
}
