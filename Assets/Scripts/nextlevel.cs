using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
	private Scene scn;
	private void Awake()
	{
		scn = SceneManager.GetActiveScene();
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))

		{
			SceneManager.LoadScene(scn.buildIndex +1);
		}
	}
	public void startlevel()
	{
		SceneManager.LoadScene(scn.buildIndex + 1);
	}
	public void startagain()
	{
		SceneManager.LoadScene(0);
		score.lives = 3;
		score.totalscore = 0;
	}
}
