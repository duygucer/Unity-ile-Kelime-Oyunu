using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class gmScript : MonoBehaviour
{
    //BolumTamamlandi
    public SkorSonuc yeni;
    public static string ActiveScene = "";
    public static string LevelAc = "";
    public static string currentWord;
    public Transform spelledWord;
    public Transform skorPanel;
    //6 seviye için gerekli harfler
    public Transform letter1; public Transform letter2; public Transform letter3; public Transform letter4; public Transform letter5; public Transform letter6; public Transform letter7;
    public Transform letter8; public Transform letter9; public Transform letter10; public Transform letter11; public Transform letter12; public Transform letter13; public Transform letter14;
    public Transform letter15; public Transform letter16; public Transform letter17; public Transform letter18; public Transform letter19; public Transform letter20; public Transform letter21;
    public Transform letter22; public Transform letter23; public Transform letter24; public Transform letter25; public Transform letter26; public Transform letter27; public Transform letter28;
    public Transform letter29; public Transform letter30; public Transform letter31; public Transform letter32; public Transform letter33; public Transform letter34; public Transform letter35;
    public Transform letter36; public Transform letter37; public Transform letter38; public Transform letter39; public Transform letter40; public Transform letter41; public Transform letter42;
    public Transform letter43; public Transform letter44; public Transform letter45; public Transform letter46; public Transform letter47; public Transform letter48; public Transform letter49;
    public Transform letter50; public Transform letter51; public Transform letter52; public Transform letter53; public Transform letter54; public Transform letter55; public Transform letter56;
    public Transform letter57; public Transform letter58; public Transform letter59; public Transform letter60; public Transform letter61; public Transform letter62; public Transform letter63;
    public Transform letter64; public Transform letter65; public Transform letter66; public Transform letter67; public Transform letter68; public Transform letter69; public Transform letter70;

    public Transform bottomL1Obj; public Transform bottomL2Obj; public Transform bottomL3Obj;
    public Transform bottomL4Obj; public Transform bottomL5Obj; public Transform bottomL6Obj;
    public Transform bottomL7Obj; public Transform bottomL8Obj; public Transform bottomL9Obj;
    public Transform bottomL10Obj;

    public List<string> availLetter1 = new List<string>() { "S", "A", "A", "A", "K" };
    public List<string> availLetter2 = new List<string>() { "I", "Y", "S", "O", "A" };
    public List<string> availLetter3 = new List<string>() { "R", "A", "K", "R", "I" };
    public List<string> availLetter4 = new List<string>() { "A", "K", "I", "T", "R" };
    public List<string> availLetter5 = new List<string>() { "L", "İ", "Y", "A", "İ" };
    public List<string> availLetter6 = new List<string>() { "", "", "", "L", "S" };
    public List<string> availLetter7 = new List<string>() { "", "", "", "", "N" };
    public KeyCode RMB;
    public int wordLen;
    //wordlist seviye 1 
    public string wordS1L = "ZAR"; public string wordS1L2 = "ARZ";
    public string wordS1L3 = "MİS"; public string wordS1L4 = "SİM";
    public string wordS1L5 = "ÇAK"; public string wordS1L6 = "KAÇ";
    public string wordS1L7 = "TAM"; public string wordS1L8 = "MAT";
    public string wordS1L9 = "ŞAK"; public string wordS1L10 = "KAŞ"; public string wordS1L11 = "AŞK";
    public string wordS1L12 = "AKS"; public string wordS1L13 = "ASK"; public string wordS1L14 = "SAK"; public string wordS1L15 = "KAS";
    //wordlist Seviye 2 3 harf
    public string word3L = "KAN";
    public string word3L1 = "ARI"; public string word3L2 = "SIR";
    public string word3L3 = "ORA";
    public string word3L4 = "TAR"; public string word3L5 = "ARK";
    //wordlist seviye 2 4 harf
    public string word4L = "AKNE";
    public string word4L1 = "AYAK"; public string word4L2 = "KAYA"; public string word4L3 = "YAKA";
    public string word4L4 = "SIRA"; public string word4L5 = "SARI";
    public string word4L6 = "KISA"; public string word4L7 = "ISKA"; public string word4L8 = "ASIK"; public string word4L9 = "ASKI";
    public string word4L10 = "KARI"; public string word4L11 = "ARIK"; public string word4L12 = "RAKI"; public string word4L13 = "IRAK";
    public string word4L14 = "ORTA"; public string word4L15 = "AORT"; public string word4L16 = "ROTA";
    //wordlist 3.seviye
    //alt seviye 1 5 kelime
    public string wordT3L = "TAS"; public string wordT4L = "KASE"; public string wordT4L2 = "KAST"; public string wordT5L = "KASET"; public string wordT5L2 = "KESAT";
    //alt seviye 2 5 kelime
    public string wordT4L3 = "MANA"; public string wordT4L4 = "ANMA"; public string wordT4L5 = "LAMA"; public string wordT5L3 = "ANLAM"; public string wordT5L4 = "ALMAN";
    //alt seviye 3 6 kelime
    public string wordT4L6 = "ESİR"; public string wordT4L7 = "PERİ"; public string wordT4L8 = "PİRE"; public string wordT4L9 = "PRES"; public string wordT5L5 = "ESPRİ"; public string wordT5L6 = "SİPER";
    //alt seviye 4 5 kelime
    public string wordT4L10 = "AYAK"; public string wordT4L11 = "KAYA"; public string wordT5L7 = "KALAY"; public string wordT5L8 = "AYLAK"; public string wordT5L9 = "YALAK";
    //alt seviye 5 8 kelime
    public string wordT3L2 = "MAL"; public string wordT3L3 = "AĞA"; public string wordT3L4 = "ASA"; public string wordT4L12 = "ASAL"; public string wordT4L13 = "ASMA"; public string wordT4L14 = "ASLA"; public string wordT5L10 = "MASAL"; public string wordT6L = "SAĞLAM";
    //alt seviye 6 12 kelime
    public string wordT3L5 = "SİS"; public string wordT3L6 = "SES"; public string wordT3L7 = "SİT"; public string wordT3L8 = "SET"; public string wordT4L15 = "TEST"; public string wordT4L16 = "ESİN"; public string wordT4L17 = "SİNE"; public string wordT4L18 = "SİTE"; public string wordT5L11 = "TESİS"; public string wordT5L12 = "TENİS"; public string wordT5L13 = "TESTİ"; public string wordT6L2 = "TESTİS";

    public AudioSource audioSource;
    [SerializeField]
    public AudioClip dogruSesi, yanlisSesi;

    public static List<string> bulunanKelimeler = new List<string>();
    public static List<string> selectLetter = new List<string>() { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
    public static int letterNum = 0;
    public static List<Vector3> positions = new List<Vector3>();
    public static List<string> tumHarfler = new List<string>() { "A", "K", "N", "E","","","" };
    public static List<int> randomdeger = new List<int>();
    //linerenderer
    private LineRenderer line;
    private Vector3 mouseLoc;
    private bool canDrawLine = true;
    public bool drawingLine = false;
    private int lineCount = 0;

    public float timeStart = 0.0f;
    int hatalideneme = 0;
    public int bulunanKelimeSayisi = 0;
    public int toplam = 0;


    // Update is called once per frame
    void Update()
    {

        //yeni level için
        Scene scene = SceneManager.GetActiveScene();
        LevelAc = scene.name;
        //zaman icin
        timeStart += Time.deltaTime;
        zamanSayac();
        if (Input.GetMouseButton(0) && drawingLine)
        {
            mouseLoc = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10.0f);
            line.SetPosition(lineCount, mouseLoc);
            canDrawLine = false;
        }
        else if (Input.GetMouseButtonUp(0) && drawingLine)
        {
            drawingLine = false;
            line.SetPosition(lineCount, mouseLoc);
            canDrawLine = true;
            spelledWord.GetComponent<TextMesh>().text = "";
            lineCount = 0;
            letterNum = 0;
            line.positionCount = 0;
            positions.Clear();
            if (LevelAc == "level 1")
            {
                level1();
            }
            if (LevelAc == "level 2")
            {
                kelimeBulundu();
            }
            if (LevelAc == "level 3")
            {
                level3();
            }
            currentWord = "";
        }
        spelledWord.GetComponent<TextMesh>().text = currentWord;
    }
    //level 1
    public void level1()
    {
        Scene scene1 = SceneManager.GetActiveScene();
        ActiveScene = scene1.name;
        PlayerPrefs.SetString("levelAdi", ActiveScene);
        availLetter1 = new List<string>() { "S", "Ç", "T", "A", "K" };
        availLetter2 = new List<string>() { "İ", "A", "A", "K", "A" };
        availLetter3 = new List<string>() { "M", "K", "M", "Ş", "S" };

        spelledWord.GetComponent<TextMesh>().text = currentWord;
        if (Input.GetKeyUp(RMB))
        {
            wordLen = currentWord.Length;
        }

        //altlevel1 2 8 9 10 14
        if (bulunanKelimeSayisi < 2)
        {
            letter2.parent.gameObject.SetActive(true);
            letter8.parent.gameObject.SetActive(true);
            letter9.parent.gameObject.SetActive(true);
            letter10.parent.gameObject.SetActive(true);
            letter14.parent.gameObject.SetActive(true);
            if (wordLen == 3)
            {
                if (currentWord == wordS1L && !bulunanKelimeler.Contains(wordS1L))
                {
                    Debug.Log("Correct 3 letter word");
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter2.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[2];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[3];
                    letter14.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordS1L);
                    puanHesap();           
                    if (bulunanKelimeSayisi == 2)
                    {
                        if (PlayerPrefs.GetInt("Alt11") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt11", Main.skor);
                            PlayerPrefs.SetString("nameHigh11", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L2 && !bulunanKelimeler.Contains(wordS1L2))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordS1L2);
                    puanHesap();
                    if (bulunanKelimeSayisi == 2)
                    {
                        if (PlayerPrefs.GetInt("Alt11") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt11", Main.skor);
                            PlayerPrefs.SetString("nameHigh11", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (currentWord == wordS1L && bulunanKelimeler.Contains(wordS1L) || currentWord == wordS1L2 && bulunanKelimeler.Contains(wordS1L2))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 3 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);

            }
        }
        //altlevel2 3 8 9 10 15
        if (bulunanKelimeSayisi < 4 && bulunanKelimeSayisi >= 2)
        {
            if (bulunanKelimeSayisi == 2)
            {        
                letter2.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[0];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[0];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[0];
            letter2.parent.gameObject.SetActive(false);
            letter14.parent.gameObject.SetActive(false);
            letter3.parent.gameObject.SetActive(true);
            letter15.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == wordS1L3 && !bulunanKelimeler.Contains(wordS1L3))
                {
                    Debug.Log("Correct 3 letter word");
                    letter3.GetComponent<TextMesh>().text = selectLetter[1];
                    letter3.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[3];
                    letter15.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L3);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 4)
                    {
                        if (PlayerPrefs.GetInt("Alt12") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt12", Main.skor);
                            PlayerPrefs.SetString("nameHigh12", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L4 && !bulunanKelimeler.Contains(wordS1L4))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L4);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 4)
                    {
                        if (PlayerPrefs.GetInt("Alt12") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt12", Main.skor);
                            PlayerPrefs.SetString("nameHigh12", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L3 && bulunanKelimeler.Contains(wordS1L3) || currentWord == wordS1L4 && bulunanKelimeler.Contains(wordS1L4))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordS1L && currentWord != wordS1L2)
                    {
                        Debug.Log("Wrong 3 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);

                    }

                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);

            }
        }
        //altlevel3 8 9 10 16 22
        if (bulunanKelimeSayisi >= 4 && bulunanKelimeSayisi < 6)
        {
            if (bulunanKelimeSayisi == 4)
            {
                letter3.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter15.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[1];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[1];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[1];
            //önceki bulmacayı gizle
            letter3.parent.gameObject.SetActive(false);
            letter15.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter16.parent.gameObject.SetActive(true);
            letter22.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == wordS1L5 && !bulunanKelimeler.Contains(wordS1L5))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L5);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 6)
                    {
                        if (PlayerPrefs.GetInt("Alt13") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt13", Main.skor);
                            PlayerPrefs.SetString("nameHigh13", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L6 && !bulunanKelimeler.Contains(wordS1L6))
                {
                    Debug.Log("Correct 3 letter word");
                    letter10.GetComponent<TextMesh>().text = selectLetter[1];
                    letter10.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[2];
                    letter16.gameObject.SetActive(true);
                    letter22.GetComponent<TextMesh>().text = selectLetter[3];
                    letter22.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L6);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 6)
                    {
                        if (PlayerPrefs.GetInt("Alt13") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt13", Main.skor);
                            PlayerPrefs.SetString("nameHigh13", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L6 && bulunanKelimeler.Contains(wordS1L6) || currentWord == wordS1L5 && bulunanKelimeler.Contains(wordS1L5))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordS1L3 && currentWord != wordS1L4)
                    {
                        Debug.Log("Wrong 3 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel4 3 8 9 10 15
        if (bulunanKelimeSayisi >= 6 && bulunanKelimeSayisi < 8)
        {
            if (bulunanKelimeSayisi == 6)
            {
                letter8.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = "";
                letter22.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[2];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[2];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[2];
            //önceki bulmacayı gizle
            letter16.parent.gameObject.SetActive(false);
            letter22.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter3.parent.gameObject.SetActive(true);
            letter15.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == wordS1L7 && !bulunanKelimeler.Contains(wordS1L7))
                {
                    Debug.Log("Correct 3 letter word");
                    letter3.GetComponent<TextMesh>().text = selectLetter[1];
                    letter3.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[3];
                    letter15.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L7);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 8)
                    {
                        if (PlayerPrefs.GetInt("Alt14") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt14", Main.skor);
                            PlayerPrefs.SetString("nameHigh14", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L8 && !bulunanKelimeler.Contains(wordS1L8))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L8);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 8)
                    {
                        if (PlayerPrefs.GetInt("Alt14") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt14", Main.skor);
                            PlayerPrefs.SetString("nameHigh14", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L7 && bulunanKelimeler.Contains(wordS1L7) || currentWord == wordS1L8 && bulunanKelimeler.Contains(wordS1L8))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordS1L5 && currentWord != wordS1L6)
                    {
                        Debug.Log("Wrong 3 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel5 2 8 10 14 15 16 22 
        if (bulunanKelimeSayisi >= 8 && bulunanKelimeSayisi < 11)
        {
            if (bulunanKelimeSayisi == 8)
            {
                letter3.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter15.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[3];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[3];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[3];
            //önceki bulmacayı gizle
            letter3.parent.gameObject.SetActive(false);
            letter9.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter2.parent.gameObject.SetActive(true);
            letter14.parent.gameObject.SetActive(true);
            letter16.parent.gameObject.SetActive(true);
            letter22.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == wordS1L9 && !bulunanKelimeler.Contains(wordS1L9))
                {
                    Debug.Log("Correct 3 letter word");
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter2.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[2];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[3];
                    letter14.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L9);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 11)
                    {
                        if (PlayerPrefs.GetInt("Alt15") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt15", Main.skor);
                            PlayerPrefs.SetString("nameHigh15", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L10 && !bulunanKelimeler.Contains(wordS1L10))
                {
                    Debug.Log("Correct 3 letter word");
                    letter14.GetComponent<TextMesh>().text = selectLetter[1];
                    letter14.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[2];
                    letter15.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[3];
                    letter16.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L10);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 11)
                    {
                        if (PlayerPrefs.GetInt("Alt15") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt15", Main.skor);
                            PlayerPrefs.SetString("nameHigh15", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L11 && !bulunanKelimeler.Contains(wordS1L11))
                {
                    Debug.Log("Correct 3 letter word");
                    letter10.GetComponent<TextMesh>().text = selectLetter[1];
                    letter10.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[2];
                    letter16.gameObject.SetActive(true);
                    letter22.GetComponent<TextMesh>().text = selectLetter[3];
                    letter22.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L11);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 11)
                    {
                        if (PlayerPrefs.GetInt("Alt15") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt15", Main.skor);
                            PlayerPrefs.SetString("nameHigh15", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L9 && bulunanKelimeler.Contains(wordS1L9) || currentWord == wordS1L10 && bulunanKelimeler.Contains(wordS1L10) || currentWord == wordS1L11 && bulunanKelimeler.Contains(wordS1L11))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordS1L7 && currentWord != wordS1L8)
                    {
                        Debug.Log("Wrong 3 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel6 8 9 10 14 16 20 22 23 24
        if (bulunanKelimeSayisi >= 11 && bulunanKelimeSayisi < 15)
        {
            if (bulunanKelimeSayisi == 11)
            {
                letter2.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter15.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = "";
                letter22.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[4];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[4];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[4];
            //önceki bulmacayı gizle
            letter2.parent.gameObject.SetActive(false);
            letter15.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter9.parent.gameObject.SetActive(true);
            letter20.parent.gameObject.SetActive(true);
            letter23.parent.gameObject.SetActive(true);
            letter24.parent.gameObject.SetActive(true);
            if (wordLen == 3)
            {
                if (currentWord == wordS1L12 && !bulunanKelimeler.Contains(wordS1L12))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L12);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 15)
                    {
                        if (PlayerPrefs.GetInt("Alt16") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt16", Main.skor);
                            PlayerPrefs.SetString("nameHigh16", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L13 && !bulunanKelimeler.Contains(wordS1L13))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[2];
                    letter14.gameObject.SetActive(true);
                    letter20.GetComponent<TextMesh>().text = selectLetter[3];
                    letter20.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L13);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 15)
                    {
                        if (PlayerPrefs.GetInt("Alt16") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt16", Main.skor);
                            PlayerPrefs.SetString("nameHigh16", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L14 && !bulunanKelimeler.Contains(wordS1L14))
                {
                    Debug.Log("Correct 3 letter word");
                    letter10.GetComponent<TextMesh>().text = selectLetter[1];
                    letter10.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[2];
                    letter16.gameObject.SetActive(true);
                    letter22.GetComponent<TextMesh>().text = selectLetter[3];
                    letter22.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L14);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 15)
                    {
                        if (PlayerPrefs.GetInt("Alt16") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt16", Main.skor);
                            PlayerPrefs.SetString("nameHigh16", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L15 && !bulunanKelimeler.Contains(wordS1L15))
                {
                    Debug.Log("Correct 3 letter word");
                    letter22.GetComponent<TextMesh>().text = selectLetter[1];
                    letter22.gameObject.SetActive(true);
                    letter23.GetComponent<TextMesh>().text = selectLetter[2];
                    letter23.gameObject.SetActive(true);
                    letter24.GetComponent<TextMesh>().text = selectLetter[3];
                    letter24.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordS1L15);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 15)
                    {
                        if (PlayerPrefs.GetInt("Alt16") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt16", Main.skor);
                            PlayerPrefs.SetString("nameHigh16", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordS1L12 && bulunanKelimeler.Contains(wordS1L12) || currentWord == wordS1L13 && bulunanKelimeler.Contains(wordS1L13) || currentWord == wordS1L14 && bulunanKelimeler.Contains(wordS1L14) || currentWord == wordS1L15 && bulunanKelimeler.Contains(wordS1L15))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordS1L9 && currentWord != wordS1L10 && currentWord != wordS1L11)
                    {
                        Debug.Log("Wrong 3 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        if (bulunanKelimeSayisi == 15)
        {
            Scene scene = SceneManager.GetActiveScene();
            ActiveScene = scene.name;
            bulunanKelimeler.Clear();
            bulunanKelimeSayisi = 0;
            Debug.Log("ActiveScene name:" + ActiveScene);
            SkorSonuc.toplamSkor = toplam;
            toplam = 0;
            SkorSonuc.levelAdı = ActiveScene;
            PlayerPrefs.SetString("levelAdi", "level 2");
            SceneManager.LoadScene("BolumTamamlandi");


        }
    }
    //level 2
    public void kelimeBulundu()
    {
        Scene scene2 = SceneManager.GetActiveScene();
        ActiveScene = scene2.name;
        PlayerPrefs.SetString("levelAdi", ActiveScene);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        if (Input.GetKeyUp(RMB))
        {
            wordLen = currentWord.Length;
        }

        //altlevel1 2 8 9 10 11 14
        if (bulunanKelimeSayisi < 2)
        {
            letter2.parent.gameObject.SetActive(true);
            letter8.parent.gameObject.SetActive(true);
            letter9.parent.gameObject.SetActive(true);
            letter10.parent.gameObject.SetActive(true);
            letter11.parent.gameObject.SetActive(true);
            letter14.parent.gameObject.SetActive(true);
            if (wordLen == 3)
            {
                if (currentWord == word3L && !bulunanKelimeler.Contains(word3L))
                {
                    Debug.Log("Correct 3 letter word");
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter2.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[2];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[3];
                    letter14.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(word3L);
                    puanHesap();
                    if (bulunanKelimeSayisi == 2)
                    {
                        if (PlayerPrefs.GetInt("Alt21") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt21", Main.skor);
                            PlayerPrefs.SetString("nameHigh21", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word3L))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 3 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            else if (wordLen == 4)
            {
                if (currentWord == word4L && !bulunanKelimeler.Contains(word4L))
                {
                    Debug.Log("Correct 4 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    letter11.GetComponent<TextMesh>().text = selectLetter[4];
                    letter11.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(word4L);
                    puanHesap();
                    if (bulunanKelimeSayisi == 2)
                    {
                        if (PlayerPrefs.GetInt("Alt21") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt21", Main.skor);
                            PlayerPrefs.SetString("nameHigh21", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (bulunanKelimeler.Contains(word4L))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 4 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel2 2 3 4 5 8 11 14 17 19 20 21
        if (bulunanKelimeSayisi < 6 && bulunanKelimeSayisi >= 2)
        {
            if (bulunanKelimeSayisi == 2)
            {
                letter2.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter11.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[0];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[0];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[0];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[0];

            letter9.parent.gameObject.SetActive(false);
            letter10.parent.gameObject.SetActive(false);
            letter3.parent.gameObject.SetActive(true);
            letter4.parent.gameObject.SetActive(true);
            letter5.parent.gameObject.SetActive(true);
            letter17.parent.gameObject.SetActive(true);
            letter19.parent.gameObject.SetActive(true);
            letter20.parent.gameObject.SetActive(true);
            letter21.parent.gameObject.SetActive(true);
            if (wordLen == 3)
            {
                if (currentWord == word3L1 && !bulunanKelimeler.Contains(word3L1))
                {
                    Debug.Log("Correct 3 letter word");
                    letter5.GetComponent<TextMesh>().text = selectLetter[1];
                    letter5.gameObject.SetActive(true);
                    letter11.GetComponent<TextMesh>().text = selectLetter[2];
                    letter11.gameObject.SetActive(true);
                    letter17.GetComponent<TextMesh>().text = selectLetter[3];
                    letter17.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word3L1);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 6)
                    {
                        if (PlayerPrefs.GetInt("Alt22") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt22", Main.skor);
                            PlayerPrefs.SetString("nameHigh22", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word3L2 && !bulunanKelimeler.Contains(word3L2))
                {
                    Debug.Log("Correct 3 letter word");
                    letter19.GetComponent<TextMesh>().text = selectLetter[1];
                    letter19.gameObject.SetActive(true);
                    letter20.GetComponent<TextMesh>().text = selectLetter[2];
                    letter20.gameObject.SetActive(true);
                    letter21.GetComponent<TextMesh>().text = selectLetter[3];
                    letter21.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word3L2);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 6)
                    {
                        if (PlayerPrefs.GetInt("Alt22") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt22", Main.skor);
                            PlayerPrefs.SetString("nameHigh22", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (bulunanKelimeler.Contains(word3L1) || bulunanKelimeler.Contains(word3L2))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != word3L)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 4)
            {
                if (currentWord == word4L4 && !bulunanKelimeler.Contains(word4L4))
                {
                    Debug.Log("Correct 4 letter word");
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter2.gameObject.SetActive(true);
                    letter3.GetComponent<TextMesh>().text = selectLetter[2];
                    letter3.gameObject.SetActive(true);
                    letter4.GetComponent<TextMesh>().text = selectLetter[3];
                    letter4.gameObject.SetActive(true);
                    letter5.GetComponent<TextMesh>().text = selectLetter[4];
                    letter5.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L4);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 6)
                    {
                        if (PlayerPrefs.GetInt("Alt22") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt22", Main.skor);
                            PlayerPrefs.SetString("nameHigh22", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L5 && !bulunanKelimeler.Contains(word4L5))
                {
                    Debug.Log("Correct 4 letter word");
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter2.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[2];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[3];
                    letter14.gameObject.SetActive(true);
                    letter20.GetComponent<TextMesh>().text = selectLetter[4];
                    letter20.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L5);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 6)
                    {
                        if (PlayerPrefs.GetInt("Alt22") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt22", Main.skor);
                            PlayerPrefs.SetString("nameHigh22", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word4L4) || bulunanKelimeler.Contains(word4L5))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != word4L)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel3 4 8 9 10 11 16 20 21 22 23
        if (bulunanKelimeSayisi >= 6 && bulunanKelimeSayisi < 9)
        {
            if (bulunanKelimeSayisi == 6)
            {
                letter2.GetComponent<TextMesh>().text = "";
                letter3.GetComponent<TextMesh>().text = "";
                letter4.GetComponent<TextMesh>().text = "";
                letter5.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter11.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter17.GetComponent<TextMesh>().text = "";
                letter19.GetComponent<TextMesh>().text = "";
                letter20.GetComponent<TextMesh>().text = "";
                letter21.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[1];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[1];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[1];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[1];
            //önceki bulmacayı gizle
            letter2.parent.gameObject.SetActive(false);
            letter3.parent.gameObject.SetActive(false);
            letter5.parent.gameObject.SetActive(false);
            letter14.parent.gameObject.SetActive(false);
            letter17.parent.gameObject.SetActive(false);
            letter19.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter9.parent.gameObject.SetActive(true);
            letter10.parent.gameObject.SetActive(true);
            letter16.parent.gameObject.SetActive(true);
            letter22.parent.gameObject.SetActive(true);
            letter23.parent.gameObject.SetActive(true);

            if (wordLen == 4)
            {
                if (currentWord == word4L1 && !bulunanKelimeler.Contains(word4L1))
                {
                    Debug.Log("Correct 4 letter word");
                    letter4.GetComponent<TextMesh>().text = selectLetter[1];
                    letter4.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[2];
                    letter10.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[3];
                    letter16.gameObject.SetActive(true);
                    letter22.GetComponent<TextMesh>().text = selectLetter[4];
                    letter22.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L1);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 9)
                    {
                        if (PlayerPrefs.GetInt("Alt23") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt23", Main.skor);
                            PlayerPrefs.SetString("nameHigh23", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L2 && !bulunanKelimeler.Contains(word4L2))
                {
                    Debug.Log("Correct 4 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    letter11.GetComponent<TextMesh>().text = selectLetter[4];
                    letter11.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L2);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 9)
                    {
                        if (PlayerPrefs.GetInt("Alt23") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt23", Main.skor);
                            PlayerPrefs.SetString("nameHigh23", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L3 && !bulunanKelimeler.Contains(word4L3))
                {
                    Debug.Log("Correct 4 letter word");
                    letter20.GetComponent<TextMesh>().text = selectLetter[1];
                    letter20.gameObject.SetActive(true);
                    letter21.GetComponent<TextMesh>().text = selectLetter[2];
                    letter21.gameObject.SetActive(true);
                    letter22.GetComponent<TextMesh>().text = selectLetter[3];
                    letter22.gameObject.SetActive(true);
                    letter23.GetComponent<TextMesh>().text = selectLetter[4];
                    letter23.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L3);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 9)
                    {
                        if (PlayerPrefs.GetInt("Alt23") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt23", Main.skor);
                            PlayerPrefs.SetString("nameHigh23", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word4L1) || bulunanKelimeler.Contains(word4L2) || bulunanKelimeler.Contains(word4L3))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != word3L1 && currentWord != word3L2 && currentWord != word4L4 && currentWord != word4L5)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel4 2 3 4 5 8 11 14 15 16 17 23 32
        if (bulunanKelimeSayisi >= 9 && bulunanKelimeSayisi < 13)
        {
            if (bulunanKelimeSayisi == 9)
            {
                letter2.GetComponent<TextMesh>().text = "";
                letter3.GetComponent<TextMesh>().text = "";
                letter4.GetComponent<TextMesh>().text = "";
                letter5.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter11.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = "";
                letter17.GetComponent<TextMesh>().text = "";
                letter19.GetComponent<TextMesh>().text = "";
                letter20.GetComponent<TextMesh>().text = "";
                letter21.GetComponent<TextMesh>().text = "";
                letter23.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[2];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[2];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[2];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[2];
            //önceki bulmacayı gizle
            letter9.parent.gameObject.SetActive(false);
            letter10.parent.gameObject.SetActive(false);
            letter20.parent.gameObject.SetActive(false);
            letter21.parent.gameObject.SetActive(false);
            letter22.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter2.parent.gameObject.SetActive(true);
            letter3.parent.gameObject.SetActive(true);
            letter5.parent.gameObject.SetActive(true);
            letter14.parent.gameObject.SetActive(true);
            letter15.parent.gameObject.SetActive(true);
            letter17.parent.gameObject.SetActive(true);
            letter32.parent.gameObject.SetActive(true);

            if (wordLen == 4)
            {
                if (currentWord == word4L6 && !bulunanKelimeler.Contains(word4L6))
                {
                    Debug.Log("Correct 4 letter word");
                    letter32.GetComponent<TextMesh>().text = selectLetter[1];
                    letter32.gameObject.SetActive(true);
                    letter2.GetComponent<TextMesh>().text = selectLetter[2];
                    letter2.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[3];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[4];
                    letter14.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L6);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 13)
                    {
                        if (PlayerPrefs.GetInt("Alt24") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt24", Main.skor);
                            PlayerPrefs.SetString("nameHigh24", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L7 && !bulunanKelimeler.Contains(word4L7))
                {
                    Debug.Log("Correct 4 letter word");
                    letter2.GetComponent<TextMesh>().text = selectLetter[1];
                    letter2.gameObject.SetActive(true);
                    letter3.GetComponent<TextMesh>().text = selectLetter[2];
                    letter3.gameObject.SetActive(true);
                    letter4.GetComponent<TextMesh>().text = selectLetter[3];
                    letter4.gameObject.SetActive(true);
                    letter5.GetComponent<TextMesh>().text = selectLetter[4];
                    letter5.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L7);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 13)
                    {
                        if (PlayerPrefs.GetInt("Alt24") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt24", Main.skor);
                            PlayerPrefs.SetString("nameHigh24", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L8 && !bulunanKelimeler.Contains(word4L8))
                {
                    Debug.Log("Correct 4 letter word");
                    letter5.GetComponent<TextMesh>().text = selectLetter[1];
                    letter5.gameObject.SetActive(true);
                    letter11.GetComponent<TextMesh>().text = selectLetter[2];
                    letter11.gameObject.SetActive(true);
                    letter17.GetComponent<TextMesh>().text = selectLetter[3];
                    letter17.gameObject.SetActive(true);
                    letter23.GetComponent<TextMesh>().text = selectLetter[4];
                    letter23.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L8);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 13)
                    {
                        if (PlayerPrefs.GetInt("Alt24") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt24", Main.skor);
                            PlayerPrefs.SetString("nameHigh24", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L9 && !bulunanKelimeler.Contains(word4L9))
                {
                    Debug.Log("Correct 4 letter word");
                    letter14.GetComponent<TextMesh>().text = selectLetter[1];
                    letter14.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[2];
                    letter15.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[3];
                    letter16.gameObject.SetActive(true);
                    letter17.GetComponent<TextMesh>().text = selectLetter[4];
                    letter17.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L9);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 13)
                    {
                        if (PlayerPrefs.GetInt("Alt24") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt24", Main.skor);
                            PlayerPrefs.SetString("nameHigh24", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word4L6) || bulunanKelimeler.Contains(word4L7) || bulunanKelimeler.Contains(word4L8) || bulunanKelimeler.Contains(word4L9))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != word4L1 && currentWord != word4L2 && currentWord != word4L3)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel5 5 8 9 10 11 15 20 21 22 29 33 34 35 36
        if (bulunanKelimeSayisi >= 13 && bulunanKelimeSayisi < 18)
        {
            if (bulunanKelimeSayisi == 13)
            {
                letter2.GetComponent<TextMesh>().text = "";
                letter3.GetComponent<TextMesh>().text = "";
                letter4.GetComponent<TextMesh>().text = "";
                letter5.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter11.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter15.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = "";
                letter17.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter22.GetComponent<TextMesh>().text = "";
                letter32.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[3];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[3];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[3];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[3];
            //önceki bulmacayı gizle
            letter2.parent.gameObject.SetActive(false);
            letter3.parent.gameObject.SetActive(false);
            letter4.parent.gameObject.SetActive(false);
            letter14.parent.gameObject.SetActive(false);
            letter16.parent.gameObject.SetActive(false);
            letter17.parent.gameObject.SetActive(false);
            letter23.parent.gameObject.SetActive(false);
            letter32.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter9.parent.gameObject.SetActive(true);
            letter10.parent.gameObject.SetActive(true);
            letter20.parent.gameObject.SetActive(true);
            letter21.parent.gameObject.SetActive(true);
            letter22.parent.gameObject.SetActive(true);
            letter29.parent.gameObject.SetActive(true);
            letter33.parent.gameObject.SetActive(true);
            letter34.parent.gameObject.SetActive(true);
            letter35.parent.gameObject.SetActive(true);
            letter36.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == word3L3 && !bulunanKelimeler.Contains(word3L3))
                {
                    Debug.Log("Correct 3 letter word");
                    letter9.GetComponent<TextMesh>().text = selectLetter[1];
                    letter9.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[2];
                    letter15.gameObject.SetActive(true);
                    letter21.GetComponent<TextMesh>().text = selectLetter[3];
                    letter21.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word3L3);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 18)
                    {
                        if (PlayerPrefs.GetInt("Alt25") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt25", Main.skor);
                            PlayerPrefs.SetString("nameHigh25", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word3L4 && !bulunanKelimeler.Contains(word3L4))
                {
                    Debug.Log("Correct 3 letter word");
                    letter20.GetComponent<TextMesh>().text = selectLetter[1];
                    letter20.gameObject.SetActive(true);
                    letter21.GetComponent<TextMesh>().text = selectLetter[2];
                    letter21.gameObject.SetActive(true);
                    letter22.GetComponent<TextMesh>().text = selectLetter[3];
                    letter22.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word3L4);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 18)
                    {
                        if (PlayerPrefs.GetInt("Alt25") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt25", Main.skor);
                            PlayerPrefs.SetString("nameHigh25", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word3L3) || bulunanKelimeler.Contains(word3L4))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 3 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            if (wordLen == 4)
            {
                if (currentWord == word4L14 && !bulunanKelimeler.Contains(word4L14))
                {
                    Debug.Log("Correct 4 letter word");
                    letter29.GetComponent<TextMesh>().text = selectLetter[1];
                    letter29.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[2];
                    letter35.gameObject.SetActive(true);
                    letter5.GetComponent<TextMesh>().text = selectLetter[3];
                    letter5.gameObject.SetActive(true);
                    letter11.GetComponent<TextMesh>().text = selectLetter[4];
                    letter11.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L14);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 18)
                    {
                        if (PlayerPrefs.GetInt("Alt25") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt25", Main.skor);
                            PlayerPrefs.SetString("nameHigh25", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L15 && !bulunanKelimeler.Contains(word4L15))
                {
                    Debug.Log("Correct 4 letter word");
                    letter33.GetComponent<TextMesh>().text = selectLetter[1];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[2];
                    letter34.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[3];
                    letter35.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[4];
                    letter36.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L15);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 18)
                    {
                        if (PlayerPrefs.GetInt("Alt25") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt25", Main.skor);
                            PlayerPrefs.SetString("nameHigh25", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L16 && !bulunanKelimeler.Contains(word4L16))
                {
                    Debug.Log("Correct 4 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[2];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    letter11.GetComponent<TextMesh>().text = selectLetter[4];
                    letter11.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L16);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 18)
                    {
                        if (PlayerPrefs.GetInt("Alt25") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt25", Main.skor);
                            PlayerPrefs.SetString("nameHigh25", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }

                else if (bulunanKelimeler.Contains(word4L14) || bulunanKelimeler.Contains(word4L15) || bulunanKelimeler.Contains(word4L16))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != word4L6 && currentWord != word4L7 && currentWord != word4L8 && currentWord != word4L9)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel6 4 6 7 8 9 10 12 14 16 18 20 33 34 35 36
        if (bulunanKelimeSayisi >= 18 && bulunanKelimeSayisi < 23)
        {
            if (bulunanKelimeSayisi == 18)
            {
                letter5.GetComponent<TextMesh>().text = "";
                letter8.GetComponent<TextMesh>().text = "";
                letter9.GetComponent<TextMesh>().text = "";
                letter10.GetComponent<TextMesh>().text = "";
                letter11.GetComponent<TextMesh>().text = "";
                letter15.GetComponent<TextMesh>().text = "";
                letter20.GetComponent<TextMesh>().text = "";
                letter21.GetComponent<TextMesh>().text = "";
                letter22.GetComponent<TextMesh>().text = "";
                letter29.GetComponent<TextMesh>().text = "";
                letter33.GetComponent<TextMesh>().text = "";
                letter34.GetComponent<TextMesh>().text = "";
                letter35.GetComponent<TextMesh>().text = "";
                letter36.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[4];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[4];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[4];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[4];
            //önceki bulmacayı gizle
            letter5.parent.gameObject.SetActive(false);
            letter11.parent.gameObject.SetActive(false);
            letter15.parent.gameObject.SetActive(false);
            letter21.parent.gameObject.SetActive(false);
            letter22.parent.gameObject.SetActive(false);
            letter29.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter4.parent.gameObject.SetActive(true);
            letter6.parent.gameObject.SetActive(true);
            letter7.parent.gameObject.SetActive(true);
            letter12.parent.gameObject.SetActive(true);
            letter14.parent.gameObject.SetActive(true);
            letter16.parent.gameObject.SetActive(true);
            letter18.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == word3L5 && !bulunanKelimeler.Contains(word3L5))
                {
                    Debug.Log("Correct 3 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[2];
                    letter14.gameObject.SetActive(true);
                    letter20.GetComponent<TextMesh>().text = selectLetter[3];
                    letter20.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word3L5);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 23)
                    {
                        if (PlayerPrefs.GetInt("Alt26") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt26", Main.skor);
                            PlayerPrefs.SetString("nameHigh26", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word3L5))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 3 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            if (wordLen == 4)
            {
                if (currentWord == word4L10 && !bulunanKelimeler.Contains(word4L10))
                {
                    Debug.Log("Correct 4 letter word");
                    letter33.GetComponent<TextMesh>().text = selectLetter[1];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[2];
                    letter34.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[3];
                    letter35.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[4];
                    letter36.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L10);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 23)
                    {
                        if (PlayerPrefs.GetInt("Alt26") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt26", Main.skor);
                            PlayerPrefs.SetString("nameHigh26", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L11 && !bulunanKelimeler.Contains(word4L11))
                {
                    Debug.Log("Correct 4 letter word");
                    letter34.GetComponent<TextMesh>().text = selectLetter[1];
                    letter34.gameObject.SetActive(true);
                    letter4.GetComponent<TextMesh>().text = selectLetter[2];
                    letter4.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[3];
                    letter10.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[4];
                    letter16.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L11);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 23)
                    {
                        if (PlayerPrefs.GetInt("Alt26") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt26", Main.skor);
                            PlayerPrefs.SetString("nameHigh26", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L12 && !bulunanKelimeler.Contains(word4L12))
                {
                    Debug.Log("Correct 4 letter word");
                    letter7.GetComponent<TextMesh>().text = selectLetter[1];
                    letter7.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[2];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[3];
                    letter9.gameObject.SetActive(true);
                    letter10.GetComponent<TextMesh>().text = selectLetter[4];
                    letter10.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L12);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 23)
                    {
                        if (PlayerPrefs.GetInt("Alt26") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt26", Main.skor);
                            PlayerPrefs.SetString("nameHigh26", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == word4L13 && !bulunanKelimeler.Contains(word4L13))
                {
                    Debug.Log("Correct 4 letter word");
                    letter36.GetComponent<TextMesh>().text = selectLetter[1];
                    letter36.gameObject.SetActive(true);
                    letter6.GetComponent<TextMesh>().text = selectLetter[2];
                    letter6.gameObject.SetActive(true);
                    letter12.GetComponent<TextMesh>().text = selectLetter[3];
                    letter12.gameObject.SetActive(true);
                    letter18.GetComponent<TextMesh>().text = selectLetter[4];
                    letter18.gameObject.SetActive(true);
                    bulunanKelimeler.Add(word4L13);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 23)
                    {
                        if (PlayerPrefs.GetInt("Alt26") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt26", Main.skor);
                            PlayerPrefs.SetString("nameHigh26", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(word4L10) || bulunanKelimeler.Contains(word4L11) || bulunanKelimeler.Contains(word4L12) || bulunanKelimeler.Contains(word4L13))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != word4L14 && currentWord != word4L15 && currentWord != word4L16 && currentWord != word3L3 && currentWord != word3L4)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        if (bulunanKelimeSayisi == 23)
        {
            Scene scene = SceneManager.GetActiveScene();
            ActiveScene = scene.name;
            bulunanKelimeler.Clear();
            bulunanKelimeSayisi = 0;
            Debug.Log("ActiveScene name:" + ActiveScene);
            SkorSonuc.toplamSkor = toplam;
            toplam = 0;
            SkorSonuc.levelAdı = ActiveScene;
            PlayerPrefs.SetString("levelAdi", "level 3");
            SceneManager.LoadScene("BolumTamamlandi");
        }
    }

    //level 3
    public void level3()
    {
        Scene scene3 = SceneManager.GetActiveScene();
        ActiveScene = scene3.name;
        PlayerPrefs.SetString("levelAdi", ActiveScene);
        availLetter1 = new List<string>() { "M", "S", "K", "A", "T" };
        availLetter2 = new List<string>() { "A", "E", "A", "Ğ", "E" };
        availLetter3 = new List<string>() { "N", "P", "L", "S", "S" };
        availLetter4 = new List<string>() { "A", "R", "A", "M", "T" };
        availLetter5 = new List<string>() { "L", "İ", "Y", "A", "İ" };
        availLetter6 = new List<string>() { "", "", "", "L", "S" };
        availLetter7 = new List<string>() { "", "", "", "", "N" };
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        if (Input.GetKeyUp(RMB))
        {
            wordLen = currentWord.Length;
        }

        //altlevel1 15 16 17 18 25 33 34 35 36 37 45 47 52 53 54 55 57
        if (bulunanKelimeSayisi < 5)
        {
            if (wordLen == 3)
            {
                if (currentWord == wordT3L && !bulunanKelimeler.Contains(wordT3L))
                {
                    Debug.Log("Correct 3 letter word");
                    letter37.GetComponent<TextMesh>().text = selectLetter[1];
                    letter37.gameObject.SetActive(true);
                    letter47.GetComponent<TextMesh>().text = selectLetter[2];
                    letter47.gameObject.SetActive(true);
                    letter57.GetComponent<TextMesh>().text = selectLetter[3];
                    letter57.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT3L);
                    puanHesap();
                    if (bulunanKelimeSayisi == 5)
                    {
                        if (PlayerPrefs.GetInt("Alt31") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt31", Main.skor);
                            PlayerPrefs.SetString("nameHigh31", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT3L))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 3 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }//wordT3L 
            else if (wordLen == 4)
            {
                if (currentWord == wordT4L && !bulunanKelimeler.Contains(wordT4L))
                {
                    Debug.Log("Correct 4 letter word");
                    letter15.GetComponent<TextMesh>().text = selectLetter[1];
                    letter15.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[2];
                    letter16.gameObject.SetActive(true);
                    letter17.GetComponent<TextMesh>().text = selectLetter[3];
                    letter17.gameObject.SetActive(true);
                    letter18.GetComponent<TextMesh>().text = selectLetter[4];
                    letter18.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT4L);
                    puanHesap();
                    if (bulunanKelimeSayisi == 5)
                    {
                        if (PlayerPrefs.GetInt("Alt31") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt31", Main.skor);
                            PlayerPrefs.SetString("nameHigh31", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (currentWord == wordT4L2 && !bulunanKelimeler.Contains(wordT4L2))
                {
                    Debug.Log("Correct 4 letter word");
                    letter52.GetComponent<TextMesh>().text = selectLetter[1];
                    letter52.gameObject.SetActive(true);
                    letter53.GetComponent<TextMesh>().text = selectLetter[2];
                    letter53.gameObject.SetActive(true);
                    letter54.GetComponent<TextMesh>().text = selectLetter[3];
                    letter54.gameObject.SetActive(true);
                    letter55.GetComponent<TextMesh>().text = selectLetter[4];
                    letter55.gameObject.SetActive(true);
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT4L2);
                    puanHesap();
                    if (bulunanKelimeSayisi == 5)
                    {
                        if (PlayerPrefs.GetInt("Alt31") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt31", Main.skor);
                            PlayerPrefs.SetString("nameHigh31", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (bulunanKelimeler.Contains(wordT4L2) || bulunanKelimeler.Contains(wordT4L))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 4 letter word bu mu");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }//wordT4L wordT4L2
            else if (wordLen == 5)
            {
                if (currentWord == wordT5L && !bulunanKelimeler.Contains(wordT5L))
                {
                    Debug.Log("Correct 5 letter word");
                    letter33.GetComponent<TextMesh>().text = selectLetter[1];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[2];
                    letter34.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[3];
                    letter35.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[4];
                    letter36.gameObject.SetActive(true);
                    letter37.GetComponent<TextMesh>().text = selectLetter[5];
                    letter37.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    bulunanKelimeler.Add(wordT5L);
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 5)
                    {
                        if (PlayerPrefs.GetInt("Alt31") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt31", Main.skor);
                            PlayerPrefs.SetString("nameHigh31", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT5L2 && !bulunanKelimeler.Contains(wordT5L2))
                {
                    Debug.Log("Correct 5 letter word");
                    letter15.GetComponent<TextMesh>().text = selectLetter[1];
                    letter15.gameObject.SetActive(true);
                    letter25.GetComponent<TextMesh>().text = selectLetter[2];
                    letter25.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[3];
                    letter35.gameObject.SetActive(true);
                    letter45.GetComponent<TextMesh>().text = selectLetter[4];
                    letter45.gameObject.SetActive(true);
                    letter55.GetComponent<TextMesh>().text = selectLetter[5];
                    letter55.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L2);
                    puanHesap();
                    if (bulunanKelimeSayisi == 5)
                    {
                        if (PlayerPrefs.GetInt("Alt31") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt31", Main.skor);
                            PlayerPrefs.SetString("nameHigh31", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT5L2) || bulunanKelimeler.Contains(wordT5L))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 4 letter word bu mu");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }//wordT5L wordT5L2
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel2 13 14 15 16 24 33 34 35 36 37 44 46 54 56 65 66 67 68
        if (bulunanKelimeSayisi < 10 && bulunanKelimeSayisi >= 5)
        {
            if (bulunanKelimeSayisi == 5)
            {
                letter15.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = "";
                letter17.GetComponent<TextMesh>().text = "";
                letter18.GetComponent<TextMesh>().text = "";
                letter25.GetComponent<TextMesh>().text = "";
                letter33.GetComponent<TextMesh>().text = "";
                letter34.GetComponent<TextMesh>().text = "";
                letter35.GetComponent<TextMesh>().text = "";
                letter36.GetComponent<TextMesh>().text = "";
                letter37.GetComponent<TextMesh>().text = "";
                letter45.GetComponent<TextMesh>().text = "";
                letter47.GetComponent<TextMesh>().text = "";
                letter52.GetComponent<TextMesh>().text = "";
                letter53.GetComponent<TextMesh>().text = "";
                letter54.GetComponent<TextMesh>().text = "";
                letter55.GetComponent<TextMesh>().text = "";
                letter57.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[0];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[0];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[0];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[0];
            bottomL5Obj.GetComponent<TextMesh>().text = availLetter5[0];

            //önceki bulmacayı gizle
            letter17.parent.gameObject.SetActive(false);
            letter18.parent.gameObject.SetActive(false);
            letter25.parent.gameObject.SetActive(false);
            letter45.parent.gameObject.SetActive(false);
            letter47.parent.gameObject.SetActive(false);
            letter52.parent.gameObject.SetActive(false);
            letter53.parent.gameObject.SetActive(false);
            letter55.parent.gameObject.SetActive(false);
            letter57.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter13.parent.gameObject.SetActive(true);
            letter14.parent.gameObject.SetActive(true);
            letter24.parent.gameObject.SetActive(true);
            letter44.parent.gameObject.SetActive(true);
            letter46.parent.gameObject.SetActive(true);
            letter56.parent.gameObject.SetActive(true);
            letter65.parent.gameObject.SetActive(true);
            letter66.parent.gameObject.SetActive(true);
            letter67.parent.gameObject.SetActive(true);
            letter68.parent.gameObject.SetActive(true);

            if (wordLen == 4)
            {
                if (currentWord == wordT4L3 && !bulunanKelimeler.Contains(wordT4L3))
                {
                    Debug.Log("Correct 4 letter word");
                    letter13.GetComponent<TextMesh>().text = selectLetter[1];
                    letter13.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[2];
                    letter14.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[3];
                    letter15.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[4];
                    letter16.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L3);
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeSayisi += 1;
                    puanHesap();
                    if (bulunanKelimeSayisi == 10)
                    {
                        if (PlayerPrefs.GetInt("Alt32") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt32", Main.skor);
                            PlayerPrefs.SetString("nameHigh32", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L4 && !bulunanKelimeler.Contains(wordT4L4))
                {
                    Debug.Log("Correct 4 letter word");
                    letter36.GetComponent<TextMesh>().text = selectLetter[1];
                    letter36.gameObject.SetActive(true);
                    letter46.GetComponent<TextMesh>().text = selectLetter[2];
                    letter46.gameObject.SetActive(true);
                    letter56.GetComponent<TextMesh>().text = selectLetter[3];
                    letter56.gameObject.SetActive(true);
                    letter66.GetComponent<TextMesh>().text = selectLetter[4];
                    letter66.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L4);
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeSayisi += 1;
                    puanHesap();
                    if (bulunanKelimeSayisi == 10)
                    {
                        if (PlayerPrefs.GetInt("Alt32") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt32", Main.skor);
                            PlayerPrefs.SetString("nameHigh32", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L5 && !bulunanKelimeler.Contains(wordT4L5))
                {
                    Debug.Log("Correct 4 letter word");
                    letter65.GetComponent<TextMesh>().text = selectLetter[1];
                    letter65.gameObject.SetActive(true);
                    letter66.GetComponent<TextMesh>().text = selectLetter[2];
                    letter66.gameObject.SetActive(true);
                    letter67.GetComponent<TextMesh>().text = selectLetter[3];
                    letter67.gameObject.SetActive(true);
                    letter68.GetComponent<TextMesh>().text = selectLetter[4];
                    letter68.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L5);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 10)
                    {
                        if (PlayerPrefs.GetInt("Alt32") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt32", Main.skor);
                            PlayerPrefs.SetString("nameHigh32", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT4L3) || bulunanKelimeler.Contains(wordT4L4) || bulunanKelimeler.Contains(wordT4L5))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT4L && currentWord != wordT4L2)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 5)
            {
                if (currentWord == wordT5L3 && !bulunanKelimeler.Contains(wordT5L3))
                {
                    Debug.Log("Correct 5 letter word");
                    letter14.GetComponent<TextMesh>().text = selectLetter[1];
                    letter14.gameObject.SetActive(true);
                    letter24.GetComponent<TextMesh>().text = selectLetter[2];
                    letter24.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[3];
                    letter34.gameObject.SetActive(true);
                    letter44.GetComponent<TextMesh>().text = selectLetter[4];
                    letter44.gameObject.SetActive(true);
                    letter54.GetComponent<TextMesh>().text = selectLetter[5];
                    letter54.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L3);
                    puanHesap();
                    if (bulunanKelimeSayisi == 10)
                    {
                        if (PlayerPrefs.GetInt("Alt32") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt32", Main.skor);
                            PlayerPrefs.SetString("nameHigh32", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT5L4 && !bulunanKelimeler.Contains(wordT5L4))
                {
                    Debug.Log("Correct 5 letter word");
                    letter33.GetComponent<TextMesh>().text = selectLetter[1];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[2];
                    letter34.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[3];
                    letter35.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[4];
                    letter36.gameObject.SetActive(true);
                    letter37.GetComponent<TextMesh>().text = selectLetter[5];
                    letter37.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L4);
                    puanHesap();
                    if (bulunanKelimeSayisi == 10)
                    {
                        if (PlayerPrefs.GetInt("Alt32") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt32", Main.skor);
                            PlayerPrefs.SetString("nameHigh32", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT5L4) || bulunanKelimeler.Contains(wordT5L3))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 5 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }//wordT5L wordT5L2
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel3 5 8 14 15 16 17 18 25 28 33 34 35 36 38 43 48 52 53 54 55 63
        if (bulunanKelimeSayisi >= 10 && bulunanKelimeSayisi < 16)
        {
            if (bulunanKelimeSayisi == 10)
            {
                letter13.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = "";
                letter15.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = "";
                letter24.GetComponent<TextMesh>().text = "";
                letter33.GetComponent<TextMesh>().text = "";
                letter34.GetComponent<TextMesh>().text = "";
                letter35.GetComponent<TextMesh>().text = "";
                letter36.GetComponent<TextMesh>().text = "";
                letter37.GetComponent<TextMesh>().text = "";
                letter44.GetComponent<TextMesh>().text = "";
                letter46.GetComponent<TextMesh>().text = "";
                letter54.GetComponent<TextMesh>().text = "";
                letter56.GetComponent<TextMesh>().text = "";
                letter65.GetComponent<TextMesh>().text = "";
                letter66.GetComponent<TextMesh>().text = "";
                letter67.GetComponent<TextMesh>().text = "";
                letter68.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[1];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[1];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[1];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[1];
            bottomL5Obj.GetComponent<TextMesh>().text = availLetter5[1];

            //önceki bulmacayı gizle
            letter13.parent.gameObject.SetActive(false);
            letter24.parent.gameObject.SetActive(false);
            letter37.parent.gameObject.SetActive(false);
            letter44.parent.gameObject.SetActive(false);
            letter46.parent.gameObject.SetActive(false);
            letter56.parent.gameObject.SetActive(false);
            letter65.parent.gameObject.SetActive(false);
            letter66.parent.gameObject.SetActive(false);
            letter67.parent.gameObject.SetActive(false);
            letter68.parent.gameObject.SetActive(false);

            //yeni bulmacayı aç
            letter5.parent.gameObject.SetActive(true);
            letter8.parent.gameObject.SetActive(true);
            letter17.parent.gameObject.SetActive(true);
            letter18.parent.gameObject.SetActive(true);
            letter25.parent.gameObject.SetActive(true);
            letter28.parent.gameObject.SetActive(true);
            letter38.parent.gameObject.SetActive(true);
            letter43.parent.gameObject.SetActive(true);
            letter48.parent.gameObject.SetActive(true);
            letter52.parent.gameObject.SetActive(true);
            letter53.parent.gameObject.SetActive(true);
            letter54.parent.gameObject.SetActive(true);
            letter55.parent.gameObject.SetActive(true);
            letter63.parent.gameObject.SetActive(true);

            if (wordLen == 4)
            {
                if (currentWord == wordT4L6 && !bulunanKelimeler.Contains(wordT4L6))
                {
                    Debug.Log("Correct 4 letter word");
                    letter5.GetComponent<TextMesh>().text = selectLetter[1];
                    letter5.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[2];
                    letter15.gameObject.SetActive(true);
                    letter25.GetComponent<TextMesh>().text = selectLetter[3];
                    letter25.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[4];
                    letter35.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L6);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 16)
                    {
                        if (PlayerPrefs.GetInt("Alt33") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt33", Main.skor);
                            PlayerPrefs.SetString("nameHigh33", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L7 && !bulunanKelimeler.Contains(wordT4L7))
                {
                    Debug.Log("Correct 4 letter word");
                    letter33.GetComponent<TextMesh>().text = selectLetter[1];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[2];
                    letter34.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[3];
                    letter35.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[4];
                    letter36.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L7);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 16)
                    {
                        if (PlayerPrefs.GetInt("Alt33") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt33", Main.skor);
                            PlayerPrefs.SetString("nameHigh33", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L8 && !bulunanKelimeler.Contains(wordT4L8))
                {
                    Debug.Log("Correct 4 letter word");
                    letter33.GetComponent<TextMesh>().text = selectLetter[1];
                    letter33.gameObject.SetActive(true);
                    letter43.GetComponent<TextMesh>().text = selectLetter[2];
                    letter43.gameObject.SetActive(true);
                    letter53.GetComponent<TextMesh>().text = selectLetter[3];
                    letter53.gameObject.SetActive(true);
                    letter63.GetComponent<TextMesh>().text = selectLetter[4];
                    letter63.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L8);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 16)
                    {
                        if (PlayerPrefs.GetInt("Alt33") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt33", Main.skor);
                            PlayerPrefs.SetString("nameHigh33", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L9 && !bulunanKelimeler.Contains(wordT4L9))
                {
                    Debug.Log("Correct 4 letter word");
                    letter52.GetComponent<TextMesh>().text = selectLetter[1];
                    letter52.gameObject.SetActive(true);
                    letter53.GetComponent<TextMesh>().text = selectLetter[2];
                    letter53.gameObject.SetActive(true);
                    letter54.GetComponent<TextMesh>().text = selectLetter[3];
                    letter54.gameObject.SetActive(true);
                    letter55.GetComponent<TextMesh>().text = selectLetter[4];
                    letter55.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L9);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 16)
                    {
                        if (PlayerPrefs.GetInt("Alt33") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt33", Main.skor);
                            PlayerPrefs.SetString("nameHigh33", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT4L6) || bulunanKelimeler.Contains(wordT4L7) || bulunanKelimeler.Contains(wordT4L8) || bulunanKelimeler.Contains(wordT4L9))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT4L3 && currentWord != wordT4L4 && currentWord != wordT4L5)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 5)
            {
                if (currentWord == wordT5L5 && !bulunanKelimeler.Contains(wordT5L5))
                {
                    Debug.Log("Correct 5 letter word");
                    letter14.GetComponent<TextMesh>().text = selectLetter[1];
                    letter14.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[2];
                    letter15.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[3];
                    letter16.gameObject.SetActive(true);
                    letter17.GetComponent<TextMesh>().text = selectLetter[4];
                    letter17.gameObject.SetActive(true);
                    letter18.GetComponent<TextMesh>().text = selectLetter[5];
                    letter18.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    bulunanKelimeler.Add(wordT5L5);
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 16)
                    {
                        if (PlayerPrefs.GetInt("Alt33") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt33", Main.skor);
                            PlayerPrefs.SetString("nameHigh33", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (currentWord == wordT5L6 && !bulunanKelimeler.Contains(wordT5L6))
                {
                    Debug.Log("Correct 5 letter word");
                    letter8.GetComponent<TextMesh>().text = selectLetter[1];
                    letter8.gameObject.SetActive(true);
                    letter18.GetComponent<TextMesh>().text = selectLetter[2];
                    letter18.gameObject.SetActive(true);
                    letter28.GetComponent<TextMesh>().text = selectLetter[3];
                    letter28.gameObject.SetActive(true);
                    letter38.GetComponent<TextMesh>().text = selectLetter[4];
                    letter38.gameObject.SetActive(true);
                    letter48.GetComponent<TextMesh>().text = selectLetter[5];
                    letter48.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    bulunanKelimeler.Add(wordT5L6);
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 16)
                    {
                        if (PlayerPrefs.GetInt("Alt33") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt33", Main.skor);
                            PlayerPrefs.SetString("nameHigh33", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }

                }
                else if (bulunanKelimeler.Contains(wordT5L5) || bulunanKelimeler.Contains(wordT5L6))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT5L3 && currentWord != wordT5L4)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel4 3 13 14 15 16 17 23 32 33 34 35 36 43 45 55 65 66 67 68
        if (bulunanKelimeSayisi >= 16 && bulunanKelimeSayisi < 21)
        {
            if (bulunanKelimeSayisi == 16)
            {
                letter5.GetComponent<TextMesh>().text = ""; letter8.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = ""; letter15.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = ""; letter17.GetComponent<TextMesh>().text = "";
                letter18.GetComponent<TextMesh>().text = ""; letter25.GetComponent<TextMesh>().text = "";
                letter28.GetComponent<TextMesh>().text = ""; letter33.GetComponent<TextMesh>().text = "";
                letter34.GetComponent<TextMesh>().text = ""; letter35.GetComponent<TextMesh>().text = "";
                letter36.GetComponent<TextMesh>().text = ""; letter38.GetComponent<TextMesh>().text = "";
                letter43.GetComponent<TextMesh>().text = ""; letter48.GetComponent<TextMesh>().text = "";
                letter52.GetComponent<TextMesh>().text = ""; letter53.GetComponent<TextMesh>().text = "";
                letter54.GetComponent<TextMesh>().text = ""; letter55.GetComponent<TextMesh>().text = "";
                letter63.GetComponent<TextMesh>().text = "";
            }
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[2];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter2[2];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter3[2];
            bottomL4Obj.GetComponent<TextMesh>().text = availLetter4[2];
            bottomL5Obj.GetComponent<TextMesh>().text = availLetter5[2];
            //önceki bulmacayı gizle
            letter5.parent.gameObject.SetActive(false);
            letter8.parent.gameObject.SetActive(false);
            letter18.parent.gameObject.SetActive(false);
            letter25.parent.gameObject.SetActive(false);
            letter28.parent.gameObject.SetActive(false);
            letter38.parent.gameObject.SetActive(false);
            letter48.parent.gameObject.SetActive(false);
            letter52.parent.gameObject.SetActive(false);
            letter53.parent.gameObject.SetActive(false);
            letter54.parent.gameObject.SetActive(false);
            letter63.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter3.parent.gameObject.SetActive(true);
            letter13.parent.gameObject.SetActive(true);
            letter23.parent.gameObject.SetActive(true);
            letter32.parent.gameObject.SetActive(true);
            letter45.parent.gameObject.SetActive(true);
            letter65.parent.gameObject.SetActive(true);
            letter66.parent.gameObject.SetActive(true);
            letter67.parent.gameObject.SetActive(true);
            letter68.parent.gameObject.SetActive(true);

            if (wordLen == 4)
            {
                if (currentWord == wordT4L10 && !bulunanKelimeler.Contains(wordT4L10))
                {
                    Debug.Log("Correct 4 letter word");
                    letter35.GetComponent<TextMesh>().text = selectLetter[1];
                    letter35.gameObject.SetActive(true);
                    letter45.GetComponent<TextMesh>().text = selectLetter[2];
                    letter45.gameObject.SetActive(true);
                    letter55.GetComponent<TextMesh>().text = selectLetter[3];
                    letter55.gameObject.SetActive(true);
                    letter65.GetComponent<TextMesh>().text = selectLetter[4];
                    letter65.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L10);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 21)
                    {
                        if (PlayerPrefs.GetInt("Alt34") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt34", Main.skor);
                            PlayerPrefs.SetString("nameHigh34", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L11 && !bulunanKelimeler.Contains(wordT4L11))
                {
                    Debug.Log("Correct 4 letter word");
                    letter65.GetComponent<TextMesh>().text = selectLetter[1];
                    letter65.gameObject.SetActive(true);
                    letter66.GetComponent<TextMesh>().text = selectLetter[2];
                    letter66.gameObject.SetActive(true);
                    letter67.GetComponent<TextMesh>().text = selectLetter[3];
                    letter67.gameObject.SetActive(true);
                    letter68.GetComponent<TextMesh>().text = selectLetter[4];
                    letter68.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L11);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 21)
                    {
                        if (PlayerPrefs.GetInt("Alt34") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt34", Main.skor);
                            PlayerPrefs.SetString("nameHigh34", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT4L10) || bulunanKelimeler.Contains(wordT4L11))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT4L6 && currentWord != wordT4L7 && currentWord != wordT4L8 && currentWord != wordT4L9)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 5)
            {
                if (currentWord == wordT5L7 && !bulunanKelimeler.Contains(wordT5L7))
                {
                    Debug.Log("Correct 5 letter word");
                    letter3.GetComponent<TextMesh>().text = selectLetter[1];
                    letter3.gameObject.SetActive(true);
                    letter13.GetComponent<TextMesh>().text = selectLetter[2];
                    letter13.gameObject.SetActive(true);
                    letter23.GetComponent<TextMesh>().text = selectLetter[3];
                    letter23.gameObject.SetActive(true);
                    letter33.GetComponent<TextMesh>().text = selectLetter[4];
                    letter33.gameObject.SetActive(true);
                    letter43.GetComponent<TextMesh>().text = selectLetter[5];
                    letter43.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L7);
                    puanHesap();
                    if (bulunanKelimeSayisi == 21)
                    {
                        if (PlayerPrefs.GetInt("Alt34") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt34", Main.skor);
                            PlayerPrefs.SetString("nameHigh34", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT5L8 && !bulunanKelimeler.Contains(wordT5L8))
                {
                    Debug.Log("Correct 5 letter word");
                    letter13.GetComponent<TextMesh>().text = selectLetter[1];
                    letter13.gameObject.SetActive(true);
                    letter14.GetComponent<TextMesh>().text = selectLetter[2];
                    letter14.gameObject.SetActive(true);
                    letter15.GetComponent<TextMesh>().text = selectLetter[3];
                    letter15.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[4];
                    letter16.gameObject.SetActive(true);
                    letter17.GetComponent<TextMesh>().text = selectLetter[5];
                    letter17.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L8);
                    puanHesap();
                    if (bulunanKelimeSayisi == 21)
                    {
                        if (PlayerPrefs.GetInt("Alt34") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt34", Main.skor);
                            PlayerPrefs.SetString("nameHigh34", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT5L9 && !bulunanKelimeler.Contains(wordT5L9))
                {
                    Debug.Log("Correct 5 letter word");
                    letter32.GetComponent<TextMesh>().text = selectLetter[1];
                    letter32.gameObject.SetActive(true);
                    letter33.GetComponent<TextMesh>().text = selectLetter[2];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[3];
                    letter34.gameObject.SetActive(true);
                    letter35.GetComponent<TextMesh>().text = selectLetter[4];
                    letter35.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[5];
                    letter36.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L9);
                    puanHesap();
                    if (bulunanKelimeSayisi == 21)
                    {
                        if (PlayerPrefs.GetInt("Alt34") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt34", Main.skor);
                            PlayerPrefs.SetString("nameHigh34", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT5L7) || bulunanKelimeler.Contains(wordT5L8) || bulunanKelimeler.Contains(wordT5L9))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT5L5 && currentWord != wordT5L6)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel5 14 22 23 24 25 29 32 34 37 38 39 42 43 44 47 49 52 54 55 56 57 59 64 69
        if (bulunanKelimeSayisi >= 21 && bulunanKelimeSayisi < 29)
        {
            if (bulunanKelimeSayisi == 21)
            {
                letter3.GetComponent<TextMesh>().text = ""; letter13.GetComponent<TextMesh>().text = "";
                letter14.GetComponent<TextMesh>().text = ""; letter15.GetComponent<TextMesh>().text = "";
                letter16.GetComponent<TextMesh>().text = ""; letter17.GetComponent<TextMesh>().text = "";
                letter23.GetComponent<TextMesh>().text = ""; letter32.GetComponent<TextMesh>().text = "";
                letter33.GetComponent<TextMesh>().text = ""; letter34.GetComponent<TextMesh>().text = "";
                letter35.GetComponent<TextMesh>().text = ""; letter36.GetComponent<TextMesh>().text = "";
                letter43.GetComponent<TextMesh>().text = ""; letter45.GetComponent<TextMesh>().text = "";
                letter55.GetComponent<TextMesh>().text = ""; letter65.GetComponent<TextMesh>().text = "";
                letter66.GetComponent<TextMesh>().text = ""; letter67.GetComponent<TextMesh>().text = "";
                letter68.GetComponent<TextMesh>().text = "";
            }
            bottomL2Obj.parent.gameObject.SetActive(false);
            bottomL3Obj.parent.gameObject.SetActive(false);
            bottomL4Obj.parent.gameObject.SetActive(false);
            bottomL5Obj.parent.gameObject.SetActive(false);
            bottomL6Obj.parent.gameObject.SetActive(true);
            bottomL7Obj.parent.gameObject.SetActive(true);
            bottomL8Obj.parent.gameObject.SetActive(true);
            bottomL9Obj.parent.gameObject.SetActive(true);
            bottomL10Obj.parent.gameObject.SetActive(true);
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[3];
            bottomL6Obj.GetComponent<TextMesh>().text = availLetter2[3];
            bottomL7Obj.GetComponent<TextMesh>().text = availLetter3[3];
            bottomL8Obj.GetComponent<TextMesh>().text = availLetter4[3];
            bottomL9Obj.GetComponent<TextMesh>().text = availLetter5[3];
            bottomL10Obj.GetComponent<TextMesh>().text = availLetter6[3];
            //önceki bulmacayı gizle
            letter3.parent.gameObject.SetActive(false); letter13.parent.gameObject.SetActive(false);
            letter15.parent.gameObject.SetActive(false); letter16.parent.gameObject.SetActive(false);
            letter17.parent.gameObject.SetActive(false); letter33.parent.gameObject.SetActive(false);
            letter35.parent.gameObject.SetActive(false); letter36.parent.gameObject.SetActive(false);
            letter45.parent.gameObject.SetActive(false); letter65.parent.gameObject.SetActive(false);
            letter66.parent.gameObject.SetActive(false); letter67.parent.gameObject.SetActive(false);
            letter68.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter22.parent.gameObject.SetActive(true); letter24.parent.gameObject.SetActive(true);
            letter25.parent.gameObject.SetActive(true); letter49.parent.gameObject.SetActive(true);
            letter29.parent.gameObject.SetActive(true); letter52.parent.gameObject.SetActive(true);
            letter37.parent.gameObject.SetActive(true); letter54.parent.gameObject.SetActive(true);
            letter38.parent.gameObject.SetActive(true); letter56.parent.gameObject.SetActive(true);
            letter39.parent.gameObject.SetActive(true); letter57.parent.gameObject.SetActive(true);
            letter42.parent.gameObject.SetActive(true); letter59.parent.gameObject.SetActive(true);
            letter44.parent.gameObject.SetActive(true); letter64.parent.gameObject.SetActive(true);
            letter47.parent.gameObject.SetActive(true); letter69.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == wordT3L2 && !bulunanKelimeler.Contains(wordT3L2))
                {
                    Debug.Log("Correct 3 letter word");
                    letter42.GetComponent<TextMesh>().text = selectLetter[1];
                    letter42.gameObject.SetActive(true);
                    letter43.GetComponent<TextMesh>().text = selectLetter[2];
                    letter43.gameObject.SetActive(true);
                    letter44.GetComponent<TextMesh>().text = selectLetter[3];
                    letter44.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L2);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT3L3 && !bulunanKelimeler.Contains(wordT3L3))
                {
                    Debug.Log("Correct 3 letter word");
                    letter37.GetComponent<TextMesh>().text = selectLetter[1];
                    letter37.gameObject.SetActive(true);
                    letter47.GetComponent<TextMesh>().text = selectLetter[2];
                    letter47.gameObject.SetActive(true);
                    letter57.GetComponent<TextMesh>().text = selectLetter[3];
                    letter57.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L3);
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeSayisi += 1;
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT3L4 && !bulunanKelimeler.Contains(wordT3L4))
                {
                    Debug.Log("Correct 3 letter word");
                    letter37.GetComponent<TextMesh>().text = selectLetter[1];
                    letter37.gameObject.SetActive(true);
                    letter38.GetComponent<TextMesh>().text = selectLetter[2];
                    letter38.gameObject.SetActive(true);
                    letter39.GetComponent<TextMesh>().text = selectLetter[3];
                    letter39.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L4);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT3L2) || bulunanKelimeler.Contains(wordT3L3) || bulunanKelimeler.Contains(wordT3L4))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 3 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            else if (wordLen == 4)
            {
                if (currentWord == wordT4L12 && !bulunanKelimeler.Contains(wordT4L12))
                {
                    Debug.Log("Correct 4 letter word");
                    letter22.GetComponent<TextMesh>().text = selectLetter[1];
                    letter22.gameObject.SetActive(true);
                    letter23.GetComponent<TextMesh>().text = selectLetter[2];
                    letter23.gameObject.SetActive(true);
                    letter24.GetComponent<TextMesh>().text = selectLetter[3];
                    letter24.gameObject.SetActive(true);
                    letter25.GetComponent<TextMesh>().text = selectLetter[4];
                    letter25.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L12);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L13 && !bulunanKelimeler.Contains(wordT4L13))
                {
                    Debug.Log("Correct 4 letter word");
                    letter22.GetComponent<TextMesh>().text = selectLetter[1];
                    letter22.gameObject.SetActive(true);
                    letter32.GetComponent<TextMesh>().text = selectLetter[2];
                    letter32.gameObject.SetActive(true);
                    letter42.GetComponent<TextMesh>().text = selectLetter[3];
                    letter42.gameObject.SetActive(true);
                    letter52.GetComponent<TextMesh>().text = selectLetter[4];
                    letter52.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L13);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L14 && !bulunanKelimeler.Contains(wordT4L14))
                {
                    Debug.Log("Correct 4 letter word");
                    letter54.GetComponent<TextMesh>().text = selectLetter[1];
                    letter54.gameObject.SetActive(true);
                    letter55.GetComponent<TextMesh>().text = selectLetter[2];
                    letter55.gameObject.SetActive(true);
                    letter56.GetComponent<TextMesh>().text = selectLetter[3];
                    letter56.gameObject.SetActive(true);
                    letter57.GetComponent<TextMesh>().text = selectLetter[4];
                    letter57.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L14);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }

                else if (bulunanKelimeler.Contains(wordT4L12) || bulunanKelimeler.Contains(wordT4L13) || bulunanKelimeler.Contains(wordT4L14))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT4L10 && currentWord != wordT4L11)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 5)
            {
                if (currentWord == wordT5L10 && !bulunanKelimeler.Contains(wordT5L10))
                {
                    Debug.Log("Correct 5 letter word");
                    letter29.GetComponent<TextMesh>().text = selectLetter[1];
                    letter29.gameObject.SetActive(true);
                    letter39.GetComponent<TextMesh>().text = selectLetter[2];
                    letter39.gameObject.SetActive(true);
                    letter49.GetComponent<TextMesh>().text = selectLetter[3];
                    letter49.gameObject.SetActive(true);
                    letter59.GetComponent<TextMesh>().text = selectLetter[4];
                    letter59.gameObject.SetActive(true);
                    letter69.GetComponent<TextMesh>().text = selectLetter[5];
                    letter69.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L10);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT5L10))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT5L7 && currentWord != wordT5L8 && currentWord != wordT5L9)
                    {
                        Debug.Log("Wrong 5 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 6)
            {
                if (currentWord == wordT6L && !bulunanKelimeler.Contains(wordT6L))
                {
                    Debug.Log("Correct 6 letter word");
                    letter14.GetComponent<TextMesh>().text = selectLetter[1];
                    letter14.gameObject.SetActive(true);
                    letter24.GetComponent<TextMesh>().text = selectLetter[2];
                    letter24.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[3];
                    letter34.gameObject.SetActive(true);
                    letter44.GetComponent<TextMesh>().text = selectLetter[4];
                    letter44.gameObject.SetActive(true);
                    letter54.GetComponent<TextMesh>().text = selectLetter[5];
                    letter54.gameObject.SetActive(true);
                    letter64.GetComponent<TextMesh>().text = selectLetter[6];
                    letter64.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT6L);
                    puanHesap();
                    if (bulunanKelimeSayisi == 29)
                    {
                        if (PlayerPrefs.GetInt("Alt35") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt35", Main.skor);
                            PlayerPrefs.SetString("nameHigh35", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT6L))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    Debug.Log("Wrong 6 letter word");
                    hatalideneme += 10;
                    audioSource.PlayOneShot(yanlisSesi);
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        //altlevel6 6 7 8 9 16 19 22 24 25 26 27 28 29 31 32 33 34 36 39 42 44 46 48 49 50 52 53 54 55 58 60 64 68 69 70
        if (bulunanKelimeSayisi >= 29 && bulunanKelimeSayisi < 41)
        {
            if (bulunanKelimeSayisi == 29)
            {
                letter14.GetComponent<TextMesh>().text = ""; letter22.GetComponent<TextMesh>().text = "";
                letter23.GetComponent<TextMesh>().text = ""; letter24.GetComponent<TextMesh>().text = "";
                letter25.GetComponent<TextMesh>().text = ""; letter29.GetComponent<TextMesh>().text = "";
                letter32.GetComponent<TextMesh>().text = ""; letter34.GetComponent<TextMesh>().text = "";
                letter37.GetComponent<TextMesh>().text = ""; letter38.GetComponent<TextMesh>().text = "";
                letter39.GetComponent<TextMesh>().text = ""; letter42.GetComponent<TextMesh>().text = "";
                letter43.GetComponent<TextMesh>().text = ""; letter44.GetComponent<TextMesh>().text = "";
                letter47.GetComponent<TextMesh>().text = ""; letter49.GetComponent<TextMesh>().text = "";
                letter52.GetComponent<TextMesh>().text = ""; letter54.GetComponent<TextMesh>().text = "";
                letter55.GetComponent<TextMesh>().text = ""; letter56.GetComponent<TextMesh>().text = "";
                letter57.GetComponent<TextMesh>().text = ""; letter59.GetComponent<TextMesh>().text = "";
                letter64.GetComponent<TextMesh>().text = ""; letter69.GetComponent<TextMesh>().text = "";
            }
            bottomL4Obj.parent.gameObject.SetActive(false);
            bottomL5Obj.parent.gameObject.SetActive(false);
            bottomL10Obj.parent.gameObject.SetActive(false);
            bottomL6Obj.parent.gameObject.SetActive(true);
            bottomL7Obj.parent.gameObject.SetActive(true);
            bottomL8Obj.parent.gameObject.SetActive(true);
            bottomL9Obj.parent.gameObject.SetActive(true);
            bottomL1Obj.parent.gameObject.SetActive(true);
            bottomL2Obj.parent.gameObject.SetActive(true);
            bottomL3Obj.parent.gameObject.SetActive(true);
            bottomL1Obj.GetComponent<TextMesh>().text = availLetter1[4];
            bottomL6Obj.GetComponent<TextMesh>().text = availLetter2[4];
            bottomL7Obj.GetComponent<TextMesh>().text = availLetter3[4];
            bottomL2Obj.GetComponent<TextMesh>().text = availLetter4[4];
            bottomL8Obj.GetComponent<TextMesh>().text = availLetter5[4];
            bottomL9Obj.GetComponent<TextMesh>().text = availLetter6[4];
            bottomL3Obj.GetComponent<TextMesh>().text = availLetter7[4];
            //önceki bulmacayı gizle
            letter14.parent.gameObject.SetActive(false); letter23.parent.gameObject.SetActive(false);
            letter37.parent.gameObject.SetActive(false); letter38.parent.gameObject.SetActive(false);
            letter43.parent.gameObject.SetActive(false); letter47.parent.gameObject.SetActive(false);
            letter56.parent.gameObject.SetActive(false); letter57.parent.gameObject.SetActive(false);
            letter59.parent.gameObject.SetActive(false);
            //yeni bulmacayı aç
            letter6.parent.gameObject.SetActive(true); letter16.parent.gameObject.SetActive(true);
            letter7.parent.gameObject.SetActive(true); letter19.parent.gameObject.SetActive(true);
            letter8.parent.gameObject.SetActive(true); letter26.parent.gameObject.SetActive(true);
            letter9.parent.gameObject.SetActive(true); letter27.parent.gameObject.SetActive(true);
            letter28.parent.gameObject.SetActive(true); letter36.parent.gameObject.SetActive(true);
            letter31.parent.gameObject.SetActive(true); letter46.parent.gameObject.SetActive(true);
            letter33.parent.gameObject.SetActive(true); letter48.parent.gameObject.SetActive(true);
            letter50.parent.gameObject.SetActive(true); letter53.parent.gameObject.SetActive(true);
            letter58.parent.gameObject.SetActive(true); letter60.parent.gameObject.SetActive(true);
            letter68.parent.gameObject.SetActive(true); letter70.parent.gameObject.SetActive(true);

            if (wordLen == 3)
            {
                if (currentWord == wordT3L5 && !bulunanKelimeler.Contains(wordT3L5))
                {
                    Debug.Log("Correct 3 letter word");
                    letter48.GetComponent<TextMesh>().text = selectLetter[1];
                    letter48.gameObject.SetActive(true);
                    letter49.GetComponent<TextMesh>().text = selectLetter[2];
                    letter49.gameObject.SetActive(true);
                    letter50.GetComponent<TextMesh>().text = selectLetter[3];
                    letter50.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L5);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT3L6 && !bulunanKelimeler.Contains(wordT3L6))
                {
                    Debug.Log("Correct 3 letter word");
                    letter48.GetComponent<TextMesh>().text = selectLetter[1];
                    letter48.gameObject.SetActive(true);
                    letter58.GetComponent<TextMesh>().text = selectLetter[2];
                    letter58.gameObject.SetActive(true);
                    letter68.GetComponent<TextMesh>().text = selectLetter[3];
                    letter68.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L6);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT3L7 && !bulunanKelimeler.Contains(wordT3L7))
                {
                    Debug.Log("Correct 3 letter word");
                    letter68.GetComponent<TextMesh>().text = selectLetter[1];
                    letter68.gameObject.SetActive(true);
                    letter69.GetComponent<TextMesh>().text = selectLetter[2];
                    letter69.gameObject.SetActive(true);
                    letter70.GetComponent<TextMesh>().text = selectLetter[3];
                    letter70.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L7);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT3L8 && !bulunanKelimeler.Contains(wordT3L8))
                {
                    Debug.Log("Correct 3 letter word");
                    letter50.GetComponent<TextMesh>().text = selectLetter[1];
                    letter50.gameObject.SetActive(true);
                    letter60.GetComponent<TextMesh>().text = selectLetter[2];
                    letter60.gameObject.SetActive(true);
                    letter70.GetComponent<TextMesh>().text = selectLetter[3];
                    letter70.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT3L8);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT3L5) || bulunanKelimeler.Contains(wordT3L6) || bulunanKelimeler.Contains(wordT3L7) || bulunanKelimeler.Contains(wordT3L8))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT3L2 && currentWord != wordT3L3 && currentWord != wordT3L4)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 4)
            {
                if (currentWord == wordT4L15 && !bulunanKelimeler.Contains(wordT4L15))
                {
                    Debug.Log("Correct 4 letter word");
                    letter6.GetComponent<TextMesh>().text = selectLetter[1];
                    letter6.gameObject.SetActive(true);
                    letter7.GetComponent<TextMesh>().text = selectLetter[2];
                    letter7.gameObject.SetActive(true);
                    letter8.GetComponent<TextMesh>().text = selectLetter[3];
                    letter8.gameObject.SetActive(true);
                    letter9.GetComponent<TextMesh>().text = selectLetter[4];
                    letter9.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L15);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L16 && !bulunanKelimeler.Contains(wordT4L16))
                {
                    Debug.Log("Correct 4 letter word");
                    letter52.GetComponent<TextMesh>().text = selectLetter[1];
                    letter52.gameObject.SetActive(true);
                    letter53.GetComponent<TextMesh>().text = selectLetter[2];
                    letter53.gameObject.SetActive(true);
                    letter54.GetComponent<TextMesh>().text = selectLetter[3];
                    letter54.gameObject.SetActive(true);
                    letter55.GetComponent<TextMesh>().text = selectLetter[4];
                    letter55.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L16);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L17 && !bulunanKelimeler.Contains(wordT4L17))
                {
                    Debug.Log("Correct 4 letter word");
                    letter22.GetComponent<TextMesh>().text = selectLetter[1];
                    letter22.gameObject.SetActive(true);
                    letter32.GetComponent<TextMesh>().text = selectLetter[2];
                    letter32.gameObject.SetActive(true);
                    letter42.GetComponent<TextMesh>().text = selectLetter[3];
                    letter42.gameObject.SetActive(true);
                    letter52.GetComponent<TextMesh>().text = selectLetter[4];
                    letter52.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L17);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT4L18 && !bulunanKelimeler.Contains(wordT4L18))
                {
                    Debug.Log("Correct 4 letter word");
                    letter31.GetComponent<TextMesh>().text = selectLetter[1];
                    letter31.gameObject.SetActive(true);
                    letter32.GetComponent<TextMesh>().text = selectLetter[2];
                    letter32.gameObject.SetActive(true);
                    letter33.GetComponent<TextMesh>().text = selectLetter[3];
                    letter33.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[4];
                    letter34.gameObject.SetActive(true);
                    bulunanKelimeler.Add(wordT4L18);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT4L15) || bulunanKelimeler.Contains(wordT4L16) || bulunanKelimeler.Contains(wordT4L17) || bulunanKelimeler.Contains(wordT4L18))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT4L12 && currentWord != wordT4L13 && currentWord != wordT4L14)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 5)
            {
                if (currentWord == wordT5L11 && !bulunanKelimeler.Contains(wordT5L11))
                {
                    Debug.Log("Correct 5 letter word");
                    letter6.GetComponent<TextMesh>().text = selectLetter[1];
                    letter6.gameObject.SetActive(true);
                    letter16.GetComponent<TextMesh>().text = selectLetter[2];
                    letter16.gameObject.SetActive(true);
                    letter26.GetComponent<TextMesh>().text = selectLetter[3];
                    letter26.gameObject.SetActive(true);
                    letter36.GetComponent<TextMesh>().text = selectLetter[4];
                    letter36.gameObject.SetActive(true);
                    letter46.GetComponent<TextMesh>().text = selectLetter[5];
                    letter46.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L11);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT5L12 && !bulunanKelimeler.Contains(wordT5L12))
                {
                    Debug.Log("Correct 5 letter word");
                    letter24.GetComponent<TextMesh>().text = selectLetter[1];
                    letter24.gameObject.SetActive(true);
                    letter34.GetComponent<TextMesh>().text = selectLetter[2];
                    letter34.gameObject.SetActive(true);
                    letter44.GetComponent<TextMesh>().text = selectLetter[3];
                    letter44.gameObject.SetActive(true);
                    letter54.GetComponent<TextMesh>().text = selectLetter[4];
                    letter54.gameObject.SetActive(true);
                    letter64.GetComponent<TextMesh>().text = selectLetter[5];
                    letter64.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L12);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (currentWord == wordT5L13 && !bulunanKelimeler.Contains(wordT5L13))
                {
                    Debug.Log("Correct 5 letter word");
                    letter9.GetComponent<TextMesh>().text = selectLetter[1];
                    letter9.gameObject.SetActive(true);
                    letter19.GetComponent<TextMesh>().text = selectLetter[2];
                    letter19.gameObject.SetActive(true);
                    letter29.GetComponent<TextMesh>().text = selectLetter[3];
                    letter29.gameObject.SetActive(true);
                    letter39.GetComponent<TextMesh>().text = selectLetter[4];
                    letter39.gameObject.SetActive(true);
                    letter49.GetComponent<TextMesh>().text = selectLetter[5];
                    letter49.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT5L13);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT5L11) || bulunanKelimeler.Contains(wordT5L12) || bulunanKelimeler.Contains(wordT5L13))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT5L10)
                    {
                        Debug.Log("Wrong 4 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else if (wordLen == 6)
            {
                if (currentWord == wordT6L2 && !bulunanKelimeler.Contains(wordT6L2))
                {
                    Debug.Log("Correct 6 letter word");
                    letter24.GetComponent<TextMesh>().text = selectLetter[1];
                    letter24.gameObject.SetActive(true);
                    letter25.GetComponent<TextMesh>().text = selectLetter[2];
                    letter25.gameObject.SetActive(true);
                    letter26.GetComponent<TextMesh>().text = selectLetter[3];
                    letter26.gameObject.SetActive(true);
                    letter27.GetComponent<TextMesh>().text = selectLetter[4];
                    letter27.gameObject.SetActive(true);
                    letter28.GetComponent<TextMesh>().text = selectLetter[5];
                    letter28.gameObject.SetActive(true);
                    letter29.GetComponent<TextMesh>().text = selectLetter[6];
                    letter29.gameObject.SetActive(true);
                    bulunanKelimeSayisi += 1;
                    audioSource.PlayOneShot(dogruSesi);
                    bulunanKelimeler.Add(wordT6L2);
                    puanHesap();
                    if (bulunanKelimeSayisi == 41)
                    {
                        if (PlayerPrefs.GetInt("Alt36") <= Main.skor)
                        {
                            PlayerPrefs.SetInt("Alt36", Main.skor);
                            PlayerPrefs.SetString("nameHigh36", PlayerPrefs.GetString("name"));
                        }
                        toplam += Main.skor;
                        Main.skor = 0;
                        timeStart = 0.0f;
                    }
                }
                else if (bulunanKelimeler.Contains(wordT6L2))
                {
                    Debug.Log("Zaten Bulunmuş.");
                }
                else
                {
                    if (currentWord != wordT6L)
                    {
                        Debug.Log("Wrong 6 letter word");
                        hatalideneme += 10;
                        audioSource.PlayOneShot(yanlisSesi);
                    }
                }
            }
            else
            {
                hatalideneme += 10;
                audioSource.PlayOneShot(yanlisSesi);
            }
        }
        if (bulunanKelimeSayisi == 41)
        {
            Scene scene = SceneManager.GetActiveScene();
            ActiveScene = scene.name;
            bulunanKelimeler.Clear();
            bulunanKelimeSayisi = 0;
            Debug.Log("ActiveScene name:" + ActiveScene);
            SkorSonuc.toplamSkor = toplam;
            toplam = 0;
            SkorSonuc.levelAdı = ActiveScene;
            PlayerPrefs.SetString("levelAdi", "level 3");
            SceneManager.LoadScene("BolumTamamlandi");
        }
    }

    //Harfleri Karıştır
    public void karistir()
    {
        Scene scene = SceneManager.GetActiveScene();
        string name = scene.name;
        if (name == "level 2")
        {
            tumHarfler[0] = bottomL1Obj.GetComponent<TextMesh>().text;
            tumHarfler[1] = bottomL2Obj.GetComponent<TextMesh>().text;
            tumHarfler[2] = bottomL3Obj.GetComponent<TextMesh>().text;
            tumHarfler[3] = bottomL4Obj.GetComponent<TextMesh>().text;
            for (int i = 0; i <= 20; i++)
            {
                int r = UnityEngine.Random.Range(0, 4);
                if (!randomdeger.Contains(r))
                {
                    randomdeger.Add(r);
                }
                if (randomdeger.Count == 4)
                {
                    break;
                }
            }
            bottomL1Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[0]];
            bottomL2Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[1]];
            bottomL3Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[2]];
            bottomL4Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[3]];
            randomdeger.Clear();
        }
        else if (name == "level 1")
        {
            tumHarfler[0] = bottomL1Obj.GetComponent<TextMesh>().text;
            tumHarfler[1] = bottomL2Obj.GetComponent<TextMesh>().text;
            tumHarfler[2] = bottomL3Obj.GetComponent<TextMesh>().text;
            for (int i = 0; i <= 20; i++)
            {
                int r = UnityEngine.Random.Range(0, 3);
                if (!randomdeger.Contains(r))
                {
                    randomdeger.Add(r);
                }
                if (randomdeger.Count == 3)
                {
                    break;
                }
            }
            bottomL1Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[0]];
            bottomL2Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[1]];
            bottomL3Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[2]];
            randomdeger.Clear();
        }
        else if (name == "level 3")
        {
            if (bulunanKelimeSayisi >= 21 && bulunanKelimeSayisi<29)
            {
                tumHarfler[0] = bottomL6Obj.GetComponent<TextMesh>().text;
                tumHarfler[1] = bottomL7Obj.GetComponent<TextMesh>().text;
                tumHarfler[2] = bottomL8Obj.GetComponent<TextMesh>().text;
                tumHarfler[3] = bottomL9Obj.GetComponent<TextMesh>().text;
                tumHarfler[4] = bottomL10Obj.GetComponent<TextMesh>().text;
                tumHarfler[5] = bottomL1Obj.GetComponent<TextMesh>().text;

                for (int i = 0; i <= 20; i++)
                {
                    int r = UnityEngine.Random.Range(0, 6);
                    if (!randomdeger.Contains(r))
                    {
                        randomdeger.Add(r);
                    }
                    if (randomdeger.Count == 6)
                    {
                        break;
                    }
                }
                bottomL6Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[0]];
                bottomL7Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[1]];
                bottomL8Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[2]];
                bottomL9Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[3]];
                bottomL10Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[4]];
                bottomL1Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[5]];
                randomdeger.Clear();
            }
            else if (bulunanKelimeSayisi >= 29)
            {
                tumHarfler[0] = bottomL6Obj.GetComponent<TextMesh>().text;
                tumHarfler[1] = bottomL7Obj.GetComponent<TextMesh>().text;
                tumHarfler[2] = bottomL8Obj.GetComponent<TextMesh>().text;
                tumHarfler[3] = bottomL9Obj.GetComponent<TextMesh>().text;
                tumHarfler[4] = bottomL1Obj.GetComponent<TextMesh>().text;
                tumHarfler[5] = bottomL2Obj.GetComponent<TextMesh>().text;
                tumHarfler[6] = bottomL3Obj.GetComponent<TextMesh>().text;
                for (int i = 0; i <= 20; i++)
                {
                    int r = UnityEngine.Random.Range(0, 7);
                    if (!randomdeger.Contains(r))
                    {
                        randomdeger.Add(r);
                    }
                    if (randomdeger.Count == 7)
                    {
                        break;
                    }
                }
                bottomL6Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[0]];
                bottomL7Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[1]];
                bottomL8Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[2]];
                bottomL9Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[3]];
                bottomL1Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[4]];
                bottomL2Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[5]];
                bottomL3Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[6]];
                randomdeger.Clear();
            }
            else if (bulunanKelimeSayisi < 21)
            {
                tumHarfler[0] = bottomL1Obj.GetComponent<TextMesh>().text;
                tumHarfler[1] = bottomL2Obj.GetComponent<TextMesh>().text;
                tumHarfler[2] = bottomL3Obj.GetComponent<TextMesh>().text;
                tumHarfler[3] = bottomL4Obj.GetComponent<TextMesh>().text;
                tumHarfler[4] = bottomL5Obj.GetComponent<TextMesh>().text;
                for (int i = 0; i <= 20; i++)
                {
                    int r = UnityEngine.Random.Range(0, 5);
                    if (!randomdeger.Contains(r))
                    {
                        randomdeger.Add(r);
                    }
                    if (randomdeger.Count == 5)
                    {
                        break;
                    }
                }
                bottomL1Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[0]];
                bottomL2Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[1]];
                bottomL3Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[2]];
                bottomL4Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[3]];
                bottomL5Obj.GetComponent<TextMesh>().text = tumHarfler[randomdeger[4]];
                randomdeger.Clear();
            }
        }

    }

    //bolum bitti
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    //yeni level
    public void yeniLevel()
    {
        if (ActiveScene == "level 1")
        {
            SceneManager.LoadScene("level 2");
        }
        else if (ActiveScene == "level 2")
        {
            SceneManager.LoadScene("level 3");
        }
        else if (ActiveScene == "level 3")
        {
            SceneManager.LoadScene("LevelSec");
        }
    }

    //zaman sayaci
    public void zamanSayac()
    {
        Main.time = Convert.ToInt32(timeStart);
        skorPanel.GetComponent<Text>().text = "SKOR: " + Main.skor + "   ZAMAN: " + Main.time;
    }

    // puan hesabı 
    public void puanHesap()
    {
        //score icin
        Main.skor += 500;
        Main.skor = Main.skor - 2 * Main.time - hatalideneme;
        skorPanel.GetComponent<Text>().text = "SKOR: " + Main.skor + "   ZAMAN: " + Main.time;
    }

    //linerenderer
    public void CizgiCiz(Transform t)
    {

        if (Input.GetMouseButtonDown(0) && !drawingLine)
        {
            createLine();
            lineCount++;
            line.SetPosition(0, t.position);
            drawingLine = true;
            canDrawLine = false;
        }
    }

    public void createLine() // create empty GameObject & add component Line Renderer
    {
        line = new GameObject("Line" + lineCount.ToString()).AddComponent<LineRenderer>();
        line.material.color = Color.black;
        line.startWidth = line.endWidth = 0.1f;
        line.positionCount = 2;
    }
    public void ekle(Transform t)
    {
        line.SetPosition(lineCount, t.position);
        line.positionCount += 1;
        lineCount++;
    }
}
