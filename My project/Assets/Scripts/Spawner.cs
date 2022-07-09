using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject longCubePrefab;
    public GameObject coin;

    private float spawnTime = 3f;
    private int randNumb = 0;
    private int ratio = 8;

    float nowTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        nowTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - nowTime > spawnTime)
        {
            randNumb = Random.Range(0, 10);
            if (randNumb <= ratio)
            {
                if (randNumb % 2 == 0)
                {
                    GameObject obst = Instantiate(cubePrefab, new Vector3(12f, 6f, 0f), Quaternion.identity);
                    obst.GetComponent<Cube>().SetPosition(12f, Random.Range(0f, 1.5f), Random.Range(0.015f, 0.03f));
                }
                else
                {
                    GameObject obst = Instantiate(longCubePrefab, new Vector3(12f, 6f, 0f), Quaternion.identity);
                    obst.GetComponent<LongCube>().SetPosition(12f, Random.Range(1f, 3f), Random.Range(0.015f, 0.02f));
                }
            }
            else
            {
                GameObject bonus = Instantiate(coin, new Vector3(12f, 6f, 0f), Quaternion.identity);
                bonus.GetComponent<Coin>().SetPosition(12f, Random.Range(1f, 4f), Random.Range(0.015f, 0.02f));
            }

            nowTime = Time.time;
        }

    }
}
