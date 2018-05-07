using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherLogic : MonoBehaviour {
    public WitcherVisualisation ui;
    public Animator animator;

    void Start() {
        ui.BarX = 500;
    }

    float speed = 100;

    void Update() {
        ui.PointX = ui.MouseX;
        if (IsMouseOverBar()) {
            ui.BarX+=Time.deltaTime * speed;
        }
        else {
            ui.BarX-= Time.deltaTime * speed;
        }
        ui.BarWidth = (1000-ui.BarX)/8;
        animator.SetFloat("Drunk", 1f-ui.BarX/1000f);
        
    }

    bool IsMouseOverBar() {
        return Mathf.Abs(ui.BarX - ui.MouseX) < ui.BarWidth / 2;
    }


    float life = 0.5f;
	public float GetKnobPositionInNextFrame(float currentPosition01, float mousePosition01) {
        return (currentPosition01+mousePosition01)/2;
    }
}
