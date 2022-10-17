using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletCreate : MonoBehaviour
{

    public List<GameObject> bullets;

    [SerializeField]
    GameObject bullet;

    public GameObject manager;

    [SerializeField]
    Sprite blueBullet;
    [SerializeField]
    Sprite redBullet;
    [SerializeField]
    Sprite greenBullet;

    [SerializeField]
    bool isME;
    [SerializeField]
    bool isHE;
    [SerializeField]
    bool isBossE;

    float timeME;
    float timeHE;
    float timeBossE;

    // Start is called before the first frame update
    void Start()
    {
        bullets = manager.GetComponent<CollisionManager>().enemyBulletsList;
    }

    // Update is called once per frame
    void Update()
    {
        timeME += Time.deltaTime;
        timeHE += Time.deltaTime;
        timeBossE += Time.deltaTime;

        if (isME)
        {
            if (timeME > 1.7f)
            {
                bullet.GetComponent<SpriteRenderer>().sprite = blueBullet;
                GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);

                bullets.Add(newBullet);

                timeME = 0;
            }
        }
        else if (isHE)
        {
            if (timeHE > 1.3f)
            {
                bullet.GetComponent<SpriteRenderer>().sprite = redBullet;
                GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);

                bullets.Add(newBullet);

                timeHE = 0;
            }
        }
        else if (isBossE)
        {
            if(timeBossE > 2.3f && timeBossE < 2.8f)
            {
                bullet.GetComponent<SpriteRenderer>().sprite = greenBullet;
                GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);

                bullets.Add(newBullet);
            }

            if(timeBossE > 2.8f)
            {
                timeBossE = 0;
            }
        }

    }
}
