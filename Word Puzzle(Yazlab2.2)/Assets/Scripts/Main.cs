using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static int skor = 0;
    public static int time = 0;
    public InputField textBox;
 

    public void YenidenBasla()
    {
        PlayerPrefs.SetString("name", textBox.text);
        //Oyunu başlatacak kısım.
        SceneManager.LoadScene("LevelSec");
    }
    public void OyunaDevam()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("levelAdi"));
    }
    public void Skorlar()
    {
        SceneManager.LoadScene("SkorMenu");
    }
    public void OyundanCik()
    {
        Application.Quit();
    }

}
