using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //text koydu�umda kullanabilmek i�in.
using UnityEngine.SceneManagement;



public class gamemanager : MonoBehaviour

{
    public int score; 
    //public Text scoreText;
    public TMP_Text scoreText; //bunu yusufdan ��rendim g�ncel hali bu buran�n.
    


    
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

    public void Updatescore()   //skor takibi ve yaz�m�
    {
        score++;
        scoreText.text = score.ToString();    

    }
    public void RestartGame() //oyunu tekrar ba�latma (yukar�da using scene manager kulland�k onu unutma.)
    {
        SceneManager.LoadScene(0); //ilk sahneyi y�klemek i�in

    }

}
