using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    public TextMeshProUGUI BirthInfo;

    public string ulke;
    public string cities;
    public string reasonsOfBorn;
    public string myName;
    public string sex;
    public string motherName;
    public string fatherName;
    public string brotherName;
    public string sisterName;
    public int motherAge;
    public int fatherAge;
    public int sisterAge;
    public string bornMonth;
    public int bornDay;
    public int numberOfBrother;
    public int numberOfSister;
    public string motherJobs;
    public string fatherJobs;



    public string[] gender = new string[] {"female","male"};

    public string[] country = new string[] { "Turkey","Germany", "Switzerland", "Italy", "America"};

    public string[] AmericaCities = new string[] { "Atlanta", "Baltimore", "Boston", "Brooklyn", "Charleston", "New york", "Orlando", "Philadelphia", "Phoenix" };
    public string[] TurkeyCities = new string[] { "Ankara", "Istanbul", "Izmir" };
    public string[] ItalyCities = new string[] { "Cagliari", "Florence", "Genoa", "Milan", "Roma", "Pisa" };
    public string[] Switzerland = new string[] { "Basel", "Bern", "Lugano", "Zurich", "Lausanne" };
    public string[] GermanyCities = new string[] { "Dusseldorf", "Frankfurt", "Hamburg", "Hanover", "Leipzig", "Munich" };


    public string[] americaFemaleNames = new string[] { "Liam Olivia", "Noah Emma", "Oliver Charlotte", "Elijah Amelia" };
    public string[] americaMaleNames = new string[] { "William David", "Joseph Charles", "Daniel Guto", "Steven Paul" };


    public string[] turkishFemaleNames = new string[] { "Beyza Asyalý", "Ceren Gözyýldýz", "Melisa Kýzýl", "Melike Ayseli" };
    public string[] turkishMaleNames = new string[] { "Mehmet Gozupek", "Haydar Yýlmaz", "Osman karabýdýk", "Cahit Nazilli" };


    public string[] switzerlandFemaleNames = new string[] { "Emma  Flurina", "Isabella Irene", "Julia Laetitia", "Malia Lys", "Sophia Sarah" };
    public string[] switzerlandMaleNames = new string[] { "Agatha joy", "Jason Adrin", "Eric Finn", "Levi Nicolas", "Oscar Noah" };


    public string[] italyFemaleNames = new string[] { "Ginevra Alice", "Emma Giorgia", "Greta Vittoria", "Anna Martina", "Matilde Ludovica" };
    public string[] italyMaleNames = new string[] { "Lorenzo Alessandro", "Gabriele Tommaso", "Matteo Giuseppe", "Leonardo Federico", "Dario Ludovica" };


    public string[] germanyFemaleNames = new string[] { "Lena davidson", "Amelie Clara", "Mila Marie", "Sofia Lill", "Johanna Charlotte" };
    public string[] germanyMaleNames = new string[] { "Andreas Chirstian", "Frank Ernst", "Jörg Manfred", "Müller Otto", "Johanna Charlotte" };

    public string[] jobs = new string[] { "Dentist", "Registered Nurse", "Pharmacist", "Database Administrator", "Dental Hygienist", "Medical Secretary", "Lawyer", "Dental Assistant", "Architect", "Bus Driver" };

    public string[] reasons;



    //sonrdan düþündüm bu yaþ dizilerine gerek yok Random.Range yaparýz;
    //public int[] fatherAndMotherAge = new int[] { 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44 , 45, 46, 47, 48, 49, 50, 52, 54, 56 }; //Buradan rastge bir yaþ gelecek Anne ve Baba için.
    //public int[] sisterAndBrotherAge = new int[] { }


    public string[] birthdayMonth = new string[] { "Janurary", "February", "March" , "April" , "May", "June", "July", "August", "September","October", "November", "December" };    
    //Random.Range(0,28);
    //public int[] birthdayDay = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 }; // hatalý tarih vermemek için 28'e kadar yazdým

    public int[] numberOfSiblings = new int[] { 0, 1, 2, 3 };




    //Bunlarýn hepsi I was born + dizi[0] + ... þeklinde yerleþtirilecek



    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Random.Range(0, turkishFemaleNames.Length));
        ulke = country[Random.Range(0, country.Length)];
        reasonsOfBorn = reasons[Random.Range(0, reasons.Length)];
        motherAge = Random.Range(25, 58);
        fatherAge = Random.Range(35, 65);
        sex = gender[Random.Range(0, 2)];
        bornMonth = birthdayMonth[Random.Range(0, birthdayMonth.Length)];
        bornDay = Random.Range(1, 29);
        numberOfSister = Random.Range(0, 2);
        numberOfBrother = Random.Range(0, 2);
        motherJobs = jobs[Random.Range(0, jobs.Length)];
        fatherJobs = jobs[Random.Range(0, jobs.Length)];
        
        if (ulke == "Turkey")
        {
            cities = TurkeyCities[Random.Range(0,TurkeyCities.Length)];
            if(sex == "male")
            {
                myName = turkishMaleNames[Random.Range(0, turkishMaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);

            }
            else
            {
                myName = turkishFemaleNames[Random.Range(0, turkishFemaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
        }
        else if (ulke == "Germany")
        {
            cities = GermanyCities[Random.Range(0, GermanyCities.Length)];
            if (sex == "male")
            {
                myName = germanyMaleNames[Random.Range(0, germanyMaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
            else
            {
                myName = germanyFemaleNames[Random.Range(0, germanyFemaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
        }
        else if (ulke == "Switzerland")
        {
            cities = Switzerland[Random.Range(0, Switzerland.Length)];
            if (sex == "male")
            {
                myName = switzerlandMaleNames[Random.Range(0, switzerlandMaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
            else
            {
                myName = switzerlandFemaleNames[Random.Range(0, switzerlandFemaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
        }
        else if (ulke == "Italy")
        {
            cities = ItalyCities[Random.Range(0, ItalyCities.Length)];
            if (sex == "male")
            {
                myName = italyMaleNames[Random.Range(0, italyMaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
            else
            {
                myName = italyFemaleNames[Random.Range(0, italyFemaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
        }
        else if (ulke == "America")
        {
            cities = AmericaCities[Random.Range(0, AmericaCities.Length)];
            if (sex == "male")
            {
                myName = americaMaleNames[Random.Range(0, americaMaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);

            }
            else
            {
                myName = americaFemaleNames[Random.Range(0, americaFemaleNames.Length)];
                MotherCreator(ulke, myName);
                FatherCreator(ulke, myName);
            }
        }
        BirthInfo.text = "Hello my name is "+myName+". I was born a " + sex + " in " + cities + " ," + ulke +"\n"+ reasonsOfBorn + "\n" + "My birthday is "+bornDay+" "+bornMonth+"\n"+"My mother is "+motherName+"("+"age "+System.Convert.ToString(motherAge)+")"+"\n"+"My Father is "+fatherName+"("+"age "+fatherAge+")";
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void FatherCreator(string country, string myName)
    {
        if (country == "Turkey")
        {
            while (true)
            {
                fatherName = turkishMaleNames[Random.Range(0, turkishMaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }

        }
        else if (country == "Germany")
        {

            while (true)
            {
                fatherName = germanyMaleNames[Random.Range(0, germanyMaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
        else if (country == "Switzerland")
        {
            while (true)
            {
                fatherName = switzerlandMaleNames[Random.Range(0, switzerlandMaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
        else if (country == "Italy")
        {
            while (true)
            {
                fatherName = italyMaleNames[Random.Range(0, italyMaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
        else if (country == "America")
        {
            while (true)
            {
                fatherName = americaMaleNames[Random.Range(0, americaMaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
    }
    public void MotherCreator(string country , string myName)
    {
        if(country == "Turkey")
        {
            while (true)
            {
                motherName = turkishFemaleNames[Random.Range(0, turkishFemaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
            
        }
        else if(country == "Germany")
        {

            while (true)
            {
                motherName = germanyFemaleNames[Random.Range(0, germanyFemaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
        else if (country == "Switzerland")
        {
            while (true)
            {
                motherName = switzerlandFemaleNames[Random.Range(0, switzerlandFemaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
        else if (country == "Italy")
        {
            while (true)
            {
                motherName = italyFemaleNames[Random.Range(0, italyFemaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }
        else if (country == "America")
        {
            while (true)
            {
                motherName = americaFemaleNames[Random.Range(0, americaFemaleNames.Length)];
                if (motherName != myName) //isimler ayný deðilse okay bitirelim.
                {
                    break;
                }
                else //eðer aynýysa birkez daha dönsün
                {
                    continue;
                }
            }
        }

    }
}
