using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "CardDatabase", menuName = "Databases/CardDatabase", order = 1)]
public class CardDatabase : ScriptableObject
{
    
    public string[] titles;
    public string[] descriptions;
    public Sprite[] images;
    public CardEffect[] cardEffect;
}
