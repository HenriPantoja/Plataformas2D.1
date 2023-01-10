using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Video;
public class Vida : MonoBehaviour
{
  

    [SerializeField] int vidas;
    [SerializeField] Slider sliderVidas;
    
    // Start is called before the first frame update
    private void Start()
    {
        sliderVidas.maxValue = vidas;
        sliderVidas.value = sliderVidas.maxValue;
    }
    private void OnCollisionEnter2D(Collision2D otro)
    {
        if (otro.gameObject.CompareTag("Enemy")) 
        {
            vidas--;
            sliderVidas.value = vidas;

            if (vidas <=0)
            {
                Destroy(this.gameObject);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
