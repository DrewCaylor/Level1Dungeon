using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public Transform playerTransform;
    private Rigidbody rigidbodyComponent;
    private float rollSpeed = 1;


    // Start is called before the first frame update
    void Start()
    {
        /*if(tag == "boulder")
        {
            gameObject.SetActive(false);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {    
           
            //stop moving
            
        }
    }*/
}


//IF TAG IS BOULDER, ROLL LEFT UPON SPAWN UNTIL HITTING SPIKES THEN stop
//need it to spawn when player reaches a certain x coordinate
//maybe if player transform is within some distance of this object?

//WHEN SPAWN
//gameObject.SetActive(true);
//rigidbodyComponent = GetComponent<Rigidbody>();
//rigidbodyComponent.velocity = new Vector2(slimeSpeed, rigidbodyComponent.velocity.y);
