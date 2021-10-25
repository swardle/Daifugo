using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject DropZone;

    public GameObject dropZone;
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private GameObject startPartent;
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
        DropZone = GameObject.Find("DropZone");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void BeginDrag()
    {
        isDragging = true;
        startPartent = transform.parent.gameObject;
        startPosition = transform.position;
    }

    public void EndDrag()
    {
        isDragging = false;
        if(isOverDropZone) 
        {
                transform.SetParent(dropZone.transform, false);
        }
        else
        {
                transform.position = startPosition;
                transform.SetParent(startPartent.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

}
