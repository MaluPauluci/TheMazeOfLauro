using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Porta"))
        {
            SceneManager.LoadScene("Jogo");
        }
        if(collision.gameObject.CompareTag("Porta venceu"))
        {
            SceneManager.LoadScene("Ganhou");
        }
    }
}
