using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PLayerpoints : MonoBehaviour
{
	private AudioSource aud;
	[SerializeField] private TextMeshProUGUI text;
	private void Awake()
	{
		text.text = score.totalscore.ToString();
		aud = GetComponent<AudioSource>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("diamond"))
		{
			aud.Play();
			Destroy(collision.gameObject);
			score.totalscore++;
			text.text = score.totalscore.ToString();
		}
	}
}
