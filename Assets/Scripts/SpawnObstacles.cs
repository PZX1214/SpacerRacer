using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//spawns the obstacles in
public class SpawnObstacles : MonoBehaviour
{
	//initializes or declares all the variables
	public GameObject obstacle;
	public float maxX;
	public float minX;
	public float maxY;
	public float minY;
	public float timeBetweenSpawn;
	private double spawnTime;
	public double xyz = 0;
	public float counter = 0;
	
	
    // Update is called once per frame
    void Update()
    {
		if(Time.time > spawnTime)
		{
			Spawn();
			spawnTime = Time.time + timeBetweenSpawn + (xyz); //sets the time between each spawn of asteroid
		}
        
    }
	
	void Spawn()
	{
		float randomX = Random.Range(minX, maxX);
		float randomY = Random.Range(minY, maxY);
		counter += 1;
		Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation); //spawns the asteroid based off of variables
		
		
		if (counter > 25) //adjusts the speed of the asteroids as time goes on
		{
			xyz -= 0.008;
		} 
		
		if (counter > -1)
		{
			xyz -= 0.028;
		}
		if (xyz < -0.50)
		{
			xyz = -0.50;
		}

		
	}
}
