using UnityEngine.SceneManagement;
using UnityEngine;

public class DataLoad : MonoBehaviour
{

    void Start()
    {
        //������ ������ � �����
        // ��� ������� ���� ����� ��������
        //PlayerPrefs.SetInt("LastLevelContinue", 1);
        //PlayerPrefs.SetInt("NowLevel", 1);
        // or
        //PlayerPrefs.DeleteAll();
        //������ ���� ������ reset � ���������� 
        
    }
    private void Update()
    {                                    // �������� ����� "�� ����� �����?" -> �� / ���, �� ����� ������� �������� ��������� ��� ����� ��� ���
        if (Input.GetMouseButtonDown(0)) // ���������� �� "������� �� ����� �������"
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
