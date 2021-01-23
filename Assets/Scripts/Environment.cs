using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    //public Transform playerTransform;
    private Rigidbody rigidbodyComponent;
    private float rollSpeed = 2;


    // Start is called before the first frame update
    void Start()
    {
        if(this.tag == "Boulder")
        {
            rigidbodyComponent = GetComponent<Rigidbody>();
            rigidbodyComponent.velocity = new Vector2(0, -.1f); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate() 
    {   
        if(rigidbodyComponent.velocity.y == 0)
        {
            rigidbodyComponent.velocity = new Vector2(-rollSpeed, rigidbodyComponent.velocity.y); //roll left at rollspeed
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.tag == "Boulder" && other.tag == "Spikes")
        {    
            Destroy(gameObject);
            
        }
    }
}


//IF TAG IS BOULDER, ROLL LEFT UPON SPAWN UNTIL HITTING SPIKES THEN stop
//need it to spawn when player reaches a certain x coordinate
//maybe if player transform is within some distance of this object?

//WHEN SPAWN
//gameObject.SetActive(true);
//rigidbodyComponent = GetComponent<Rigidbody>();
//rigidbodyComponent.velocity = new Vector2(slimeSpeed, rigidbodyComponent.velocity.y);
