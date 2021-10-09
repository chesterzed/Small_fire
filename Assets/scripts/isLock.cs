using UnityEngine;
using UnityEngine.UI;

public class isLock : MonoBehaviour
{
    [SerializeField] private Button lvl;
    public int Lnum;
    void Start()
    {
        if (Lnum <= PlayerPrefs.GetInt("LastLevelContinue", 1))
        {
            lvl.interactable = true;
        }
        else
        {
            lvl.interactable = false;
        }
    }
}
