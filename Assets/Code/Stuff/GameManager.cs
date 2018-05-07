using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] Transform taichiPrefab;
    [SerializeField] Transform taichi;
    [SerializeField] SmoothFollow camera;
    [SerializeField] GameObject witcherUi;
    [SerializeField] EndGameUi endGameUi;
    [SerializeField] DrunkLogic drunkLogic;

    static GameManager instance;

    void Awake() {
        instance = this;
        endGameUi.respawnButton.onClick.AddListener(RestartGame);
        RestartGame();
    }

    void RestartGame() {
        Debug.Log("(Re)start!\n");
        drunkLogic.Start();
        instance.endGameUi.gameObject.SetActive(false);
        taichi = Instantiate(taichiPrefab);
        drunkLogic.animator = taichi.GetComponent<Animator>();
        camera.target = taichi;
        instance.witcherUi.gameObject.SetActive(true);
    }

    public static void ShowRespawnScreen(string text) {
        instance.endGameUi.gameObject.SetActive(true);
        instance.endGameUi.label.text = text;
        instance.witcherUi.gameObject.SetActive(false);
        instance.StartCoroutine(LightsOff(instance.taichi.GetComponentInChildren<Light>()));
    }

    static IEnumerator LightsOff(Light light) {
        while (light.intensity>0) {
            light.intensity -= Time.deltaTime * 0.3f;
            yield return new WaitForEndOfFrame();
        }
        light.enabled = false;
    }
}
