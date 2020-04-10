using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {

    public float spinSpeed = 180.0f, motionMagnitude = 0.1f;
    public bool doSpin = true, doMotion = false;

	// Update is called once per frame
	void Update () {
        //rotate around the up(0,1,0) axis of the game object
        if(doSpin) gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);

        //move up and down overtime
        if(doMotion) gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);

	}
}
