using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INpc
{
    string Relationship
    {
        get;
        set;
    }
    int Age
    {
        get;
        set;
    }
    bool isMarried
    {
        get;
        set;
    }
    string Education 
    {
        get;
        set;
    }
    string Occupation
    {
        get;
        set;
    }

    public void InteractionWithHero(); // hero ile her karakterin girdi�i etkile�imler var bunlar� bu fonksiyonda ger�ekle�tirece�iz.
    //�rne�in 10 tane button olacak date,ask,gift... Her npc ile yapaca��n farkl� etkle�imler olacak o b�t�n fonksiyonlar� bunun i�erisine yazaca��z.


}
