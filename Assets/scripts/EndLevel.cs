using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero")
        {
            Debug.Log("Toched");
            PlayerPrefs.SetInt("EndL", 1); // ���� �� ��������� ������ ������ �������� ����������, � �� � LevelController ����, check Undate()
        }
    }
}
