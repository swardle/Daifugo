using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card;
    public GameObject MainPlayerArea;
    public GameObject DropZone;

    public void OnClick()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(MainPlayerArea.transform, false);
        }
    }

    public void Update()
    {
    
    }

    // Start is called before the first frame update
    void Start()
    {

    }

}
