using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GoToLevel : MonoBehaviour
{


    public void LevelChoose(GameObject Scene)
    {

        int S = Scene.GetComponent<isLock>().Lnum; // ����������� ����� ������, ����� �� ���� �������

        PlayerPrefs.SetInt("NowLevel", S); // �������, ��� ������ �� ��������� ������ �� ���� ������
        //PlayerPrefs.SetString("WhatLevel", Scene.name);
        SceneManager.LoadScene("AllLevelsHere");
    }
    public void CutChoose(GameObject Cut)
    {
        int C = Cut.GetComponent<isLock>().Lnum; // ����������� ����� ������, ����� �� ���� �������
        PlayerPrefs.SetInt("NowLevel", C); // �������, ��� ������ �� ��������� ������ �� ���� ������, ����� ������ � ����� ����� ��� ������ ��������� 
        //PlayerPrefs.SetString("WhatScene", Cut.name);
        SceneManager.LoadScene("CutScene");
    }
    public void BackButt()
    {
        SceneManager.LoadScene("Menu");
    }
}
