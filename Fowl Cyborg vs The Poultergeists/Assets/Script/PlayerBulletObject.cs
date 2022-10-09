using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletObject : MonoBehaviour
{
    public bool isCurrentlyColliding = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        //if the object is colliding...
        if (isCurrentlyColliding)
        {
            //change to red
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        //if the object isn't colliding...
        else
        {
            //leave it as its original color
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

}
