using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_of_beginning : MonoBehaviour
{
    public GameObject sphere;
    void Update()
    {
        sphere = GameObject.FindWithTag("part_of_power");
        //Debug.Log(sphere);  
        if (!sphere)
        {
            SceneManager.LoadScene("AllLevelsHere");
        }
    }
}
