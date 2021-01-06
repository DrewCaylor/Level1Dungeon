using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Transform playerTransform;
    private bool rightAttack;
    private bool leftAttack;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))  //NEED TO ADD ALL ARROW FUNCTIONALITY LATER
        {
            rightAttack = true;
        }  
        if(Input.GetKeyDown(KeyCode.LeftArrow))  //NEED TO ADD ALL ARROW FUNCTIONALITY LATER
        {
            leftAttack = true;
        }  
        
    }
    private void FixedUpdate() 
    {
        if(playerTransform != null)
        {
            if(rightAttack)   //CHECK IF SWORD BUTTON WAS PRESSED AND STABBY STABBY
            { 

                this.transform.position = new Vector2 ((float)(this.transform.position.x + .5), this.transform.position.y);
                rightAttack = false;
            }//then put rest of if(other attack direction)
            else if(leftAttack)   //CHECK IF SWORD BUTTON WAS PRESSED AND STABBY STABBY
            { 

                this.transform.position = new Vector2 ((float)(this.transform.position.x - .5), this.transform.position.y);
                leftAttack = false;
            }//then put rest of if(other attack direction)
            else
            {
                this.transform.position = new Vector2 (playerTransform.position.x, playerTransform.position.y);   
            }
        }

            
             
    }
}
//i need to make the sword attack slower?

//FOR NOW ADD GAME WIN SCREEN WHEN ALL ENEMIES DEFEATED