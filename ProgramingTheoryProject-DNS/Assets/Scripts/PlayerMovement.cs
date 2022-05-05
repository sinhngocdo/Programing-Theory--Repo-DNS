using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 50.0f; //toc do di chuyen player

    public float Speed { get => speed; set => speed = value; }

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
    }

    void MoveControl()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        gameObject.transform.Translate(Vector3.forward * Speed * horizontal * Time.deltaTime);
    }
}
