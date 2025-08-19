using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginDiving : MonoBehaviour
{
    public void EnterSea(int SeaLevel)
    {
        string LevelName = "Diving Lv " + SeaLevel;
        SceneManager.LoadScene(LevelName); 
    }
}
