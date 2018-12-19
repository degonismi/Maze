using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class TouchInputPanel : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{

    private Vector2 startPos;
    private Vector2 direction;



    public void OnPointerDown(PointerEventData eventData)
    {
        startPos = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position;
        Vector2 directioPos = currentPos - startPos;

        

        direction = directioPos;
    }


    
    public void OnPointerUp(PointerEventData eventData)
    {
        direction = Vector2.zero;
    }

    public Vector2 GetDirectionFromTouch()
    {

        
        return direction;
    }


    private void Awake()
    {
        direction = Vector2.zero;
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}