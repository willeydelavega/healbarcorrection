using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int initialHealth = 100;

    [SerializeField] IntVariable health;
    public int Health { get { return health.Value; } private set { } }
    
    
    
     private void Awake()
    {
        // Ici on met tout ce qui est initialisation de variables interne à la classe 
        health.Value = initialHealth;
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


       public void GetHurt(int damage)
    {
        health.Value = health.Value - damage;
        if (health.Value <= 0) health.Value = 0;
        //_displayHealth.GetComponent<HealthDisplay>().SetHealth(health.Value);

    }
}
