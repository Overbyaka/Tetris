using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnTetromino : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    public int player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Это " + MenuManager.player);
        NewTetromino();
    }

    public void NewTetromino()
    {
        if (player == MenuManager.player)
        {
            PhotonNetwork.Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)].name, transform.position, Quaternion.identity);
        }
    }
}
