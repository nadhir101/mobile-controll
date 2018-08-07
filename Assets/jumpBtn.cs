using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBtn : MonoBehaviour {

    public GameObject player;
    public float JumpForce;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            JumpMvt();
	}
    public void JumpMvt()
    {
        player.transform.Translate(new Vector3(2f, 2f, 0) * Time.deltaTime*JumpForce);
    }
}
