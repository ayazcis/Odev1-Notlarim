using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class engel : MonoBehaviour
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
			score.lives--;
			SceneManager.LoadScene(scn.name);
		}
	}
}
