using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : MonoBehaviour
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

    /// <summary>
    /// checks for AABB collision between two objects
    /// </summary>
    /// <param name="otherObject"> the object to compare against </param>
    /// <returns></returns>
    public bool AABBCollisionEnemy(PlayerBulletObject otherObject)
    {
        //gets the bounds of two objects
        Bounds thisObjectBounds = this.GetComponent<SpriteRenderer>().bounds;
        Bounds otherObjectBounds = otherObject.GetComponent<SpriteRenderer>().bounds;

        //if their bounds are overlapping...
        if ((thisObjectBounds.min.x < otherObjectBounds.max.x) && (thisObjectBounds.max.x > otherObjectBounds.min.x)
            && (thisObjectBounds.min.y < otherObjectBounds.max.y) && (thisObjectBounds.max.y > otherObjectBounds.min.y))
        {
            //they are colliding
            return true;
        }

        return false;

    }


}
