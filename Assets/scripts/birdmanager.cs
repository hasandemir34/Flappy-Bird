using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdmanager : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float strong=1f;
    public bool isDead;
    public gamemanager managergame;
    public GameObject deathscreen;

    private void Start()
    {
        Time.timeScale = 1;
    }




    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) //t�klamay� al
        {
            rb2D.velocity = Vector2.up * strong; //z�plat 
        
        
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision) //borular�n aras�ndan ge�timi ona bak�yo!
    {
        if (collision.gameObject.name == "scorearea")
        {
            managergame.Updatescore();



        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deatdharea") //ku� �lmesi gereken yerlere �arparsa demek
        {
            isDead = true; //�ld�r�yo
            Time.timeScale = 0; //oyunu durduruyor. 
            deathscreen.SetActive(true); //�l�m ekran�n� �a��r�yo sceen ekran�nda s�r�kl�yerek vericem 


        }
        

    }






}
