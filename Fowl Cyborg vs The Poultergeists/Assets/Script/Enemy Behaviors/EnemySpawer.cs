using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawer : MonoBehaviour
{
    [SerializeField]
    GameObject manager;

    [SerializeField]
    List<GameObject> enemyChoices;

    public List<GameObject> enemyObjects;

    Vector3 spawnPosition;

    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;

        spawnPosition.x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        spawnPosition.y = Random.Range(-4f, 4f);

        if(timer > 1f)
        {
            timer = 0;

            GameObject temp = Instantiate(PickRandom(), spawnPosition, Quaternion.identity);
            temp.GetComponent<EnemyBulletCreate>().manager = manager;
            enemyObjects.Add(temp);

        }
    }

    public GameObject PickRandom()
    {
        GameObject pickedEnemy;

        // pick a random number
        float randVal = Random.Range(0f, 1f);

        // look up enemy based off number
        //easiet has higher spawn rate, harder has a lower spawn rate

        // easiet 50%
        if (randVal <= 0.50f)
        {
            pickedEnemy = enemyChoices[0];
        }
        // 30%
        else if ((randVal > 0.50f) && (randVal <= 0.80f))
        {
            pickedEnemy = enemyChoices[1];
        }
        // 10% 
        else if ((randVal > 0.80f) && (randVal <= 0.90f))
        {
            pickedEnemy = enemyChoices[2];
        }
        // 5%
        else if ((randVal > 0.90f) && (randVal <= 0.97f))
        {
            pickedEnemy = enemyChoices[3];
        }
        // 3%
        else
        {
            pickedEnemy = enemyChoices[4];
        }

        return pickedEnemy;
    } 
}
