using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour
{
    public Vector3 bulletPosition;

    [SerializeField]
    Vector3 velocity = new Vector3(1f, 0f, 0f);

    public bool isCurrentlyColliding = false;

    // Start is called before the first frame update
    void Start()
    {
        bulletPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // add velocity to the position
        bulletPosition += -(velocity) * Time.deltaTime;

        // "draw" this player at this position
        transform.position = bulletPosition;
    }
}
