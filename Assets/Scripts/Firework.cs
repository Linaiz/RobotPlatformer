using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firework : MonoBehaviour
{
    public GameObject gameobject;

    // Start is called before the first frame update
    void Start()
    {
        gameobject = Resources.Load("Animation/Explosion") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //gameobject = Instantiate(Resources.Load("Animation/Test",typeof(GameObject))) as GameObject;
        Instantiate(gameobject);
        //gameobject.transform.position = transform.position;


    }
}
