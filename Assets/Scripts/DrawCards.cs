using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCards : MonoBehaviour
{
    public GameObject Card;
    public Sprite[] spriteArray;
    public GameObject MainPlayerArea;
    public GameObject DropZone;

    public List<int> cards = new List<int>();

    private static System.Random rng = new System.Random();  

    public static void Shuffle(List<int> list)  
    {  
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            int value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }  
    }

    public void Start()
    {
        for (int i = 1; i < 53; i++)
        {
            cards.Add(i);
        }
        Shuffle(cards);
    }

    public void OnClick()
    {
        for (int i = 0; i < 1; i++)
        {
            int cardid = cards[0];
            cards.RemoveAt(0);
            GameObject playerCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.GetComponent<Image>().sprite = spriteArray[cardid];
            playerCard.transform.SetParent(MainPlayerArea.transform, false);
        }
    }

    public void Update()
    {
    
    }
}
