using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform Player;

    public Vector3 offset;

	// Use this for initialization
	void Start () {
        this.transform.position = Player.position + offset;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        this.transform.position = Player.position + offset;
	}
}
