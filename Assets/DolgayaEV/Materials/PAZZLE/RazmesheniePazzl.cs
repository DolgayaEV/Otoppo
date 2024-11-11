using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazmesheniePazzl : MonoBehaviour
{
    public GameObject[] puzzlePieces; // массив префабов частей пазла
    public Transform[] spawnPoints; // точки, где будут размещены части

    void Start()
    {
        ShuffleAndPlacePieces();
    }

    void ShuffleAndPlacePieces()
    {
        for (int i = 0; i < puzzlePieces.Length; i++)
        {
            int randomIndex = Random.Range(0, puzzlePieces.Length);
            Instantiate(puzzlePieces[randomIndex], spawnPoints[i].position, Quaternion.identity);
        }
    }
}

