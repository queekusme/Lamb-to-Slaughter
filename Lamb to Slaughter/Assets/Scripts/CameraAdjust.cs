using UnityEngine;
using System.Collections;

public class CameraAdjust : MonoBehaviour {

    public GameObject sheep;
    public GameObject shepherd;

    public float cameraOffset;

    public float minDistance;
    public float maxDistance;

    private Camera cam;

    void Start() {
        cam = GetComponent<Camera>();
    }

	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(getMiddlePoint(sheep, shepherd).x, getMiddlePoint(sheep, shepherd).y, cameraOffset);
        cam.orthographicSize = Mathf.Clamp(getDistance(sheep, shepherd)/2,minDistance,maxDistance); ;
    }

    Vector2 getMiddlePoint(GameObject go1, GameObject go2) {
        float x = ((go2.transform.position.x - go1.transform.position.x) / 2) + go1.transform.position.x;
        float y = ((go2.transform.position.y - go1.transform.position.y) / 2) + go1.transform.position.y;

        return new Vector2(x,y);
    }

    float getDistance(GameObject go1, GameObject go2) {
        float x = go2.transform.position.x - go1.transform.position.x;
        float y = go2.transform.position.x - go1.transform.position.x;

        return Mathf.Sqrt((x * x) + (y * y));
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(getMiddlePoint(sheep, shepherd), 0.1f);
    }

}
