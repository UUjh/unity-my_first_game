using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower = 3;
    public float realJump = 5;
    private bool isGround = true;


    TextMeshPro scoreOutput;
    TextMeshPro coinOutput;
    public int score = 0;
    public int coinScore = 0;

    Rigidbody rb;
    Player player;

    private void Awake()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMeshPro>();
        coinOutput = GameObject.Find(name: "Coin").GetComponent<TextMeshPro>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && isGround)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, realJump, 0);

            isGround = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Destroy(other.gameObject);
            getCoin(10);
        }
    }

    public void getCoin(int c)
    {
        coinScore += c;
        coinOutput.text = "Coin: " + coinScore;

    }




}
