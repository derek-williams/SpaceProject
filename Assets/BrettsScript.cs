using UnityEngine;
using System.Collections;

public class BrettsScript : MonoBehaviour
{

    void Start()
    {
        AudioSource.PlayClipAtPoint(this.gameObject.transform.audio.clip, this.gameObject.transform.position);
        DontDestroyOnLoad(this.gameObject);
    }
}
