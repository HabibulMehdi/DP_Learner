﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public static Transform player;
    
     void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

       // for rotating the minimap
        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
