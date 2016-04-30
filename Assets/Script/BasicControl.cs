using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {

    public float MotorForce = 1;
    public Transform[] Motors;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    foreach (Transform motor in Motors)
        {
            float TotalForce = Mathf.Clamp(Input.GetAxis("Throttle"), 0, 1) * (MotorForce / 10);
            gameObject.GetComponent<Rigidbody>().AddForceAtPosition(transform.up * TotalForce, motor.position, ForceMode.Impulse);
        }
	}
}
