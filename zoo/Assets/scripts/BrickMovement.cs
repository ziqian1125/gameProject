using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform prefab;
    private Rigidbody2D brick;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        brick = this.GetComponent<Rigidbody2D>();
        brick.velocity = new Vector2(0, -speed * Time.deltaTime);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < screenBounds.y * -10)
        {
            Destroy(this.gameObject);
        }
        //Debug.Log("Location:" + gameObject.transform.position);
    }


}

