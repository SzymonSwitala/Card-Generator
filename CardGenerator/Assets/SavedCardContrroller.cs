using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedCardContrroller : MonoBehaviour
{
    [SerializeField] List<Card> savedCards;
    [SerializeField] Transform content;
    public void AddCard(Card currentCard)
    {
        savedCards.Add(currentCard);
        UpdateInterface();
    }
    private void UpdateInterface()
    {
        for (int i = 0; i < savedCards.Count; i++)
        {
            Card newCard = savedCards[i];
            content.GetChild(0).GetComponent<UI_CardController>().SetNewCard(
                newCard.title,
                newCard.description,
                newCard.image,
                newCard.effect);


        }
    }
}
