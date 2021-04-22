using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(LevelTwo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D ChestOne)
    {
        SceneManager.LoadScene("Level2");
    }
}
