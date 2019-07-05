using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHai : MonoBehaviour
{
    public playermov movement;
    void OnCollisionEnter(Collision CollisionInfo)
    {
        //Debug.Log(CollisionInfo.collider.tag);
        if (CollisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
