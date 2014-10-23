using UnityEngine;
using System.Collections;

public class UIDestroy : MonoBehaviour {

    public GameObject Funktronic;
    public GameObject levelLoader;

	// Use this for initialization
    void OnClick()
    {
        Destroy(Funktronic);
        Destroy(this.gameObject);
        levelLoader.SetActive(true);
    }
}
