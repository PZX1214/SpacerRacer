using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//keeps track of the score
public class ScoreManager : MonoBehaviour
{
	public Text scoreText;
	private float score = -1;
	
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
		{
			score += 1 * Time.deltaTime;
			scoreText.text = ((int)score).ToString() + " light years"; //returns the amount of light years traveled i.e. seconds surived
		}
    }
}
