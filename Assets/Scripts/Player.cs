using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> players;

    private void Start()
    {
        players.GetRandom();
        transform.Scale(2);
    }

    //private void GetRandom()
    //{
    //    players[Random.Range(0, players.Count)].SetActive(true);
    //}
}
