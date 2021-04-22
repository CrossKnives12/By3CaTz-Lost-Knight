using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaizoMove : MonoBehaviour
{
    public float speed;
    public bool isKaizoMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isKaizoMoving == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D Kaizo)
    {
        if (Kaizo.CompareTag("KaizoStop"))
        {
            isKaizoMoving = false;
        }
    }
}
