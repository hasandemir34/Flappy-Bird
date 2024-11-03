using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //text koyduðumda kullanabilmek için.
using UnityEngine.SceneManagement;



public class gamemanager : MonoBehaviour

{
    public int score; 
    //public Text scoreText;
    public TMP_Text scoreText; //bunu yusufdan öðrendim güncel hali bu buranýn.
    


    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Updatescore()   //skor takibi ve yazýmý
    {
        score++;
        scoreText.text = score.ToString();    

    }
    public void RestartGame() //oyunu tekrar baþlatma (yukarýda using scene manager kullandýk onu unutma.)
    {
        SceneManager.LoadScene(0); //ilk sahneyi yüklemek için

    }

}
