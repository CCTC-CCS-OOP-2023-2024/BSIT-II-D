/*may this comment finds u well haha, this program will be my Final project for OOP 
the said pogram will first get your name and the specific pass for you to 'log in'
you can use Name: Vanni Pass: buns or your can use sir kenneth's Name: Kenneth and Pass: ken
orrrr you can make your own, put your cursor on Line (40) and ctrl+alt+down and you can edit ur own
also u only got 3 attemps to 'login' or the system will stop! 

Fun Facts! 
>The products consist of Menu, Dessert, and Drink
>Anything you ordered will be stored on ur receipt
>When ordering you can check your receipt anytime u want
>This is a 430 line of Codes! (including the comments lol)
>maka "pasar unta" cutie! 
*/
using System;
using System.Collections.Generic;
namespace RestoBarEmployeeByVanniTanutan {
    
public class HelloWorld
{
    static List<string> recept = new List<string>();
    static int amount = 0,  money=0, change=0; 
public static void Main(string[] args)
    {
        
        barbilat();
    }

static void barbilat(){
      string name, pass;
      int trial =1; 
      Console.WriteLine("***You only have 3 attempts before the program stop***");
      do{
          //names and passwords
      Console.Write("Name: ");
      name = Console.ReadLine(); 
      Console.Write("\n Password: ");
      pass = Console.ReadLine();
      //names and pass should not contain spaces
      if (  name == "Vanni" && pass == "buns" ||
            name == "XXXX" && pass == "xxxx" || 
            name == "Kenneth" && pass == "ken"  ){
          //calling home
          home();
          break;
      }
      else { 
          //for exeding attempts
         if (trial == 3){
             Console.WriteLine("Incorrect Name and/or Pass. Try Again."); 
             Console.WriteLine("Trial Attemps exceded,  restart the program to use again!");
             trial++;
         }else{
             //for retrying incorrect pass and/or name
             Console.WriteLine("Incorrect Name and/or Pass. Try Again."); 
             trial++; 
         }
          
           }
  }while(trial!=4); 
}
//home
static void home(){
    int cHome; 
    while (true){
        //force exit when entering 6
Console.WriteLine("\n --------Resto Bar-----------");
Console.WriteLine("\t 1 > Menu ");
Console.WriteLine("\t 2 > Drinks ");
Console.WriteLine("\t 3 > Dessert ");
Console.WriteLine("\t 4 > Check receipt ");
Console.WriteLine("\t 5 > Exit/Bill ");
Console.WriteLine("-----------------------------");
Console.Write("Enter choice: ");
        cHome = Convert.ToInt32(Console.ReadLine());
        switch (cHome){
            case 1:
                menu();
                break;
            case 2:
                drinks(); 
                break; 
            case 3: 
                dessert();
                break; 
            case 4:
                resibo(recept); 
                break;
            case 5:
                bill(); 
                break;
        }
        //force exit
        if (cHome == 6){
            break;
        }
    }
}
//menu
static void menu(){
    string mchoice;
    int q,b,be,bb,hh,ad,ch,pi; //initializing items
    do{
Console.WriteLine ("-----------------\tMenu\t-------------------");
Console.WriteLine ("\tM1\t$4 Sisig\t\tM5\t$3 Halang-halang");
Console.WriteLine ("\tM2\t$5 Bulalo\t\tM6\t$3 Adobo");
Console.WriteLine ("\tM3\t$2 Betamax\t\tM7\t$6 Chicharon");
Console.WriteLine ("\tM4\t$2 BBQ\t\t\tM8\t$2 Pinakbet");
Console.WriteLine ("\t\t\tPress 1 to go Back");
Console.WriteLine ("\t\t\tPress 2 to Check Bill");
Console.WriteLine ("\t\t\tPress 3 to Check Receipt");
Console.WriteLine ("-----------------------------------------------");
Console.Write("Enter choice: ");
mchoice = Console.ReadLine();
switch(mchoice){
    case "1":
        home();
        break;
    case "2":
        bill();
        break;
    case "3":
        resibo(recept);
        break;
    case "M1":
        Console.Write("Enter quantity: ");
        q = Convert.ToInt32(Console.ReadLine());
        amount = amount+(q*4);
        int qu = q*4; 
        Console.WriteLine($"You added {q} Sisig in your Bill worth: ${qu}\n");
        recept.Add($"{q} Sisig - ${qu}");
        bill();
        break; 
    case "M2":
        Console.Write("Enter quantity: ");
        b = Convert.ToInt32(Console.ReadLine());
        amount = amount+(b*5);
        int bu = b*5; 
        Console.WriteLine($"You added {b} Bulalo in your Bill worth: ${bu}\n");
        recept.Add($"{b} Bulalo - ${bu}");
        bill();
        break; 
    case "M3":
        Console.Write("Enter quantity: ");
        be = Convert.ToInt32(Console.ReadLine());
        amount = amount+(be*2);
        int beu = be*2; 
        Console.WriteLine($"You added {be} Betamax in your Bill worth: ${beu}\n");
        recept.Add($"{be} Betamax - ${beu}");
        bill();
        break; 
    case "M4":
        Console.Write("Enter quantity: ");
        bb = Convert.ToInt32(Console.ReadLine());
        amount = amount+(bb*2);
        int bbu = bb*2; 
        Console.WriteLine($"You added {bb} BBQ in your Bill worth: ${bbu}\n");
        recept.Add($"{bb} BBQ - ${bbu}");
        bill();
        break; 
    case "M5":
        Console.Write("Enter quantity: ");
        hh = Convert.ToInt32(Console.ReadLine());
        amount = amount+(hh*3);
        int hhu = hh*3; 
        Console.WriteLine($"You added {hh} Halang-halang in your Bill worth: ${hhu}\n");
        recept.Add($"{hh} Halang-halang - ${hhu}");
        bill();
        break; 
    case "M6":
        Console.Write("Enter quantity: ");
        ad = Convert.ToInt32(Console.ReadLine());
        amount = amount+(ad*3);
        int adu = ad*3; 
        Console.WriteLine($"You added {ad} Adobo in your Bill worth: ${adu}\n");
        recept.Add($"{ad} Adobo - ${adu}");
        bill();
        break; 
    case "M7":
        Console.Write("Enter quantity: ");
        ch = Convert.ToInt32(Console.ReadLine());
        amount = amount+(ch*6);
        int chu = ch*6; 
        Console.WriteLine($"You added {ch} Chicharon in your Bill worth: ${chu}\n");
        recept.Add($"{ch} Chicharon - ${chu}");
        bill();
        break; 
    case "M8":
        Console.Write("Enter quantity: ");
        pi = Convert.ToInt32(Console.ReadLine());
        amount = amount+(pi*2);
        int piu = pi*2; 
        Console.WriteLine($"You added {pi} Pinakbet in your Bill worth: ${piu}\n");
        recept.Add($"{pi} Pinakbet - ${piu}");
        bill();
        break; 
    
}
}while(true);
}
//drinks
static void drinks(){
     do{
         int c, s, p , r, pe, w; //initializing items
Console.WriteLine ("-----------------\tDrinks\t----------------");
Console.WriteLine ("\tD1\t$2 Coke\t\t\tD4\t$1 Royal");
Console.WriteLine ("\tD2\t$2 Sprite\t\tD5\t$2 Pepsi");
Console.WriteLine ("\tD3\t$4 Prime\t\tD6\t$1 Water");
Console.WriteLine ("\t\t\tPress 1 to go Back");
Console.WriteLine ("\t\t\tPress 2 to Check Bill");
Console.WriteLine ("\t\t\tPress 3 to Check Receipt");
Console.WriteLine ("-------------------------------------------");
Console.Write("Enter choice: ");
    string dchoice; 
    dchoice = Console.ReadLine();
switch(dchoice){
    case "1":
        home();
        break;
    case "2":
        bill();
        break;
    case "3":
        resibo(recept);
        break;
    case "D1":
        Console.Write("Enter quantity: ");
        c = Convert.ToInt32(Console.ReadLine());
        amount = amount+(c*2);
        int cu = c*2; 
        Console.WriteLine($"You added {c} Coke in your Bill worth: ${cu}\n");
        recept.Add($"{c} Coke - ${cu}");
        bill();
        break;
    case "D2":
        Console.Write("Enter quantity: ");
        s = Convert.ToInt32(Console.ReadLine());
        amount = amount+(s*2);
        int su = s*2; 
        Console.WriteLine($"You added {s} Sprite in your Bill worth: ${su}\n");
        recept.Add($"{s} Sprite - ${su}");
        bill();
        break;
    case "D3":
        Console.Write("Enter quantity: ");
        p = Convert.ToInt32(Console.ReadLine());
        amount = amount+(p*4);
        int pu = p*4; 
        Console.WriteLine($"You added {p} Prime in your Bill worth: ${pu}\n");
        recept.Add($"{p} Prime - ${pu}");
        bill();
        break;
    case "D4":
        Console.Write("Enter quantity: ");
        r = Convert.ToInt32(Console.ReadLine());
        amount = amount+(r*1);
        int ru = r*1; 
        Console.WriteLine($"You added {r} Royal in your Bill worth: ${ru}\n");
        recept.Add($"{r} Royal - ${ru}");
        bill();
        break;
    case "D5":
        Console.Write("Enter quantity: ");
        pe = Convert.ToInt32(Console.ReadLine());
        amount = amount+(pe*2);
        int peu = pe*2; 
        Console.WriteLine($"You added {pe} Pepsi in your Bill worth: ${peu}\n");
        recept.Add($"{pe} Pepsi - ${peu}");
        bill();
        break;
    case "D6":
        Console.Write("Enter quantity: ");
        w = Convert.ToInt32(Console.ReadLine());
        amount = amount+(w*1);
        int wu = w*1; 
        Console.WriteLine($"You added {w} Water in your Bill worth: ${wu}\n");
        recept.Add($"{w} Water - ${wu}");
        bill();
        break;
}
}while(true);
}
//dessert
static void dessert(){
     do {
         int l, mf, ms, bs, ic, y, c, m;//initializing items
Console.WriteLine ("-----------------\tDessert\t------------------");
Console.WriteLine ("\tS1\t$4 Leche Flan\t\tS5\t$4 Ice Cream");
Console.WriteLine ("\tS2\t$3 Mango Float\t\tS6\t$5 Yogurt");
Console.WriteLine ("\tS3\t$2 Mango Shake\t\tS7\t$3 Cake");
Console.WriteLine ("\tS4\t$2 Buko Shake\t\tS8\t$2 Maja");
Console.WriteLine ("\t\t\tPress 1 to go Back");
Console.WriteLine ("\t\t\tPress 2 to Check Bill");
Console.WriteLine ("\t\t\tPress 3 to Check Receipt ");
Console.WriteLine ("---------------------------------------------");
Console.Write("Enter choice: ");
string choice; 
choice = Console.ReadLine();
switch(choice){
    case "1":
        home();
        break;
    case "2":
        bill();
        break;
    case "3":
        resibo(recept);
        break;
    case "S1":
        Console.Write("Enter quantity: ");
        l = Convert.ToInt32(Console.ReadLine());
        amount = amount+(l*4);
        int lu = l*4; 
        Console.WriteLine($"You added {l} Leche Flan in your Bill worth: ${lu}\n");
        recept.Add($"{l} Leche Flan - ${lu}");
        bill();
        break;
    case "S2":
        Console.Write("Enter quantity: ");
        mf = Convert.ToInt32(Console.ReadLine());
        amount = amount+(mf*3);
        int mfu = mf*3; 
        Console.WriteLine($"You added {mf} Mango Float in your Bill worth: ${mfu}\n");
        recept.Add($"{mf} Mango Float - ${mfu}");
        bill();
        break;
    case "S3":
        Console.Write("Enter quantity: ");
        ms = Convert.ToInt32(Console.ReadLine());
        amount = amount+(ms*2);
        int msu = ms*2; 
        Console.WriteLine($"You added {ms} Mango Shake in your Bill worth: ${msu}\n");
        recept.Add($"{ms} Mango Shake - ${msu}");
        bill();
        break;
    case "S4":
        Console.Write("Enter quantity: ");
        bs = Convert.ToInt32(Console.ReadLine());
        amount = amount+(bs*2);
        int bsu = bs*2; 
        Console.WriteLine($"You added {bs} Buko Shake in your Bill worth: ${bsu}\n");
        recept.Add($"{bs} Buko Shake - ${bsu}");
        bill();
        break;
    case "S5":
        Console.Write("Enter quantity: ");
        ic = Convert.ToInt32(Console.ReadLine());
        amount = amount+(ic*4);
        int icu = ic*4; 
        Console.WriteLine($"You added {ic} Ice Cream in your Bill worth: ${icu}\n");
        recept.Add($"{ic} Ice Cream - ${icu}");
        bill();
        break;
    case "S6":
        Console.Write("Enter quantity: ");
        y = Convert.ToInt32(Console.ReadLine());
        amount = amount+(y*5);
        int yu = y*5; 
        Console.WriteLine($"You added {y} Yogurt in your Bill worth: ${yu}\n");
        recept.Add($"{y} Yogurt - ${yu}");
        bill();
        break;
    case "S7":
        Console.Write("Enter quantity: ");
        c = Convert.ToInt32(Console.ReadLine());
        amount = amount+(c*3);
        int cu = c*3; 
        Console.WriteLine($"You added {c} Cake in your Bill worth: ${cu}\n");
        recept.Add($"{c} Cake - ${cu}");
        bill();
        break;
    case "S8":
        Console.Write("Enter quantity: ");
        m = Convert.ToInt32(Console.ReadLine());
        amount = amount+(m*2);
        int mu = m*2; 
        Console.WriteLine($"You added {m} Maja in your Bill worth: ${mu}\n");
        recept.Add($"{m} Maja - ${mu}");
        bill();
        break;
    
}
     }while(true);
}
//bill
static void bill(){
     Console.WriteLine($"\n Your total bill is ${amount}");
     Console.WriteLine("Do you want to order more?");
     Console.WriteLine("\t 1 > Yes \t 2 > No ");
     Console.Write("Enter choice: ");
     string ys = Console.ReadLine();
     if (ys == "1"){
         home(); 
     }else{
         //adding last part of list
          
         resibo(recept);
         ch(); //the reciept
         Console.WriteLine($"Thank you for Purchasing at Resto Bar Hope to see you again!");
         Environment.Exit(0);// exit
     }
     
}
//helping methos
static void resibo(List <string> content){
Console.WriteLine("Summary of your order is: ");
    for (int x  = 0; x < content.Count ; x++ ){
        //showing the list/receipt
        Console.WriteLine($"-\t{content[x]}");
    }
Console.WriteLine("***Nothing Follows***");
Console.WriteLine($"Total: ${amount}");
}
//paying
static void ch(){
    //getting the amount from the costumer
Console.Write("Enter money on hand: $");
money = Convert.ToInt32(Console.ReadLine());
//if else if the amount is just right
if (money >= amount){
Console.WriteLine("Your change is: $"+Math.Abs(pay(money,amount)));
} else {
    Console.WriteLine("insufficient Balance");
    ch();
}
}
//change
static int pay(int mon, int amo){
    change = amo - mon;
    return change; 
    //eme lang to para lang maka returning values haha

}
//last brackets   
}
}


