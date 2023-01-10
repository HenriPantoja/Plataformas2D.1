using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private SoundManager soundManager;
    public int valor = 1;
    public GameManager gameManager;
    // Start is called before the first frame update
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            soundManager.SeleccionAudio(0, 0.5f);
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }
}
