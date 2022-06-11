using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//allows user to see reset button
public class GameOver : MonoBehaviour
{	
	public GameObject gameOverPanel;
    
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null) 
		{
			gameOverPanel.SetActive(true);
		}
    }
	
	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
