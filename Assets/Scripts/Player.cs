using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    private bool isJumpKeyPressed;
    private Rigidbody rigidbodyComponent;
    private float horizontalInput;
    Sword sword;

    public bool playerIsDead;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.Space))
            isJumpKeyPressed = true;
        horizontalInput = Input.GetAxis("Horizontal");
        
    }
    private void FixedUpdate() 
    {
        rigidbodyComponent.velocity = new Vector2(horizontalInput * 2, rigidbodyComponent.velocity.y);  //maintain y velocity
        if(Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;     //if the player does not overlap the ground dont jump
        }
        if(isJumpKeyPressed)
        {          
            rigidbodyComponent.AddForce(Vector2.up * 5, ForceMode.VelocityChange);  
            isJumpKeyPressed = false;             
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9 || other.gameObject.layer == 11)
        {    
            playerIsDead = true;
            Time.timeScale = 0;   
            GetComponent<Renderer>().enabled = false;
            gameObject.SetActive(false);
            
        }
    }

}



//TO ADD

//NEXT (maybe instead of bullets/shooting) sword stabs out from direction player is facing can hit enemies 
//give (currently) static enemies hp and they die when it runs out
//need a way to determine which way player is facing?
//maybe when arrow keys are hit attack in that direction rather than which way player is facing?


//next: player can shoot bullets when button is pressed - spawned with trajectory (need skybox?)
//then: standing enemies that are destroyed upon contact with bullets (onTriggerEnter-colliding with bullet object)
//(bullet layer)-bullets are destroyed upon colliding with enemy, spikes, tiles

//jump towards cursor (at later stage maybe adjust how far the jump is based on distance between cursor and player?)
//enemies and shooting them

//shooting enemy make a bullet prefab and have a bunch spawn and shoot towards ish the player
//can have a set trajectory starting with the first bullet for the full stream, all shoot at player's position when first is fired


