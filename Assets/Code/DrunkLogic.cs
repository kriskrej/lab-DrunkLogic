using UnityEngine;
// Imię:
// Nazwisko:
// Nr indeksu:
public class DrunkLogic : MonoBehaviour {
    public DrunkUI ui;
    public Animator animator;

    public void Start() {
        ui.BarWidth = 100;
        ui.BarX = 500;
    }

    void Update() {

    }
}
