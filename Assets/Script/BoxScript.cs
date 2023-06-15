using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxScript : MonoBehaviour
{
    private float min_X = -2.1f, max_X = 2.1f;

    private bool canMove;
    private float move_Speed = 2f;

    private Rigidbody2D myBody;

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    public Text hudText;



    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
    }

    void Start()
    {
        canMove = true;

        if(Random.Range(0, 2) > 0)
        {
            move_Speed *= -1f;
        }

        GameplayController.instance.currentBox = this;

    }

 
    void Update()
    {
        MoveBox();
    }

    void MoveBox()
    {
        if (canMove)
        {
            Vector3 temp = transform.position;

            temp.x += move_Speed * Time.deltaTime;

            if (temp.x > max_X)
            {
                move_Speed *= -1f;
            }
            else if (temp.x < min_X)
            {
                move_Speed *= -1f;
            }

            transform.position = temp;
        }
    }

        public void DropBox()
        {
            canMove = false;
            myBody.gravityScale = Random.Range(2, 4);
        }

        void Landed()
        {
            if (gameOver)
                return;

            ignoreCollision = true;
            ignoreTrigger = true;
             
            GameplayController.instance.SpawnNewBox();
            GameplayController.instance.MoveCamera();
        }
        
        void RestartGame()
        {
            GameplayController.instance.RestartGame();
        }

        void OnCollisionEnter2D(Collision2D target)
        {

            if (ignoreCollision)
                return;

            if(target.gameObject.tag == "Plataform")
            {
            Debug.Log("Chao");
                Invoke("Landed", 0.5f);
                ignoreCollision = true;
            }

            if (target.gameObject.tag == "Box")
            {
                Invoke("Landed", 0.5f);
                ignoreCollision = true;
            }

        if (target.gameObject.tag == "GameOver")
        {
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger = true;

            SceneManager.LoadScene("end");
        }





    }

        void OnTriggerEnter2D(Collider2D target)
        {

            if (ignoreTrigger)
                return;

            if(target.tag == "GameOver")
            {
                CancelInvoke("Landed");
                gameOver = true;
                ignoreTrigger = true;

            SceneManager.LoadScene("end");
        }

        if (target.tag == "victory")
        {
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger = true;

            SceneManager.LoadScene("victory");
        }

    }







    }

