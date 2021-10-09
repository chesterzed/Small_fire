using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Rigidbody2D Hero;
    public GameObject cam;
    void Update()
    {
        cam.transform.position = new Vector3(Hero.position.x, Hero.position.y, -10);
    }

}
