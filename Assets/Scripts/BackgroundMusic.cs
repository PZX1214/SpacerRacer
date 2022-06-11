using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//music - we didn't use it
public class BackgroundMusic : MonoBehaviour
{
	private static BackgroundMusic backgroundMusic;

    void Awake()
	{
		if(backgroundMusic == null)
		{
			backgroundMusic = this;
			DontDestroyOnLoad(backgroundMusic);
		}
		
		else 
		{
			Destroy(gameObject);
		}
	}
}
