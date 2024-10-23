using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carddisplay : MonoBehaviour
{
    public Text nameText;

    public Image backgroundimage; //¿¨Í¼
    public Image image; //¿¨ÅÆ±ß¿ò

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text=card.cardName;
        if(card is Charactercard) 
        {
            var character = card as Charactercard;
        }
    }
}
