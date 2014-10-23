using UnityEngine;
using System.Collections;

public class DisableScreen : MonoBehaviour {

    public GameObject Title;
    public GameObject Cred;
    public GameObject Back;
    public GameObject Derek;
    public GameObject Katie;
    public GameObject Brett;

	// Use this for initialization
	void OnClick () {
        if (Title.activeSelf == true)
        {
            Title.SetActive(false);
            Cred.SetActive(false);
            Back.SetActive(true);
            Derek.SetActive(true);
            Katie.SetActive(true);
            Brett.SetActive(true);
        }

        else 
        { 
            Title.SetActive(true);
            Cred.SetActive(true);
            Back.SetActive(false);
            Derek.SetActive(false);
            Katie.SetActive(false);
            Brett.SetActive(false);
        }
        
	}

}
