using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationShipUI : MonoBehaviour
{

    public GameObject InteractionWindow;
    public GameObject thisObject;
    
    public void mother()
    {
        WindowActivty();
    }
    public void father()
    {
        WindowActivty();
    }

    public void brother()
    {
        WindowActivty();
    }
    public void friends()
    {
        WindowActivty();
    }
    public void lover()
    {
        WindowActivty();
    }
    public void Animal() //sonrasýnda kedi köpek diye çeþitlendirilebilir.
    {
        WindowActivty();
    }


    public void WindowActivty()
    {
        InteractionWindow.SetActive(true);
        thisObject.SetActive(false);
    }
}
