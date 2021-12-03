using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "CardDatabase", menuName = "Databases/CardDatabase", order = 1)]
public class CardDatabase : ScriptableObject
{
    
    [SerializeField] string[] titles;
    [SerializeField] string[] descriptions;
    [SerializeField] Image[] images;
}
