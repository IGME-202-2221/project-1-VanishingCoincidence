using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagEnemyMovement : MonoBehaviour
{
    //fields----------------------------------------------------------------------------------------------------------------

    [SerializeField]
    float speed = 1f;

    public Vector3 enemyPosition = Vector3.zero;

    public Vector3 direction = Vector3.left;

    [SerializeField]
    Vector3 velocity = Vector3.zero;

    [SerializeField]
    float switchTimer = 0;
    [SerializeField]
    float moveTimer = 0;

    //starting methods------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = transform.position;
  
    }

    // Update is called once per frame
    void Update()
    {
        moveTimer += Time.deltaTime;

        if(moveTimer < 3f)
        {
            switchTimer = 0;

            // velocity is direction * speed * deltaTime
            velocity = direction * speed * Time.deltaTime;

            // add velocity to the position
            enemyPosition += velocity;

            // "draw" this player at this position
            transform.position = enemyPosition;
        }
        else
        {
            switchTimer += Time.deltaTime;

            if(switchTimer < 0.1f)
            {
                direction.y = Random.Range(-1f, 1f);
            }

            if (switchTimer > 1f)
            {
                moveTimer = 0;
            }
        }
        

    }

}
