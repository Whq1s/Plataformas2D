using UnityEngine;

public class NextLevel : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.tag == "Player"){
            GameManager.instance.SwitchLevel();
        }
    }
}
