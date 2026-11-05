using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public static GameManager instance;
    private void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        } else{
            Destroy(gameObject);
        }
    }

    public void SwitchLevel(){
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene((currentScene.buildIndex -1) + 1);
    }

    public void CharacterDeath(){
        
    }
}
