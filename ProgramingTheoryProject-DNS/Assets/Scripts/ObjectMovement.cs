using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectMovement : MonoBehaviour
{
    private float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
