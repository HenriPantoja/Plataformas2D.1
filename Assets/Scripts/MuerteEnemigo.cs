using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteEnemigo : MonoBehaviour
{
    [SerializeField] private GameObject efecto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Golpe()
    {
        Instantiate(efecto, transform.position, transform.rotation);
        Destroy(gameObject);
    
    }
}
