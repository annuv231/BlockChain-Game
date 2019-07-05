using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{

    public Transform player;
    //for making tpp cancer
    public Vector3 offset;
    // Update is called once per frame
    bool fppmode = false;
    void Update()
    {
  
            transform.position = player.position + offset;
     
    }
}
