using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedCardsController : MonoBehaviour
{
    [SerializeField] List<Card> savedCards;
    [SerializeField] Transform content;
    [SerializeField] GameObject cardPrefab;
    [SerializeField] GamePlayManager gamePlayManager;
    public void AddCard(Card currentCard)
    {
        savedCards.Add(currentCard);
        UpdateInterface();
    }
    public void AddToCurrentCard(Card card)
    {
       gamePlayManager.SetNewCurrentCard(card);
        savedCards.Remove(card);
    }
    private void UpdateInterface()
    {
        for (int i = 0; i < savedCards.Count; i++)
        {
            Card newCard = savedCards[i];
           
            if (content.childCount<savedCards.Count)
            {

                GameObject newCardPrefab=Instantiate(cardPrefab);
                newCardPrefab.transform.SetParent(content);
              
            }
            content.GetChild(i).gameObject.SetActive(true);

            content.GetChild(i).GetComponent<UI_CardController>().SetNewCard(
                newCard.title,
                newCard.description,
                newCard.image,
                newCard.effect);
            content.GetChild(i).GetComponent<SavedCard>().card = newCard;

        }

    }
  
}
