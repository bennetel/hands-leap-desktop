using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleHands : MonoBehaviour {

	public GameObject Camera;
    HandPool _handpool;

	// Use this for initialization
	void Start () {
        _handpool = this.GetComponent<HandPool>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {   
            _handpool.DisableGroup("HandCapsules1");
            _handpool.DisableGroup("HandRidgids1");
			//Camera.transform.position = new Vector3 (-0.037f, 0.936f, -0.947f);


        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            _handpool.EnableGroup("HandCapsules1");
            _handpool.EnableGroup("HandRidgids1");
			//Camera.transform.position = new Vector3 (2.4f, 0.936f, -0.947f);

        }
    }
}
