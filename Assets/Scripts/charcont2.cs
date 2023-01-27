using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcont2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    private Rigidbody2D rgd;
    private Animator anim;
    public float jumpforce = 150;
    private bool grounded=true;
    private bool jump;
    private bool moving;
    private float movdir;
    private SpriteRenderer spr;
	private void Awake()
	{
        anim = GetComponent<Animator>();
	}
	void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()

    {
        Debug.Log(grounded);
        rgd.velocity = new Vector2(speed * movdir, rgd.velocity.y);
		if (jump == true)
		{
            rgd.velocity = new Vector2(speed * movdir, jumpforce);
            jump = false;
        }
		if (grounded == true && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))){
            moving = true;
			if (Input.GetKey(KeyCode.A))
			{
                movdir = -1;
                spr.flipX = true;
                anim.SetFloat("speed", speed);
            }
			else
			{
                movdir = 1;
                spr.flipX = false;
                anim.SetFloat("speed", speed);
            }
		}else if (grounded == true)
		{
            movdir = 0.0f;
            anim.SetFloat("speed", 0.0f);
		}
        if(grounded==true && Input.GetKey(KeyCode.W))
		{
            jump = true;
            grounded = false;
            anim.SetTrigger("jump");
            anim.SetBool("grounded", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            anim.SetBool("grounded", true);
            grounded = true;
        }

    }

}
