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

    public void InteractionWithHero(); // hero ile her karakterin girdiði etkileþimler var bunlarý bu fonksiyonda gerçekleþtireceðiz.
    //örneðin 10 tane button olacak date,ask,gift... Her npc ile yapacaðýn farklý etkleþimler olacak o bütün fonksiyonlarý bunun içerisine yazacaðýz.


}
