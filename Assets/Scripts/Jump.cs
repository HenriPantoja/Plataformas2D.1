using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Fuerza de saltos y detector de  suelos
public class Jump : MonoBehaviour
{
  

    Rigidbody2D rb;
    public float force = 200;
    public float force_air = 100;
    public int jumps_max = 2;
    int jumps;
    GroundDetector_Raycast ground;
    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        ground = GetComponent<GroundDetector_Raycast>();
    }

    
    
    // Saltos y doble saltos
    void Update()
    {
        if (ground.grounded)
        {
            jumps = jumps_max;
        }

        if(Input.GetButtonDown("Jump") && jumps > 0) 
        {
            jumps--;
            if (ground.grounded)
            {
                rb.AddForce(new Vector2(0, force));
            }
            else
            {
                rb.AddForce(new Vector2(0, force_air));
            }
        }
       
    }
}
