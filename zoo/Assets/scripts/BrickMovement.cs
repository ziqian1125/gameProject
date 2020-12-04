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
        //brick will move at a given speed
        brick = this.GetComponent<Rigidbody2D>();
        brick.velocity = new Vector2(0, -speed);

        //add some lag to brick so it doesn't move faster the farther it drops
        brick.drag = 3;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        //brick is destroyed when it is way off the screen
        if (transform.position.y < screenBounds.y * -2)
        {
            Destroy(this.gameObject);
        }
        //Debug.Log("Location:" + gameObject.transform.position);
    }


}

