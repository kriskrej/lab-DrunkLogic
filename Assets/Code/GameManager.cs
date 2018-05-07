using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] Transform taichiPrefab;
    [SerializeField] Transform taichi;
    [SerializeField] SmoothFollow camera;
    [SerializeField] GameObject witcherUi;
    [SerializeField] EndGameUi endGameUi;
    [SerializeField] WitcherLogic witcherLogic;

    static GameManager instance;

    void Awake() {
        instance = this;
        endGameUi.respawnButton.onClick.AddListener(RestartGame);
        RestartGame();
    }

    void RestartGame() {
        Debug.Log("(Re)start!\n");
        witcherLogic.Start();
        instance.endGameUi.gameObject.SetActive(false);
        taichi = Instantiate(taichiPrefab);
        witcherLogic.animator = taichi.GetComponent<Animator>();
        camera.target = taichi;
        instance.witcherUi.gameObject.SetActive(true);
    }

    public static void ShowRespawnScreen(string text) {
        instance.endGameUi.gameObject.SetActive(true);
        instance.endGameUi.label.text = text;
        instance.witcherUi.gameObject.SetActive(false);
    }


}
