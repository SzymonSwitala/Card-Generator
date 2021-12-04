using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "CardEffect", menuName = "CardEffects", order = 1)]
public class CardEffect : ScriptableObject
{
    public int addHealPoint;
    public int addMana;
    public int addSpeed;
}
