﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkgrndFollow : MonoBehaviour
{
    private Func<Vector3> GetbkgrndFollowPositionFunc;
    // Start is called before the first frame update
    public void Setup(Func<Vector3> GetbkgrndFollowPositionFunc)
    {
        
        this.GetbkgrndFollowPositionFunc = GetbkgrndFollowPositionFunc;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bkgrndFollowPosition = GetbkgrndFollowPositionFunc();
        bkgrndFollowPosition.z = transform.position.z;
        bkgrndFollowPosition.y = transform.position.y;
        transform.position = bkgrndFollowPosition;
    }
}
