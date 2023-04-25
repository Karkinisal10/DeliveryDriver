using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFOllow;
    // camaera should be in car position
    void Update()
    {
        transform.position = thingToFOllow.transform.position + new Vector3 (0, 0, -10);
    }
}
