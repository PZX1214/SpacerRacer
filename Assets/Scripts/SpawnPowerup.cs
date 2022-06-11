using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// spawns the powerups in -- we ended up not using this but decided to keep it in for reference
public class SpawnPowerup : MonoBehaviour
{
	//declares or initializes all the variables
	public GameObject powerup;
	public float PmaxX;
	public float PminX;
	public float PmaxY;
	public float PminY;
	public float PtimeBetweenSpawn;
	private double PspawnTime;
	public double Pxyz = 0;
	public float Pcounter = 0;


	// Update is called once per frame
	void Update()
	{
		if (Time.time > PspawnTime)
		{
			pSpawn();
			PspawnTime = Time.time + PtimeBetweenSpawn + (Pxyz); //sets the time between each spawn
		}

	}

	void pSpawn()
	{
		float PrandomX = Random.Range(PminX, PmaxX);
		float PrandomY = Random.Range(PminY, PmaxY);
		Pcounter += 1;
		Instantiate(powerup, transform.position + new Vector3(PrandomX, PrandomY, 0), transform.rotation); //spawns powerup in at random location based off of variables
	}
}
