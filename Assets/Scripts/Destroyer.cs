using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D gObject)
    {
        //When object collides with player, destoy this gameobject
        if (gObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
