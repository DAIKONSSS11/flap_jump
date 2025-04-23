using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{
    public Rigidbody2D r;
    public int speed;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            r.velocity=Vector2.up*speed;
        } 
    }
}
