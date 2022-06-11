using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//gives the player object its attributes
public class Player : MonoBehaviour
{
	public float playerSpeed;
	private Rigidbody2D rb;
	private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //initializes rigid body in player
    }

    // Update is called once per frame
    void Update() //translate key input into movement
    {
        float directionY = Input.GetAxisRaw("Vertical");
		float directionX = Input.GetAxisRaw("Horizontal");
		playerDirection = new Vector2(directionX, directionY).normalized;
		
    }
	
	void FixedUpdate() //how fast the player moves
	{
		rb.velocity = new Vector2(playerDirection.x * playerSpeed, playerDirection.y * playerSpeed);
	}
}
