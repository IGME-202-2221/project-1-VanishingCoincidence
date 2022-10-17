using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [SerializeField]
    EnemySpawer spawner;

    public List<GameObject> enemies;


    [SerializeField]
    PlayerObject player;

    [SerializeField]
    List<PlayerBulletObject> bulletsList;

    public List<GameObject> enemyBulletsList;

    // Start is called before the first frame update
    void Start()
    {
        bulletsList = new List<PlayerBulletObject>();
        enemyBulletsList = new List<GameObject>();
        enemies = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        bulletsList = player.GetComponent<PlayerFire>().bullets;
        enemies = spawner.GetComponent<EnemySpawer>().enemyObjects;


        //==========================================RESET==========================================

        //makes sure the objects colliding is being reset if they're no longer colliding
        for (int i = 0; i < enemies.Count; i++)
        {
            if(enemies[i] != null)
            {
                enemies[i].GetComponent<EnemyObject>().isCurrentlyColliding = false;
            }   
        }


        foreach (PlayerBulletObject collision in bulletsList)
        {
            collision.isCurrentlyColliding = false;
        }

        player.isCurrentlyColliding = false;




        //==========================================COLLIDE==========================================

        //enemies----------------------------------------------------------------------
        for (int i = 0; i < enemies.Count; i++)
        {
            if(enemies[i] != null)
            {
                //goes through all the other collidable objects
                for (int j = 0; j < bulletsList.Count; j++)
                {
                    //checks to see if they're colliding using AABB collision
                    if (bulletsList[j].AABBCollision(enemies[i]))
                    {
                        enemies[i].GetComponent<EnemyObject>().isCurrentlyColliding = true;
                        if (enemies[i].GetComponent<SpriteRenderer>().color != Color.red)
                        {
                            --enemies[i].GetComponent<EnemyObject>().lives;
                            player.GetComponent<PlayerObject>().score += 5;
                        }
                        bulletsList[j].isCurrentlyColliding = true;
                    }
                }

                //checks to see if they're colliding using AABB collision
                if (player.AABBCollision(enemies[i]))
                {
                    enemies[i].GetComponent<EnemyObject>().isCurrentlyColliding = true;
                    player.isCurrentlyColliding = true;
                }
            }
            
        }

        //enemy bullets-------------------------------------------------------------------------
        for (int i= 0; i < enemyBulletsList.Count; i++)
        {
            if(player.AABBCollision(enemyBulletsList[i]))
            {
                enemyBulletsList[i].GetComponent<EnemyBulletMove>().isCurrentlyColliding = true;
                player.isCurrentlyColliding = true;
            }
        }
    }
}

