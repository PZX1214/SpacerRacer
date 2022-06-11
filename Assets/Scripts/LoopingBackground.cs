using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//makes the background infinitely loop making it seem like it is moving
public class LoopingBackground : MonoBehaviour
{
	public float backgroundSpeed;
	public Renderer backgroundRenderer;
	
    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
