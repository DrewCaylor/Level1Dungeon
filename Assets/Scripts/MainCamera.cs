using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform playerTransform;
    //public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerTransform != null)
            this.transform.position = new Vector3 (playerTransform.position.x, playerTransform.position.y, this.transform.position.z);
    }
 
  
}
