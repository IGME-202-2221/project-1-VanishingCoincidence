using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Vector3 bulletPosition;

    [SerializeField]
    Vector3 velocity = new Vector3(10f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        bulletPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // add velocity to the position
        bulletPosition += velocity;

        // "draw" this player at this position
        transform.position = bulletPosition;
    }
}
