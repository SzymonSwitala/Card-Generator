using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] CardDatabase cardDatabase;
    [SerializeField] UI_CardController ui_cardController;
    [SerializeField] EnemyController enemyController;
    [SerializeField] Card currentCard;
    [SerializeField] SavedCardsController savedCardsContrroller;
    private void Start()
    {
        GenerateRandomCard();
    }
    public void Generate()
    {
        GenerateRandomCard();

    }
    public void Save()
    {
        savedCardsContrroller.AddCard(currentCard);
        GenerateRandomCard(); 

    }
    public void Use()
    {
        if (currentCard==null)
        {
            return;
        }
        ui_cardController.PlayUseAnimation();
        enemyController.addHp(currentCard.effect.addHealPoint);
        enemyController.addMana(currentCard.effect.addMana);
        enemyController.addSpeed(currentCard.effect.addSpeed);
        GenerateRandomCard();
    }
    private void GenerateRandomCard()
    {
        
        int randomTitleIndex = Random.Range(0,cardDatabase.titles.Length);
        string randomTitle = cardDatabase.titles[randomTitleIndex];
    

        int randomDescriptionIndex = Random.Range(0, cardDatabase.descriptions.Length);
        string randomDescription = cardDatabase.descriptions[randomDescriptionIndex];
     

        int randomImageIndex = Random.Range(0,cardDatabase.images.Length);
        Sprite randomImage = cardDatabase.images[randomImageIndex];
  

        int randomCardEffectIndex = Random.Range(0, cardDatabase.cardEffect.Length);
        CardEffect randomCardEffect = cardDatabase.cardEffect[randomCardEffectIndex];
    
       Card newCard = new Card(randomTitle,randomDescription,randomImage,randomCardEffect);
        SetNewCurrentCard(newCard);
    }
    public void SetNewCurrentCard(Card newCard)
    {

        currentCard = newCard;
        ui_cardController.SetNewCard(
                newCard.title,
                newCard.description,
                newCard.image,
                newCard.effect);

    }
}
