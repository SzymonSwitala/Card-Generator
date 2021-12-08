using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card:MonoBehaviour
{
    public string title;
    public string description;
    public Sprite image;
   public CardEffect effect;
    public void CreateCard(string newTitle, string newDescription, Sprite newImage, CardEffect newCardEffect)
    {
        title = newTitle;
        description = newDescription;
        image = newImage;
        effect = newCardEffect;
    }
}
