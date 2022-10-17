using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightEnemyMovement : MonoBehaviour
{
    //fields----------------------------------------------------------------------------------------------------------------

    [SerializeField]
    float speed = 1f;

    public Vector3 enemyPosition = Vector3.zero;

    public Vector3 direction = Vector3.left;

    [SerializeField]
    Vector3 velocity = Vector3.zero;


    //starting methods------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        // velocity is direction * speed * deltaTime
        velocity = direction * speed * Time.deltaTime;

        // add velocity to the position
        enemyPosition += velocity;

        // "draw" this player at this position
        transform.position = enemyPosition;

    }
}
