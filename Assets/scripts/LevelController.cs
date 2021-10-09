using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private string Level;
    private GameObject lvl;
    private int next;

    void Start()
    {
        PlayerPrefs.SetInt("EndL", 0);
        Spawn();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("EndL") == 1)
        {
            PlayerPrefs.SetInt("EndL", 0);
            Destroy(lvl);
            NextLevel();           
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hero")
        {
            NextLevel();
            Destroy(lvl);
            // сделать проверку на наличие кат сцены, если есть то на неё
        }
    }*/
    void Spawn()
    {
        Level = "LevelsPrefabs/Level_" + PlayerPrefs.GetInt("NowLevel", 1);
        //Debug.Log(Level);
        lvl = Instantiate(Resources.Load(Level, typeof(GameObject)), new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    private void NextLevel()
    {
        next = PlayerPrefs.GetInt("LastLevelContinue") + 1;
        if (PlayerPrefs.GetInt("LastLevelContinue") == PlayerPrefs.GetInt("NowLevel"))
        {
            PlayerPrefs.SetInt("NowLevel", next);
            PlayerPrefs.SetInt("LastLevelContinue", next);
        }
        else if (PlayerPrefs.GetInt("LastLevelContinue") > PlayerPrefs.GetInt("NowLevel"))
        {
            PlayerPrefs.SetInt("NowLevel", PlayerPrefs.GetInt("NowLevel") + 1);
        }
        Spawn();
    }
}
