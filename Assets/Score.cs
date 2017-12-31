using UnityEngine;

public class Score : MonoBehaviour {

    

    public static int CurrentScore;

    [SerializeField]
    private int score;
 	// Use this for initialization
	void Start () {
        
        CurrentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        score = CurrentScore;
    }

    public static void UpdateScore(int _amt)
    {
        CurrentScore += _amt;

    }
}
