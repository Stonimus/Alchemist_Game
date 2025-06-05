using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _pickUpClip, _dropClip;

    private bool _dragging,_placed;

    private Vector2 _offset,_originalPosition;

    [SerializeField] private PuzzleSlot _slot;

    public void Init(PuzzleSlot slot)
    {
        _slot = slot;
    }

    void Awake()
    {
        _originalPosition = transform.position;
    }

    void Update()
    {
        if (_placed) return;
        if (!_dragging) return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - _offset;
    }

    void OnMouseDown()
    {
       // _dragging = true;
       // _source.PlayOneShot(_pickUpClip);
       //
       // _offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
       // if (Vector2.Distance(transform.position, _slot.transform.position) < 2)
       // {
       //     transform.position = _slot.transform.position;
       //     _slot.Placed();
       //     _placed = true;
       // }
       // else
       // {
       //     transform.position = _originalPosition;
       //     _source.PlayOneShot(_dropClip);
       //     _dragging = false;
       // }

    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
