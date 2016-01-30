using UnityEngine;
using System.Collections;

public class SlowScale : MonoBehaviour {

    public float minscale;
    public float maxScale;

    public float scaleAmountPerFrame;

    public enum Direction { Up, Down };

    public Direction direction;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        switch (direction) {
            case Direction.Up:
                this.transform.localScale = new Vector3(
                    Mathf.Clamp(this.transform.localScale.x + scaleAmountPerFrame, minscale, maxScale),
                    Mathf.Clamp(this.transform.localScale.y + scaleAmountPerFrame, minscale, maxScale),
                    Mathf.Clamp(this.transform.localScale.z + scaleAmountPerFrame, minscale, maxScale)
                );
                break;
            case Direction.Down:
                this.transform.localScale = new Vector3(
                    Mathf.Clamp(this.transform.localScale.x - scaleAmountPerFrame, minscale, maxScale),
                    Mathf.Clamp(this.transform.localScale.y - scaleAmountPerFrame, minscale, maxScale),
                    Mathf.Clamp(this.transform.localScale.z - scaleAmountPerFrame, minscale, maxScale)
                );
                break;
        }
    }
}
