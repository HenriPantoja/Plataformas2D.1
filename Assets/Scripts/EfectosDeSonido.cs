using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosDeSonidos : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip coletar1;




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(coletar1);
            Destroy(gameObject);
        }
    }





}