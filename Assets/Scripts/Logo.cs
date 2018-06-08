using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logo : MonoBehaviour {

    public Image whiteScreen;
    public Sprite Smcl;
    void Start() {

        whiteScreen.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        StartCoroutine(A(4f));

    }

    IEnumerator A(float time) {
        yield return new WaitForSeconds(time);
        FadeOut();
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("StartScene");
    }
    public void FadeIn() {
        whiteScreen.CrossFadeAlpha(1.0f, 3.0f, false);
    }

    public void FadeOut() {
        whiteScreen.CrossFadeAlpha(0.0f, 3.0f, false);
        
    }
}
