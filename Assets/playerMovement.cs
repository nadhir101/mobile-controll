using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour {

    public Transform player;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public GameObject circle;
    public GameObject outerCircle;
    public GameObject cursorMove;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
                pointA = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                circle.transform.position = pointA;
                outerCircle.transform.position = pointA;
                circle.SetActive(true);
                outerCircle.SetActive(true);
            
        }
        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else
        {
            touchStart = false;
        }
        if (touchStart && pointA.x > cursorMove.transform.position.x*2 && pointA.x<0 && pointA.y > cursorMove.transform.position.y*2 &&pointA.y<0) 

        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);

            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y);
        }
        else
        {
            circle.SetActive(false);
            outerCircle.SetActive(false);
        }

    }
   
    void moveCharacter(Vector2 direction)
    {
     //   player.Translate( direction * Time.deltaTime);
        player.Translate(new Vector3( direction.x,0,0) * Time.deltaTime);
    }
}
