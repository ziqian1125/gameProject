using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour

{
    //what we are following
    public Transform followObject;

    //zeroes out the velocity
    Vector3 velocity = Vector3.zero;

    //time to follow target
    public float smoothTime = .15f;

    //enable and set the maximum y value
    public bool YMaxEnabled = false;
    public float YMaxValue = 0;

    //enable and set the min y value
    public bool YMinEnabled = false;
    public float YMinValue = 0;


    //enable and set the maximum x value
    public bool XMaxEnabled = false;
    public float XMaxValue = 0;

    //enable and set the min x value
    public bool XMinEnabled = false;
    public float XMinValue = 0;


    // Update is called once per frame
    /*void Update()
    {
        transform.position = new Vector3(followObject.position.x,followObject.position.y,-10f);

    }*/
    void FixedUpdate()
    {
        //target position
        Vector3 targetPos = followObject.position;

        //vertical
        if (YMinEnabled && YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(followObject.position.y, YMinValue, YMaxValue);
        }
        else if (YMinEnabled)
        {
            targetPos.y = Mathf.Clamp(followObject.position.y, YMinValue, followObject.position.y);
        }
        else if (YMaxEnabled)
        {
            targetPos.y = Mathf.Clamp(followObject.position.y, YMaxValue, followObject.position.y);
        }

        //horizontal
        if (XMinEnabled && XMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(followObject.position.x, XMinValue, XMaxValue);
        }
        else if (XMinEnabled)
        {
            targetPos.x = Mathf.Clamp(followObject.position.x, XMinValue, followObject.position.x);
        }
        else if (XMaxEnabled)
        {
            targetPos.x = Mathf.Clamp(followObject.position.x, XMaxValue, followObject.position.x);
        }


        //align the camera and the targets z position
        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}

