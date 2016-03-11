using UnityEngine;
using System.Collections;

public class ContinueButton : MonoBehaviour {

   public void Continue()
    {
        Application.LoadLevel(1); //Change number in () to the scene needed
    }

}
