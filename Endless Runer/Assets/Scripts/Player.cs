using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Text healthDisplay;
    public GameObject gameOver;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    private Vector3 targetPos = new Vector3(0f,0f,-0.03f);
    public float Xincrement;


    public float speed;
    public float maxWidth;
    public float minWidth;

    public int health = 3;
    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();
        if(health <= 0 || transform.position.y<-5.5f)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxWidth)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector3(transform.position.x + Xincrement, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minWidth)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector3(transform.position.x - Xincrement, transform.position.y, transform.position.z);
        }
        //movement = new Vector2(Input.GetAxis("Horizontal"), transform.position.y);

    }
    /*private void FixedUpdate()
    {
        move(movement);
    }

    void move(Vector2 direction)
    {
        rb.AddForce(direction * speed);
    }*/
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            Debug.Log("yes");
            //transform.Translate(other.transform.position * other.gameObject.GetComponent<Block>().speed * Time.deltaTime, Space.Self);
            //transform.position = other.transform.position;
        }
    }

}
