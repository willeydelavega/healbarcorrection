using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] int damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        
        
        
       Character characterToHurt = other.GetComponent<Character>();


        if (characterToHurt)
        {
            
            characterToHurt.GetHurt(damage);
          

            Destroy(gameObject);
        }
       

    }
}
