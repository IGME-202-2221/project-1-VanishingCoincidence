using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    [SerializeField]
    PlayerBulletObject bullet;

    float time = 0;

    public List<PlayerBulletObject> bullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

    }
    
    public void Spawn()
    {
        if (time >= 0.3f)
        {
            PlayerBulletObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            bullets.Add(newBullet);

            time = 0;
        }  
    }


}
