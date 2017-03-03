using UnityEngine;
using System.Collections;

public class BasicMover : MonoBehaviour {


    public float spinSpeed = 140.0f;
    public float motionMagnitude = 0.1f;
    public bool rotate=true;
    public bool move=true;
    
	
	// Update is called once per frame
	void Update ()
    {
        if (rotate)
        {
            //for rotation
            
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
	   //for moving
        if (move)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
	}
}
