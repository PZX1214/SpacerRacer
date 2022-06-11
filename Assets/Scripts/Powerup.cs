using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;


public class Powerup : MonoBehaviour
{
	private GameObject player;
	public CameraMovement camera;

	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	private async void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Border")
		{
			Destroy(this.gameObject);
		}

		else if (collision.tag == "Player")
		{
			camera.cameraSpeed = 5f;
			await putDelay();
			resetSpeed();

		}
	}

	async Task putDelay()
    {
		await Task.Delay(10000);
	}

	public void resetSpeed()
    {
		camera.cameraSpeed = 15f;
    }
}
