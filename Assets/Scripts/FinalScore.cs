using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Call using TMPro when using the UI text - TextMesh

public class FinalScore : MonoBehaviour
{
    //Text Mesh Pro (TMPro) is a Unity addon that has better font display
    //Instead of "public text var", use "TMP_Text" since font used is converted to Text Mesh Pro
    public TMP_Text intBox;

    public int value1, value2, value3;
    private int totalValue;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.GetInt("var") is to get stored data in the project

        value1 = PlayerPrefs.GetInt("pScoreOne");
        value2 = PlayerPrefs.GetInt("pScoreTwo");
        value3 = PlayerPrefs.GetInt("pScoreThree");

        totalValue = value1 + value2 + value3;

        intBox.text = totalValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
