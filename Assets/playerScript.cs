using UnityEngine;

public class playerScript : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Score.UpdateScore(10);
            Destroy(other.gameObject);
        }
    }

}
