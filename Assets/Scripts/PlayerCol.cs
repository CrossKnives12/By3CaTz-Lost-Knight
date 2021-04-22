using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCol : MonoBehaviour
{
    PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        //current scene will restart when player collides with any object with the following tags:
        if (Col.CompareTag("Trap"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Col.CompareTag("Bounds"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Col.CompareTag("KaizoB"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //when player moves to a chest, this prevents player from moving on that specific scene
        else if (Col.CompareTag("Chest"))
        {
            pc.playerRun = false;
        }
    }
}
