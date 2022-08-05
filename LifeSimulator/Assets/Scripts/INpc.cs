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

    public void InteractionWithHero(); // hero ile her karakterin girdiği etkileşimler var bunları bu fonksiyonda gerçekleştireceğiz.
    //örneğin 10 tane button olacak date,ask,gift... Her npc ile yapacağın farklı etkleşimler olacak o bütün fonksiyonları bunun içerisine yazacağız.


}
