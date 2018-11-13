using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {
	public float shaketime;
	public float shakeamount;
	private Vector3 posori;
	// Use this for initialization
	void Start () {
        posori = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

    }

    // Update is called once per frame
    void Update () {
        
        if (shaketime >= 0) {
			Vector2 shakepos = Random.insideUnitCircle * shakeamount;
			this.transform.position = new Vector3 (transform.position.x + shakepos.x, transform.position.y + shakepos.y, transform.position.z);
			shaketime -= Time.deltaTime;

		} else {
			this.transform.position = posori;
		}
		
	}
	public void shakecamera( float shakepower, float shakedur)
	{
		shakeamount = shakepower;
		shaketime = shakedur;
	}
}
