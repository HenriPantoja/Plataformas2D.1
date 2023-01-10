using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour
{
 

    public PausaManager pausaM;

    public float speed = 10;
    GroundDetector_Raycast ground;
    Animator anim;
    // rapidez de movimiento
    void Start()
    {
       ground = GetComponent<GroundDetector_Raycast>(); 
        anim = GetComponent<Animator>();
       
    }

    // Movimiento Horizontales
    void Update()
    {
        if(pausaM.enPausa == true) 
        {
            return;
        }
        

        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        transform.position = transform.position + new Vector3(horizontal * Time.deltaTime * speed, 0);
        anim.SetBool("grounded", ground.grounded);
        anim.SetBool("moving", horizontal != 0);
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
        
    

    }
 }

