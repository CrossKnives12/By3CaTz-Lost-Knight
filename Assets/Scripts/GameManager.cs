using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //this is how to getcomponent from another script of another gameobject
    public GameObject coin;
    private PlayerScore ps;

    public GameObject knight;
    private PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        ps = coin.GetComponent<PlayerScore>();
        pc = knight.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        //PlayerPrefs.SetInt("var", var) is to store data in the project that could be used in another scene

        if (sceneName == "Level1" && pc.playerRun == false)
        {
            PlayerPrefs.SetInt("pScoreOne", ps.coin);
        }
        else if (sceneName == "Level2" && pc.playerRun == false)
        {
            PlayerPrefs.SetInt("pScoreTwo", ps.coin);
        }
        else if (sceneName == "Level3" && pc.playerRun == false)
        {
            PlayerPrefs.SetInt("pScoreThree", ps.coin);
        }
    }
}
