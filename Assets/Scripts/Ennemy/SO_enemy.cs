using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy")]
public class SO_enemy : ScriptableObject
{
    public string enemyName;
    public int health;
    public int damage;
    public int experience;

    public GameObject enemyPrefab;
}
