using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTS.Units
{
    [CreateAssetMenu(fileName = "New Unit", menuName = "Create New Unit/Basic")]

    public class BasicUnit : ScriptableObject
    {
        public enum unitType
        {
            Knight,
            Archer,
            Healer,
        }

        public enum unitTeam
        {
            Team1,
            Team2,
            Team3,
            Team4,
        }

        public unitType type;
        public unitTeam team;
        public string unitName;
        public GameObject team1Prefab;
        public GameObject team2Prefab;
        public GameObject team3Prefab;
        public GameObject team4Prefab;

        //stats
        public int cost;
        public int attack;
        public int health;
        public int armor;

    }
}


