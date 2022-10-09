using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public CollisionManager collisionManager;

    private void Update()
    {
       
    }


    /*public List<EnemyObject> enemyObjects;

    public Vector2 minSpawnPoint, maxSpawnPoint;

    public List<SpriteRenderer> spawnedEnemies;
    public List<EnemyObject> spawnedEnemyObjects;

    float time;


    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        Spawn();
    }

    private void Update()
    {
        time += Time.deltaTime;

        if(time % 7f == 0f)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        CleanUp();

        for (int i = 0; i < Random.Range(1f, Random.Range(time + 2f, 20)); i++)
        {
            spawnedEnemies.Add(SpawnCreature());
        }
    }

    private void CleanUp()
    {
        // destroy all GameObjects
        foreach (SpriteRenderer creature in spawnedEnemies)
        {
            Destroy(creature.gameObject);
        }

        foreach (EnemyObject creature in spawnedEnemyObjects)
        {
            Destroy(creature.gameObject);
        }

        // empty out my collection
        spawnedEnemies.Clear();
        spawnedEnemyObjects.Clear();
    }

    private SpriteRenderer SpawnCreature()
    {
        Vector3 spawnPoint = new Vector2(Random.Range(minSpawnPoint.x, maxSpawnPoint.x), Random.Range(minSpawnPoint.y, maxSpawnPoint.y));
        EnemyObject random = PickRandom();
        SpriteRenderer newCreature = Instantiate(random, spawnPoint, Quaternion.identity, transform).GetComponent<SpriteRenderer>();

        spawnedEnemyObjects.Add(Instantiate(random, spawnpoint, transform.rotation));

        return newCreature;

    }


    public EnemyObject PickRandom()
    {
        EnemyObject pickedEnemy;

        // pick a random number
        float randVal = Random.Range(0f, 1f);

        // look up enemy based off number
        //easiet has higher spawn rate, harder has a lower spawn rate

        // easiet 40%
        if (randVal <= 0.40f)
        {
            pickedEnemy = enemyObjects[0];
        }
        // 30%
        else if ((randVal > 0.40f) && (randVal <= 0.70f))
        {
            pickedEnemy = enemyObjects[1];
        }
        // 15% 
        else if ((randVal > 0.70f) && (randVal <= 0.85f))
        {
            pickedEnemy = enemyObjects[2];
        }
        // 10%
        else if ((randVal > 0.85f) && (randVal <= 0.95f))
        {
            pickedEnemy = enemyObjects[3];
        }
        // 5%
        else
        {
            pickedEnemy = enemyObjects[4];
        }

        return pickedEnemy;
    } */
}
