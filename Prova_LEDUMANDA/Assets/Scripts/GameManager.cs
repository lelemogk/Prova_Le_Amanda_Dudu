using Photon.Pun;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourPunCallbacks
{
    #region Singleton

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    #endregion
    int score;
    /*const string playerPrefabPath = "Prefabs/Player";

    int playersInGame;
    List<PlayerControler> playerList = new List<PlayerControler>();
    PlayerControler playerLocal;

    private void Start()
    {
        photonView.RPC("AddPlayer", RpcTarget.AllBuffered);
    }

    private void CreatePlayer()
    {
        PlayerControler player = NetworkManager.instance.Instantiate(playerPrefabPath, new Vector3(30, 1, 30), Quaternion.identity).GetComponent<PlayerControler>();
       // player.photonView.RPC("Initialize", RpcTarget.All);
    }

    [PunRPC]
    private void AddPlayer()
    {
        playersInGame++;
        if (playersInGame == PhotonNetwork.PlayerList.Length)
        {
            CreatePlayer();
        }
    }*/



}