using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center : MonoBehaviour
{
    public float radius = 1;

//This code doesn't do a thing, I'm just too blind to see the circle without color contrart.Just ignore it please
    private void OnDrawGizmos() {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
