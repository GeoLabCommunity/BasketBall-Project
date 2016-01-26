using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameContoller : MonoBehaviour {

    public GameObject BasketText;
    public List<GameObject> Balls;
    public List<GameObject> BallTexts;
    List<int> GeneratedNumbers = new List<int>();
    public GameObject CenterPos;
    public static bool isActive;

    float timer = 1;
    int Jami = 0;
    void Start () {
        isActive = false;
        Jami = Random.Range(2, 11);
        int meore =Random.Range(0, Jami);
        int pirveli = Jami - meore;
        BasketText.GetComponent<TextMesh>().text = pirveli.ToString() + "+" + meore + "=";
        
        int RandomBallNum = Random.Range(0, 5);

        for (int i = 0; i < 11; i++)
        {
            if (i != Jami)
                GeneratedNumbers.Add(i);
        }

        GeneratedNumbers.Shuffle();
        // burts vanijebt jams (anu scor pasuxs)
        Balls[RandomBallNum].GetComponent<ballScrpt>().BallRicxvi = Jami;
        Balls[RandomBallNum].GetComponent<ballScrpt>().IsCorrect = true;
        Balls[RandomBallNum].GetComponent<ballScrpt>().CenterPos = CenterPos;
        BallTexts[RandomBallNum].GetComponent<TextMesh>().text = Jami.ToString();

        // arascori burti barametrebi
        for (int i = 0; i < BallTexts.Count; i++)
        {
            if (i != RandomBallNum)
            {
                BallTexts[i].GetComponent<TextMesh>().text = GeneratedNumbers[i].ToString();
                Balls[i].GetComponent<ballScrpt>().BallRicxvi = GeneratedNumbers[i];
                Balls[i].GetComponent<ballScrpt>().CenterPos = CenterPos;

            }

        }
    }

}


static class MyExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}