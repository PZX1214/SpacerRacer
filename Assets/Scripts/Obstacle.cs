using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//creates obstacles
public class Obstacle : MonoBehaviour
{
	private GameObject player; //UFO
	
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Border")
		{
			Destroy(this.gameObject); //when asteroid comes in contact with border it is destroyed
		}
		
		else if(collision.tag == "Player")
		{
			Destroy(player.gameObject); //when asteroid comes in contact with player, player dies
		}
	}
}
