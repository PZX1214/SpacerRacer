using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

//codes the speed powerup
public class FPowerup : MonoBehaviour
{
	private GameObject player; //UFO
	public CameraMovement Fcamera; //creates a camera object

	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	private async void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Border")
		{
			Destroy(this.gameObject); //when obstacle hits border it gets destroyed
		}

		else if (collision.tag == "Player")
		{
			Fcamera.cameraSpeed = 25f; //when powerup hits player speed of camera inc. to 25
			await putDelay();
			resetSpeed();

		}
	}

	async Task putDelay()
	{
		await Task.Delay(10000); //puts a wait time of 10 seconds
	}

	public void resetSpeed()
	{
		Fcamera.cameraSpeed = 15f; //reverts code back to normal camera speed
	}
}
