using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    private bool isAct = false;

    [SerializeField]
    private GameObject Sett;
    
    void OnClick()
    {
        // оставил для какой-нибудь анимации в меню
    }
    public void Mstart()
    {
        if (PlayerPrefs.GetInt("LastLevelContinue", 1) == 1)
        {
            SceneManager.LoadScene("CutScene");
        }
        PlayerPrefs.SetInt("NowLevel", PlayerPrefs.GetInt("LastLevelContinue", 1));
        SceneManager.LoadScene("AllLevelsHere");
    }

    public void MchooseL()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void Msettings()
    {
        if (isAct)
        {
            Sett.SetActive(false);
        } 
        else if (!isAct)
        {
            Sett.SetActive(true);
        }
        
    }

    public void Sapply()
    {
        //save settings
        Msettings();
    }
    public void reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Start_menu");
    }

    public void Mquit()
    {
        Application.Quit();
    }
}