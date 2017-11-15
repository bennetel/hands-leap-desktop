using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleHands : MonoBehaviour {

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

        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            _handpool.EnableGroup("HandCapsules1");
            _handpool.EnableGroup("HandRidgids1");

        }
    }
}
