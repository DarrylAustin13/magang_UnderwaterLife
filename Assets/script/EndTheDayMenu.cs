using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTheDayMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
    }

    public void EndThisDay()
    {
        SceneManager.LoadScene("NightMenu");
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
    }
    
}
