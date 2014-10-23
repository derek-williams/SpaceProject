using UnityEngine;
using System.Collections;

public class BGTween : MonoBehaviour {
    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 5.0f;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }

	// Update is called once per frame
	void Update () {
       GameObject startween = this.gameObject;
       float t = (Time.time - startTime) / duration;
       SpriteRenderer startAnim = startween.GetComponent<SpriteRenderer>();
       startAnim.color = new Color(1f, 1f, 1f, Mathf.PingPong(Time.time, (Mathf.SmoothStep(minimum, maximum, t))));

	}
}
