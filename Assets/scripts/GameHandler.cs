using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public CameraFollow cameraFollow;
    public Transform playerTransform;
    public BkgrndFollow bkgrndFollow;
    public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        cameraFollow.Setup(() => playerTransform.position);
        bkgrndFollow.Setup(() => cameraTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
