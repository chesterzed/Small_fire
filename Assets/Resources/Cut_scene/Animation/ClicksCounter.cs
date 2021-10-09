using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ClicksCounter : MonoBehaviour
{
    private void Awake()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play();
        //AnimaStart.Play("Cut_Start"); //запуск анимации через имя 
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
        }
    }
    public void OnSwitch(int id)
    {
        Time.timeScale = 0f;
    }
    public void end()
    {
        // можно поменять на "возврат только на AllLevelsHere"
        if (PlayerPrefs.GetInt("LastLevelContinue", 1) == PlayerPrefs.GetInt("NowLevel", 1))
        {
            SceneManager.LoadScene("AllLevelsHere");
        }
        else
        {
            SceneManager.LoadScene("LevelMenu");
        }
    }
}
