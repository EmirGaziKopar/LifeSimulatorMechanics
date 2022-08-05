using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    public string[] gender = new string[] {"kad�n","erkek"};

    public string[] country = new string[] { "Turkish","Germany", "Switzerland", "Italy", "America"};

    public string[] americaFemaleNames = new string[] { "Liam Olivia", "Noah Emma", "Oliver Charlotte", "Elijah Amelia" };
    public string[] americaMaleNames = new string[] { "William David", "Joseph Charles", "Daniel Guto", "Steven Paul" };


    public string[] turkishFemaleNames = new string[] { "Beyza Asyal�", "Ceren G�zy�ld�z", "Melisa K�z�l", "Melike Ayseli" };
    public string[] turkishMaleNames = new string[] { "Mehmet Gozupek", "Haydar Y�lmaz", "Osman karab�d�k", "Cahit Nazilli" };


    public string[] switzerlandFemaleNames = new string[] { "Emma  Flurina", "Isabella Irene", "Julia Laetitia", "Malia Lys", "Sophia Sarah" };
    public string[] switzerlandMaleNames = new string[] { "Agatha joy", "Jason Adrin", "Eric Finn", "Levi Nicolas", "Oscar Noah" };


    public string[] italyFemaleNames = new string[] { "Ginevra Alice", "Emma Giorgia", "Greta Vittoria", "Anna Martina", "Matilde Ludovica" };
    public string[] italyMaleNames = new string[] { "Lorenzo Alessandro", "Gabriele Tommaso", "Matteo Giuseppe", "Leonardo Federico", "Dario Ludovica" };


    public string[] germanyFemaleNames = new string[] { "Lena davidson", "Amelie Clara", "Mila Marie", "Sofia Lill", "Johanna Charlotte" };
    public string[] germanyMaleNames = new string[] { "Andreas Chirstian", "Frank Ernst", "J�rg Manfred", "M�ller Otto", "Johanna Charlotte" };

    public string[] jobs = new string[] { "Dentist", "Registered Nurse", "Pharmacist", "Database Administrator", "Dental Hygienist", "Medical Secretary", "Lawyer", "Dental Assistant", "Architect", "Bus Driver" };


    //sonrdan d���nd�m bu ya� dizilerine gerek yok Random.Range yapar�z;
    public int[] fatherAndMotherAge = new int[] { 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44 , 45, 46, 47, 48, 49, 50, 52, 54, 56 }; //Buradan rastge bir ya� gelecek Anne ve Baba i�in.
    //public int[] sisterAndBrotherAge = new int[] { }


    public string[] birthdayMonth = new string[] { "Janurary", "February", "March" , "April" , "April" , "May", "June", "July", "August", "September","October", "November", "December" };    
    public int[] birthdayDay = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 }; // hatal� tarih vermemek i�in 28'e kadar yazd�m

    public int[] numberOfSiblings = new int[] { 0, 1, 2, 3 };


    //Bunlar�n hepsi I was born + dizi[0] + ... �eklinde yerle�tirilecek



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
