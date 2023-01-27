using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class livescontrol : MonoBehaviour
{

	private void Awake()
	{
		switch (score.lives)
		{
			case 3:
				break;
			case 2:
				gameObject.transform.GetChild(2).gameObject.SetActive(false);
				break;
			case 1:
				gameObject.transform.GetChild(1).gameObject.SetActive(false);
				gameObject.transform.GetChild(2).gameObject.SetActive(false);
				break;
			case 0:
				SceneManager.LoadScene(4);
				score.lives = 3;
				break;
			default:
				break;


		}
	}
}
