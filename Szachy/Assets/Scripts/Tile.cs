using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _basecolor, _offsetcolor;
    [SerializeField] public SpriteRenderer _renderer;
    [SerializeField] public GameObject _highlight;
    

    public void Init(bool isOffset) 
    {
        _renderer.color = isOffset ? _offsetcolor : _basecolor;
    }

    private void Start()
    {
        _highlight.SetActive(false);
    }
    void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }
    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
