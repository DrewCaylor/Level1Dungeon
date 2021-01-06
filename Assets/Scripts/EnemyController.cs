using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private float slimeSpeed = 1;
    private float timer = 1.5f; //movement timer
    private bool movingRight = true;
    private int enemyCount;
    public bool noEnemies;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector2(slimeSpeed, rigidbodyComponent.velocity.y);
        //enemyCount = 1; //update when I add enemies
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    private void FixedUpdate() 
    {      
        
        if(timer > 0)
        {
            timer -= Time.deltaTime;              
        }
        else if(movingRight)
        {
            rigidbodyComponent.velocity = new Vector2(-slimeSpeed, rigidbodyComponent.velocity.y);
            timer = 1.5f;
            movingRight = false;
        }
        else
        {
            rigidbodyComponent.velocity = new Vector2(slimeSpeed, rigidbodyComponent.velocity.y);
            timer = 1.5f;
            movingRight = true;
        }      
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9 || other.gameObject.layer == 12)
        {    
            //enemyCount--;
            //if(enemyCount <= 0)
            //{
            //    noEnemies = true;
            //}
            Destroy(gameObject);
            
        }
    }

    
}

//use tags to decide which type of enemy it is and act accordingly for where it matters

//add knockback component when it impacts the sword in ontriggerenter or something
