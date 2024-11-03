using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 8); //borular doðduktan 8 saniye sonra yok edecek ve oyun kasmayacak.
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
