using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{ 
    public List<EnemyObject> enemies;

    [SerializeField]
    PlayerObject player;

    [SerializeField]
    List<PlayerBulletObject> bulletsList;

    // Start is called before the first frame update
    void Start()
    {
        bulletsList = new List<PlayerBulletObject>();
    }

    // Update is called once per frame
    void Update()
    {

        bulletsList = player.GetComponent<PlayerFire>().bullets;

        //--------------RESET------------------------------

        //makes sure the objects colliding is being reset if they're no longer colliding
        foreach (EnemyObject collision in enemies)
        {
            collision.isCurrentlyColliding = false;
        }

        foreach (PlayerBulletObject collision in bulletsList)
        {
            collision.isCurrentlyColliding = false;
        }

        player.isCurrentlyColliding = false;


        //-----------------COLLIDE------------------------------------

        //goes through each collidable object
        for (int i = 0; i < enemies.Count; i++)
        {
            //goes through all the other collidable objects
            for (int j = 0; j < bulletsList.Count; j++)
            {
                //checks to see if they're colliding using AABB collision
                if (enemies[i].AABBCollisionEnemy(bulletsList[j]))
                {
                    enemies[i].isCurrentlyColliding = true;
                    bulletsList[j].isCurrentlyColliding = true;
                }
            }

            //checks to see if they're colliding using AABB collision
            if (player.AABBCollisionPlayer(enemies[i]))
            {
                enemies[i].isCurrentlyColliding = true;
                player.isCurrentlyColliding = true;
            }
        }
    }
}

