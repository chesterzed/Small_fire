using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScene : MonoBehaviour
{
    private string Scene;
    private GameObject sc;
    void Start()
    {
        Scene = "Cut_scene/Cut" + PlayerPrefs.GetInt("NowLevel", 1);
        //Debug.Log(Scene);
        sc = Instantiate(Resources.Load(Scene, typeof(GameObject)), new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }
}
