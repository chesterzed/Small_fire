using UnityEngine.SceneManagement;
using UnityEngine;

public class DataLoad : MonoBehaviour
{

    void Start()
    {
        //Начать играть с нчала
        // Для запуска игры через катсцену
        //PlayerPrefs.SetInt("LastLevelContinue", 1);
        //PlayerPrefs.SetInt("NowLevel", 1);
        // or
        //PlayerPrefs.DeleteAll();
        //теперь есть кнопка reset в настройках 
        
    }
    private void Update()
    {                                    // добавить выбор "вы новый игрок?" -> Да / Нет, от этого зависит включать начальную кат сцену или нет
        if (Input.GetMouseButtonDown(0)) // переделать на "нажмите на любую клавишу"
        {
            if (PlayerPrefs.GetInt("IsFirst", 1) == 1)
            {
                
                //Debug.Log("First");
                PlayerPrefs.SetInt("LastLevelContinue", 1);
                PlayerPrefs.SetInt("NowLevel", 1);
                PlayerPrefs.SetInt("IsFirst", 0);
                SceneManager.LoadScene("CutScene");
            }
            else
            {
                //Debug.Log("Not first");
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
