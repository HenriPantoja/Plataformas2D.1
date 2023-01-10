using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Detector de colision
public class GroundDetector_Trigger : MonoBehaviour
{
    public bool grounded;

 
    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;    
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
    //Detector de colision
}
