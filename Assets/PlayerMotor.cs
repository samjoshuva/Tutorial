using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    public float Speed = 7f;
	
	// Update is called once per frame
	void Update () {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        Vector3 Displacement = input * Speed * Time.deltaTime;


        transform.Translate(Displacement);
	}
}
