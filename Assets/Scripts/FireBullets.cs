﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullets : MonoBehaviour
{
   
    
    public int bulletsAmount;

    public float startAngle , endAngle;

    private Vector2 bulletMoveDirection;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);
    }

    private void Fire(){
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++ ){
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180F);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180F);

            Vector3 bulMoveVector = new Vector3(bulDirX,bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletScript.bulletScriptInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.position = transform.position;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

        angle += angleStep;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
