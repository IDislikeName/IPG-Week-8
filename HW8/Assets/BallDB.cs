using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BallDB", menuName = "ScriptableObjects/BallDataBase", order = 1)]
public class BallDB : ScriptableObject
{
    public GameObject[] ballList;
}
