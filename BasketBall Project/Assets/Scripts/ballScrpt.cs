using UnityEngine;
using System.Collections;

public class ballScrpt : MonoBehaviour {

    Vector3 objectPos;
    Vector3 BasketPos;
    public int BallRicxvi=0;
    float KickForce = 10;
    public GameObject CenterPos;
    bool GoCenter = false;
    [HideInInspector]public bool IsCorrect = false;
    void Start () {

       BasketPos = new Vector3(0, 0, 0);
       objectPos = gameObject.transform.position;


    }

    void OnMouseDown()
    {
        if(!GameContoller.isActive)
        {
            GameContoller.isActive = true;
            GoCenter = true;
        }
    }
	
	void Update () {
        //gameObject.transform.position = Vector3.Lerp(objectPos, BasketPos, 0.01f);
        //transform.position = Vector3.MoveTowards(objectPos, BasketPos, step);
        if (GoCenter)
        {
          
            float step = 5 * Time.deltaTime;
            gameObject.transform.position = Vector3.MoveTowards(transform.position, CenterPos.transform.position, step);
        }
        if (GameContoller.isActive == true && gameObject.transform.position == CenterPos.transform.position)
        {
            GoCenter = false;
            GameContoller.isActive = false;
        }

    }
}
