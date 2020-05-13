using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkorMenu : MonoBehaviour
{
    public Transform enYuksekSkorlar;

    // Start is called before the first frame update
    void Start()
    {
        enYuksekSkorlar.GetComponent<Text>().text = "İsim: " + PlayerPrefs.GetString("nameHigh11") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt11") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh12") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt12") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh13") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt13") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh14") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt14") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh15") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt15") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh16") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt16") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh21") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt21") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh22") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt22") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh23") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt23") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh24") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt24") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh25") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt25") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh26") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt26") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh31") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt31") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh32") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt32") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh33") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt33") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh34") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt34") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh35") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt35") + "\n" +
                                                    "İsim: " + PlayerPrefs.GetString("nameHigh36") + "   " + "Puan: " + PlayerPrefs.GetInt("Alt36") + "\n";

    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
}
