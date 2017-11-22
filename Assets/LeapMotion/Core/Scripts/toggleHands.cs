using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleHands : MonoBehaviour {

	public GameObject HandController1;
	public GameObject HandController2;
	HandPool _handpool1;
	HandPool _handpool2;
	int active = 1;



	// Use this for initialization
	void Start () {
		_handpool1 = HandController1.GetComponent<HandPool>();
		_handpool2 = HandController2.GetComponent<HandPool>();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S) && active == 1)
        {   
			//Camera.transform.position = new Vector3 (-0.037f, 0.936f, -0.947f);
			_handpool2.EnableGroup ("HandCapsules2");
			_handpool2.EnableGroup ("HandRidgids2");
			_handpool1.DisableGroup("HandCapsules1");
			_handpool1.DisableGroup("HandRidgids1");
			print("Dissabled Handgroup 1, Enabled Handgroup 2");
			active = 2;
		}
		else if (Input.GetKeyDown(KeyCode.S) && active == 2)
        {
			_handpool1.EnableGroup("HandCapsules1");
			_handpool1.EnableGroup("HandRidgids1");
			_handpool2.DisableGroup("HandCapsules2");
			_handpool2.DisableGroup("HandRidgids2");
			print("Dissabled Handgroup 2, Enabled Handgroup 1");
			active = 1;

        }
    }
}
