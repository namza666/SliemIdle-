using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveAI : MonoBehaviour {
    public Rigidbody2D rb;
    float speed=0.20f;
    float delay=5;
    float time;
    public Text money;
    Mouse FromMouse;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        
        
        
        if (time > delay)
        {
            speed *= -1;
            time = 0;
            GetMoney();
            
            
        }
        rb.AddForce(new Vector2(speed, 0), ForceMode2D.Impulse);
        
    }
    void GetMoney()
    {
        FromMouse.cout += 1;
    }
}
