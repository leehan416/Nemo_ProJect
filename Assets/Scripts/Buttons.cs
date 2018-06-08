using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    public GameObject Menu;
    public GameObject ingame_Menu;
    public GameObject Ingame_Menu;
    public void OnClick_Ingame() {
        SceneManager.LoadScene("Main");
    }

    public void OnClick_Start() {
        SceneManager.LoadScene("StartScene");
    }

    public void OnClick_Maker() {
        SceneManager.LoadScene("MakerScene");

    }
    public void OnClick_Menu() {
        Instantiate(Menu);
        Destroy(ingame_Menu);
        Time.timeScale = 0;
    }
    public void OnClick_Back_to_game() {
        Destroy(Menu);
        Time.timeScale = 1;
        Instantiate(Ingame_Menu);
    }
    
}
