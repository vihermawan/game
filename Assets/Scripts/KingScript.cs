﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingScript : MonoBehaviour
{
    public static KingScript Instance;
    public GameObject destructionVFX;
    
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Shoot"){
            health--;
            if(health == 0){
            Instantiate(destructionVFX, transform.position, Quaternion.identity);       
            Destroy(this.gameObject);
            GlobalScript.Instance.AddScoreKing();
            GlobalScript.Instance.Win();
            }
        }
    }
}
