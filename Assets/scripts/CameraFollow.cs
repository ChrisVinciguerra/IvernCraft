using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Func<Vector3> GetcameraFollowPositionFunc;
    
    // Start is called before the first frame update
    public void Setup(Func<Vector3> GetcameraFollowPositionFunc) {
        this.GetcameraFollowPositionFunc = GetcameraFollowPositionFunc;
        
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 cameraFollowPosition = GetcameraFollowPositionFunc();
        cameraFollowPosition.z = transform.position.z;
        cameraFollowPosition.y = transform.position.y;
        transform.position = cameraFollowPosition;

        
    }
}
