using UnityEngine;
using System.Collections;

public class Flickering : MonoBehaviour {

    public Light light;


	void Update ()
    {
<<<<<<< HEAD
	    if (Random.value > 0.7) // Says if randomly generated number is greater than 0.8,
=======
	    if (Random.value > 0.9) // Says if randomly generated number is greater than 0.8,
>>>>>>> origin/master
        {

            if (light.enabled == true) // if light is enabled,
            {
                light.enabled = false; // then it's disabled now,
            }
            else
            {
                light.enabled = true; // if anything else then light is re-enabled.
            }
        }
	}
}
