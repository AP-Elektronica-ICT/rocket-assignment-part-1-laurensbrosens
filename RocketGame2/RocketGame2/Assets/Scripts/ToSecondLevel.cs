using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSecondLevel : MonoBehaviour
{
	private Scene scene;
	void Start()
	{
        scene = SceneManager.GetActiveScene();
	}

	void OnCollisionEnter(Collision collision)
	{
		if (scene.name == "LevelOne")
		{
			SceneManager.LoadScene("LevelTwo");
		}
        else
        {
			//You won
        }
	}
}
