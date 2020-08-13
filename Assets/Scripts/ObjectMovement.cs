using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    #region Variables
    public Sprite[] hewan;

    float moveSpeed = 3f;

    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstPosY;
    #endregion

    #region Builtin Methods
    void Start()
    {
        int index = Random.Range(0, hewan.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = hewan[index];
    }
    
    void Update()
    {
        float move = (moveSpeed * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector3(move, transform.position.y);
    }
    
    private void OnMouseDown() 
    {
        firstPosY = transform.position.y;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3
        (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPos = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPos;
    }

    private void OnMouseUp() 
    {
        transform.position = new Vector3(transform.position.x, firstPosY, transform.position.z);
    }
    #endregion
}
