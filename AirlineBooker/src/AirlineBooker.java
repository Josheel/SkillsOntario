/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: AirlineBooker.java
    Brief: Main Program handles inputs for the main menu
*/

import java.util.Scanner;

// All methods that are to be used by the main program
// are implemented in the class AirlineBookerMethods
public class AirlineBooker extends AirlineBookerMethods {

    public static void main(String[] args) {
        String option;
        boolean exit = false;
        Scanner sc = new Scanner(System.in);
        AirlineCoordinator ac = new AirlineCoordinator(100, 200, 100);

        System.out.println("XYZ AirLines Limited");

        do{
          mainMenu();
          System.out.print("Input: ");
          option = sc.nextLine();
          System.out.println();

          switch(option){

              case "1":
                  addFlight(ac, sc);
                  break;
              case "2":
                  addCustomer(ac, sc);
                  break;
              case "3":
                  flightList(ac);
                  break;
              case "4":
                  customerList(ac);
                  break;
              case "5":
                  deleteFlight(ac, sc);
                  break;
              case "6":
                  deleteCustomer(ac, sc);
                  break;
              case "7":
                  chooseFlight(ac);
                  break;
              case "8":
                  System.out.println("Exiting Airline Booker\n");
                  exit = true;
                  break;
              default:
                  System.out.println("Enter a valid input\n");

          }

        }while(!exit);
    }
}
