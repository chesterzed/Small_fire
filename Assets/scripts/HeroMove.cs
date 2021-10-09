using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public float speed;

    private Rigidbody2D Hero;
    private Vector2 moveVelocity;

    //float timer = 0;

    void Start()
    {
        PlayerPrefs.SetString("white", "1");
        Hero = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        
        //timer += Time.deltaTime;
        //Debug.Log(timer);
    }

    void FixedUpdate()
    {
        Hero.MovePosition(Hero.position + moveVelocity * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "part_of_power")
        {
            New_mode(collision.gameObject.name);
        }
    }
    private void New_mode(string a)
    {
        //1 - white, 2 - blue, 3 - red, 4 - yellow, 5 - green (nevermind about that, it is just trash here)

        PlayerPrefs.SetString(a, "1");
        ChangeColor();
        //Debug.Log(PlayerPrefs.GetString(a)); //проверОчка, под каким ключом сохраняется "1"
        
    }
    private void ChangeColor()
    {
        //timer = 0;
        //Debug.Log(timer);
        //transform.GetComponent<Renderer>().material.color = Color.Lerp(Color.white, new Color(0.125f, 0.61f, 0.88f, 1f), timer);
        transform.GetComponent<Renderer>().material.color = new Color(0.125f, 0.61f, 0.88f, 1f);
        gameObject.GetComponent<Light>().color = new Color(0.129f, 0.63f, 0.9f, 1f);
    }
}
