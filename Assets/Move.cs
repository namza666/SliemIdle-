using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public Rigidbody2D rb;
    public Transform rotation;
    public float speed;
    GameObject platfrom;
    bool IsGround;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)&&IsGround==true)
        {
            rb.AddForce(new Vector2(0, 10),ForceMode2D.Impulse);
            IsGround = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-0.28f, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(0.28f, 0), ForceMode2D.Impulse);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platfrom")
        {
            IsGround = true;
            Debug.Log("On");
        }
    }
}
