using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGround : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y <= -16f)
        {
            Destroy(gameObject);
        }
    }
}
