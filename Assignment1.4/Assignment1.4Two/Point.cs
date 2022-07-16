using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4Two {




   //  Create a structure named “Point” and 2 data members: X and Y coordinate.
   //This is all we do on this page, the rest will be on the main page. 



      //  Declare 2 points: P1 and P2. Determine if P2 is to the right or left of P1 
       //  or on same axis , by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )
 

 










//Create a new 'class', change it to a struct. 
  struct Point {

   //Declare two new private int variables, x & y
    private int x;
    private int y;


 //Create a public constructor, set the parameters as int x and int y

    public Point(int x, int y) {
//use the 'this' keyword to gain access to the private variables
      this.x = x;
      this.y = y;
    }

//create our get and set statements 

    public int X {
// for the get portion we're going to use the return keyword. Get is equivalent to read-only
      get {
        return x;
      }
//for the set portion we're going to use the value keyword. Set is equivalent to writing. Having both get & set makes this read/write.
      set {
        x = value;
      }
    }
//create get & set statements for int Y
    public int Y {
      get {
        return y;
      }
      set {
        y = value;
      }
    }

  }
}