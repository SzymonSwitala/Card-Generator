using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedCard : MonoBehaviour
{
    public Card card;
    public void AddToCurrentCard()
    {

        SavedCardsController savedCardsController=GameObject.FindGameObjectWithTag("SavedCardController").GetComponent<SavedCardsController>();
             savedCardsController.AddToCurrentCard(card);
        gameObject.SetActive(false);
    }
}
