using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon")]
public class SO_Weapon : ScriptableObject
{
    public string weaponName;
    public int damage;
    

    public GameObject weaponPrefab;
}
