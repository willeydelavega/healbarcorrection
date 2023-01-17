using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Camera _camera;
    Vector3 mousePos;
    
    Vector3 offset;
    private void Start()
    {
        _camera = Camera.main;

    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Vector3 mouseWorldPos = GetMousePositionInWorld();

        // On calcule l'offset pour éviter que l'objet ne snap au centre de la souris
        offset = transform.position - mouseWorldPos;

        //mousePos = Input.mousePosition - GetObjectPositionOnScreen();
    }

    private void OnMouseDrag()
    {
        Vector3 mouseWorldPos = GetMousePositionInWorld();

        // On déplace l'objet à l'endroit de la souris sans oublier de rajouter l'offset
        transform.position = mouseWorldPos + offset;
    }

    private Vector3 GetMousePositionInWorld()
    {
        // On veut récupérer la profondeur de l'objet par rapport à la caméra
        // Donc on récupère les coordonnées locales de l'objet dans le référentiel de la caméra
        Vector3 transformInCameraSpace = _camera.transform.InverseTransformPoint(transform.position);
        
        // On transforme le point de la souris en un point du monde (en fixant la profondeur à la profondeur de l'objet)
        Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transformInCameraSpace.z);
        Vector3 mouseWorldPos = _camera.ScreenToWorldPoint(screenPoint);
        
        // On retourne le point de la souris
        return mouseWorldPos;
    }

    //Vector3 GetObjectPositionOnScreen()
    //{
        //return _camera.WorldToScreenPoint(transform.position);
    //}
}
