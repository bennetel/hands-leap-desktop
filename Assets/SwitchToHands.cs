using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToHands : MonoBehaviour {
    Camera _camera;
    GameObject fpc;
    private Vector3 kitchenView = new Vector3(97.5f, -1f, -24.5f);
    // Use this for initialization
    void Start () {
        
}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.M))
        {
            _camera.transform.position = kitchenView;
            print("Test");        }
	}
}
