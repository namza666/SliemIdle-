using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mouse : MonoBehaviour {
    public Text money;
    public int cout;
    public GameObject Cube;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        money.text = "Money : " + cout;

    if (Input.GetMouseButtonDown(0))
    { 
        Debug.Log("Pressed primary button.");
        GetMoney();
        
    }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (cout >= 50)
            {
                cout -= 50;
                Instantiate(Cube, new Vector2(0, 0), Quaternion.identity);
            }
            

        }
       

    }

    void GetMoney()
    {
        cout += 1;
    }
}
