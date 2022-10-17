using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField]
    PlayerObject player;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = player.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = player.score.ToString();
    }
}
