using UnityEngine;
using System.Collections;

public class BallTextScript : MonoBehaviour {

    public int BallRicxvi = 0;
    void Start () {
        gameObject.GetComponent<TextMesh>().text = BallRicxvi.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
