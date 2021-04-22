using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySaw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D gSaw)
    {
        if (gSaw.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
