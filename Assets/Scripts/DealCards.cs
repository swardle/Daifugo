using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCards : MonoBehaviour
{
    public GameObject Card;
    public GameObject MainPlayerArea;
    public GameObject OtherPlayerArea;

    public void OnClick()
    {
        Debug.Log("I am here 3");
        for (int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(MainPlayerArea.transform, false);
        }
    }

    public void Update()
    {
        Debug.Log("I am here 2");

    }

    // Start is called before the first frame update
    void Start()
    {

    }

}
