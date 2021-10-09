using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GoToLevel : MonoBehaviour
{


    public void LevelChoose(GameObject Scene)
    {

        int S = Scene.GetComponent<isLock>().Lnum; // вытаскиваем номер уровн€, чтобы на него перейти

        PlayerPrefs.SetInt("NowLevel", S); // отмечаю, что теперь мы находимс€ именно на Ё“ќћ уровне
        //PlayerPrefs.SetString("WhatLevel", Scene.name);
        SceneManager.LoadScene("AllLevelsHere");
    }
    public void CutChoose(GameObject Cut)
    {
        int C = Cut.GetComponent<isLock>().Lnum; // вытаскиваем номер уровн€, чтобы на него перейти
        PlayerPrefs.SetInt("NowLevel", C); // отмечаю, что теперь мы находимс€ именно на Ё“ќћ уровне, номер уровн€ и сцена перед ним должны совпадать 
        //PlayerPrefs.SetString("WhatScene", Cut.name);
        SceneManager.LoadScene("CutScene");
    }
    public void BackButt()
    {
        SceneManager.LoadScene("Menu");
    }
}
