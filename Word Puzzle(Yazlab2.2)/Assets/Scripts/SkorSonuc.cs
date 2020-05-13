using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class SkorSonuc : MonoBehaviour
{
    public Transform skor;
    public static string levelAdı = "";
    public static int toplamSkor = 0;
    // Start is called before the first frame update
     void Start()
    {
        skor.GetComponent<Text>().text = "SKOR:" + toplamSkor;       
    }


    //bolum bitti
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    //yeni level
    public void yeniLevel()
    {
        if (levelAdı == "level 1")
        {
            SceneManager.LoadScene("level 2");
        }
        else if (levelAdı == "level 2")
        {
            SceneManager.LoadScene("level 3");
        }
        else if (levelAdı == "level 3")
        {
            SceneManager.LoadScene("LevelSec");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
