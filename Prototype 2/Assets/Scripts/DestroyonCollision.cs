﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyonCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other);
    }
}
