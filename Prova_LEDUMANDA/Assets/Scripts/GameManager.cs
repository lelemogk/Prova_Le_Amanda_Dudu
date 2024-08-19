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
    [SerializeField] public int score;

    private void UpdateScore(int score)
    {
        UIManager.instance.UpdateTextScore(score);
    }

    const string playerPrefabPath = "Prefabs/Player";

    int playersInGame;
    List<PlayerControler> playerList = new List<PlayerControler>();
    PlayerControler playerLocal;

    private void Start()
    {
        photonView.RPC("AddPlayer", RpcTarget.AllBuffered);
    }

    private void CreatePlayer()
    {
        PlayerControler player = NetworkManager.instance.Instantiate(playerPrefabPath, transform.position, Quaternion.identity).GetComponent<PlayerControler>();
        player.photonView.RPC("Initialize", RpcTarget.All);
    }

    [PunRPC]
    private void AddPlayer()
    {
        playersInGame++;
        if (playersInGame == PhotonNetwork.PlayerList.Length)
        {
            CreatePlayer();
        }
    }


}