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
        
        if (Input.GetMouseButtonDown(0)) //týklamayý al
        {
            rb2D.velocity = Vector2.up * strong; //zýplat 
        
        
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision) //borularýn arasýndan geçtimi ona bakýyo!
    {
        if (collision.gameObject.name == "scorearea")
        {
            managergame.Updatescore();



        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deatdharea") //kuþ ölmesi gereken yerlere çarparsa demek
        {
            isDead = true; //öldürüyo
            Time.timeScale = 0; //oyunu durduruyor. 
            deathscreen.SetActive(true); //ölüm ekranýný çaðýrýyo sceen ekranýnda sürüklüyerek vericem 


        }
        

    }






}
