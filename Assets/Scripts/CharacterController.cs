using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rgd;
    private SpriteRenderer sprite;
    private Animator anim;
    private Vector3 charPos;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1.0f;
        rgd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        charPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetAxis("Horizontal")==0.0f)
		{
            anim.SetFloat("speed", 0.0f);
            Debug.Log("malmuro");
            Debug.Log(speed);
		}
		else
        {
			if (Input.GetAxis("Horizontal") >0.0f){
                sprite.flipX = false;
			}
			else
			{
                sprite.flipX = true;
			}
            Debug.Log("malayaz");
            anim.SetFloat("speed", 1.0f);
		}
        charPos = new Vector3(charPos.x + (speed * Input.GetAxis("Horizontal")*Time.deltaTime), charPos.y, charPos.z);
        transform.position = charPos;
    }
}
