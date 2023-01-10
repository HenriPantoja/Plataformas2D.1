using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform personaje;

    private float tamanoCamara;
    private float alturaPantalla;
    // Start is called before the first frame update
    void Start()
    {
        tamanoCamara= Camera.main.orthographicSize;
        alturaPantalla = tamanoCamara * 2; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void CalcularPosicionCamera()
    {
        int pantallaPersonaje =(int)(personaje.position.y / alturaPantalla);
        float alturaCamera = (pantallaPersonaje * alturaPantalla) + tamanoCamara;

        transform.position = new Vector3(transform.position.x, alturaCamera, transform.position.z);
    }
}
