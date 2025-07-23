using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speedObj;
    public Vector2 directionObj;
    public void Initialize(Vector2 direction, float speed)
    {
        directionObj = direction;
        speedObj = speed;
    }
    void Update()
    {
        transform.position += (Vector3)(directionObj.normalized * speedObj * Time.deltaTime);        
    }
}
