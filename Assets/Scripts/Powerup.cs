using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

//codes the powerup that makes the player go slow
public class Powerup : MonoBehaviour
{
	private GameObject player; //UFO
	public CameraMovement camera; //creates Camera object

	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	private async void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Border")
		{
			Destroy(this.gameObject); //when powerup comes in contact with border, powerup is destroyed
		}

		else if (collision.tag == "Player")
		{
			camera.cameraSpeed = 5f;
			await putDelay(); //when powerup comes in contact with player, camera speed dec to 5f
			resetSpeed();

		}
	}

	async Task putDelay()
    {
		await Task.Delay(10000); //wait time for 10 seconds
	}

	public void resetSpeed()
    {
		camera.cameraSpeed = 15f; //resets speed of camera
    }
}
