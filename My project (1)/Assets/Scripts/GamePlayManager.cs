using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] CardDatabase cardDatabase;
    [SerializeField] UI_CardController ui_cardController;
    [SerializeField] EnemyController enemyController;
    [SerializeField] Card currentCard;
    public void Generate()
    {
        GenerateRandomCard();
    }
    public void Save()
    {

    }
    public void Use()
    {
        enemyController.addHp(currentCard.effect.addHealPoint);
        enemyController.addMana(currentCard.effect.addMana);
        enemyController.addSpeed(currentCard.effect.addSpeed);
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
