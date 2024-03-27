using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;
    //public PlayerHealth PlayerHealth;

    public void DealDamage(float damage)
    {
        //PlayerHealth = GetComponent<PlayerHealth>();
        value -= damage;
        if(value <= 0)
        {
            //PlayerHealth.czethik -= 1; 
            Destroy(gameObject); 
                     
        }
    }
    

}
