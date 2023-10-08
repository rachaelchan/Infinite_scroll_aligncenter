using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ScrollItem : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler
{
    
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private CanvasGroup canvasGroup;

    public int itemIndex;
    public int infoIndex;
    public string descritption;

    private infiniteScroll infiniteScroll;
    [HideInInspector] public RectTransform rectTransform;

    private bool isDrag;

    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetInfo(Sprite _sprite, string _name, string _description,int _infoIndex, infiniteScroll _infinitedScroll)
    {
        image.sprite = _sprite;
        nameText.text = _name;
        this.descritption = _description;
        this.infoIndex = _infoIndex;
        this.infiniteScroll = _infinitedScroll;
    }

    public void SetAlpha(float alpha)
    {
        canvasGroup.alpha = alpha;
    }

   
    public void OnPointerDown(PointerEventData eventData)
    {
        isDrag = false;
        infiniteScroll.OnPointerDown(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if(!isDrag)
        {
            infiniteScroll.Select(itemIndex, infoIndex, rectTransform);
        }
        infiniteScroll.OnPointerUp(eventData);
    }

     public void OnDrag(PointerEventData eventData)
    {
        isDrag = true;
        infiniteScroll.OnDrag(eventData);
    }


}
