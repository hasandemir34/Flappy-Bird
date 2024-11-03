using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boruspawner : MonoBehaviour
{

    public birdmanager birdscripts;

    public GameObject Borular;

    public float height;
    public float time = 1f;




 
    private void Start()
    {
        StartCoroutine(Spawnobject(time));
    }
    
    public IEnumerator Spawnobject(float time) 
    {
        while (!birdscripts.isDead)  //ölüp ölmediðini kontrol ediyor.
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity); //borularýn farklý aralýklarda doðuruyo.


            yield return new WaitForSeconds(time); //objeyi spawnlamaya yarýyor ve süresini ben seçiyorum.



        }
     

    }

}

