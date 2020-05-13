using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSec : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("level 3");
    }
}
