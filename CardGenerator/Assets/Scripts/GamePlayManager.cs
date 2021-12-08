using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] CardDatabase cardDatabase;
    [SerializeField] UI_CardController ui_cardController;
    [SerializeField] EnemyController enemyController;
    [SerializeField] Card currentCard;
    [SerializeField] SavedCardContrroller savedCardContrroller;
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
        savedCardContrroller.AddCard(currentCard);
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
        ui_cardController.SetTitle(randomTitle);

        int randomDescriptionIndex = Random.Range(0, cardDatabase.descriptions.Length);
        string randomDescription = cardDatabase.descriptions[randomDescriptionIndex];
        ui_cardController.SetDesctiption(randomDescription);

        int randomImageIndex = Random.Range(0,cardDatabase.images.Length);
        Sprite randomImage = cardDatabase.images[randomImageIndex];
        ui_cardController.SetImage(randomImage);

        int randomCardEffectIndex = Random.Range(0, cardDatabase.cardEffect.Length);
        CardEffect randomCardEffect = cardDatabase.cardEffect[randomCardEffectIndex];
        ui_cardController.SetEffectDescription(randomCardEffect);
        currentCard = new Card(randomTitle,randomDescription,randomImage,randomCardEffect);
    }
}
