using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float xPos;
    float yPos;
    float speed;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find(name: "Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(xPos, yPos, 0);
        xPos -= speed; 

        if (xPos < -10f)
        {
            player.addScore(1);
            Destroy(gameObject);
        }
    }

    public void SetPosition(float xPos, float yPos, float speed)
    {
        this.xPos = xPos;
        this.yPos = yPos;
        this.speed = speed;
    }
}
