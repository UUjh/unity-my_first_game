using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	float xPos;
	float yPos;
	float speed;
	Player player;
	// Use this for initialization
	void Start()
	{
		player = GameObject.Find(name: "Player").GetComponent<Player>();
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = new Vector3(xPos, yPos, 0);
		xPos = xPos - speed;

		if (xPos < -10f)
		{
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
