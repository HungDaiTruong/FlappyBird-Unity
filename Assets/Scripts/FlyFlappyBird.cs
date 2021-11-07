using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlyFlappyBird : MonoBehaviour
{

    public GameManager gameManager;
    public GameObject gameOverCanvas;
    public GameObject gamePauseCanvas;
    public float velocity = 1;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        // If LeftClick and Not over UI or If Spacebar is down, and if all is when pause is inactive, then activate jump
        if (((Input.GetMouseButtonDown(0) && (!EventSystem.current.IsPointerOverGameObject())) || Input.GetKeyDown(KeyCode.Space)) && (gamePauseCanvas.activeSelf == false))
        {
            //Jump
            rigidBody.velocity = Vector2.up * velocity;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && (gameOverCanvas.activeSelf == false))
        {
            gameManager.Pause();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}
