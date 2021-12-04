using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    [SerializeField] CardDatabase cardDatabase;
    [SerializeField] CardController cardController;
    public void Generate()
    {
        GenerateRandomCard();
    }
    public void Save()
    {

    }
    public void Use()
    {

    }
    private void GenerateRandomCard()
    {
        int randomTitleIndex = Random.Range(0,cardDatabase.titles.Length);
        cardController.SetTitle(cardDatabase.titles[randomTitleIndex]);
        int randomDescriptionIndex = Random.Range(0, cardDatabase.descriptions.Length);
        cardController.SetDesctiption(cardDatabase.descriptions[randomDescriptionIndex]);
        int randomImageIndex = Random.Range(0,cardDatabase.images.Length);
        cardController.SetImage(cardDatabase.images[randomImageIndex]);
    }
}
