using UnityEngine.SceneManagement;
using UnityEngine;

public class InGameButtons : MonoBehaviour
{
    private bool isAct = false;
    private bool isPause = false;

    [SerializeField]
    private GameObject Paus;
    [SerializeField]
    private GameObject Sett;

    void Start()
    {
        Time.timeScale = 1f;
    }
    
    public void InGpause()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1f;
            Paus.SetActive(false);
        }
        else if (!isPause)
        {
            isPause = true;
            Time.timeScale = 0f;
            Paus.SetActive(true);
        }
    }

    public void InGsettings()
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

    public void InGmainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
