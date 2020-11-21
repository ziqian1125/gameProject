using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour

{
    // Start is called before the first frame update
    public Transform followObject;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(followObject.position.x,followObject.position.y,-10f);

    }
}
