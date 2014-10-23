using UnityEngine;
using System.Collections;

public class LoadOnReturn : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            UnityEngine.Debug.Log("Enter Was Called");
            Application.LoadLevel("OpenCutScene");
        }
    }
}
	
	
