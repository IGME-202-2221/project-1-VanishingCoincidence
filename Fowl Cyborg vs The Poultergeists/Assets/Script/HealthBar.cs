using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    List<GameObject> lives;

    [SerializeField]
    GameObject gameOver;

    [SerializeField]
    PlayerObject player;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject life in lives)
        {
            life.GetComponent<SpriteRenderer>().enabled = true;
        }

        gameOver.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (player.GetComponent<PlayerObject>().lives == 4)
        {
            lives[4].GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (player.GetComponent<PlayerObject>().lives == 3)
        {
            lives[3].GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (player.GetComponent<PlayerObject>().lives == 2)
        {
            lives[2].GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (player.GetComponent<PlayerObject>().lives == 1)
        {
            lives[1].GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (player.GetComponent<PlayerObject>().lives == 0)
        {
            lives[0].GetComponent<SpriteRenderer>().enabled = false;
            gameOver.GetComponent<SpriteRenderer>().enabled = true;
            Time.timeScale = 0;
        }
    }
}
