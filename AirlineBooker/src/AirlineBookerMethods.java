/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: AirlineBookerMethods.java
    Brief: method implementations necessary for main class
*/

import java.util.Scanner;

public class AirlineBookerMethods {

    // Maximum lengths for firstname, lastname, and cities
    static int flNameLength = 14;
    static int cityNameLength = 14;

    public static void mainMenu(){
        System.out.println("Please select a choice from the menu below:\n\n" +
                "1: Add Flight\n" +
                "2: Add Customer\n" +
                "3: View Flights\n" +
                "4: View Customers\n" +
                "5: Delete Flight\n" +
                "6: Delete Customer\n" +
                "7: Flight Passenger Menu \n" +
                "8: Exit \n");
    }

    // Used to get string inputs from the user, taken from Andrew Rudder's
    // GameShop demo
    public static String getString(Scanner sc, String message){
        System.out.print(message);
        while (!sc.hasNextLine())
        {
            sc.nextLine(); // clear the invalid input ...
            System.out.print(message);
        }
        return sc.nextLine();
    }

    // Same as getString(), except for integers
    public static int getInteger(Scanner sc,String message){
        System.out.print(message);
        while (!sc.hasNextInt())
        {
            sc.nextLine(); // clear the invalid input ...
            System.out.print(message);
        }
        return Integer.parseInt(sc.nextLine());
    }

    // Adds a customer to the main data structure which holds a list of
    // all customers
    public static void addCustomer(AirlineCoordinator ac, Scanner sc){
        System.out.println("----------Add Customer----------");

        // Retrieve data that meets the length specifications for each
        // identifying category of any new customer
        String fn = getString(sc, "First Name: ");
        while(fn.length() < 1 || fn.length() > flNameLength){
            System.out.println("Please enter a name 14 characters or less. \n");
            fn = getString(sc, "First Name: ");
        }

        String ln = getString(sc, "Last Name: ");
        while(ln.length() < 1 || ln.length() > flNameLength){
            System.out.println("Please enter a name 14 characters or less. \n");
            ln = getString(sc, "Last Name: ");
        }

        String ph = getString(sc, "Phone Number:");
        while(ph.length() != 10){
            System.out.println("Phone number must be 10 digits long, try again.\n");
            ph = getString(sc, "Phone Number:");
        }

        // Manually hyphenate the phone number
        ph = ph.substring(0, 2) + '-' + ph.substring(3, 5) + '-' + ph.substring(6,9);

        // Since every customer is assigned a unique identifier, the only reason
        // that adding a customer would fail is if the database is full
        if(ac.addCustomer(fn, ln, ph)){
            System.out.println("Customer successfully added..\n");
        }else{
            System.out.println("Custer was not added..\n");
        }
    }

    public static void deleteCustomer(AirlineCoordinator ac, Scanner sc){
        int custId =  getInteger(sc,"Please enter a customer id to delete: ");

        if(!ac.deleteCustomer(custId)){
            System.out.println("Customer with id " + custId + " not found...\n");
        }else{
            System.out.println("Customer with id " + custId + " deleted...\n");
        }
    }

    public static void customerList(AirlineCoordinator ac){
        System.out.println(ac.customerList());
    }

    // Works the same as addCustomer(), just collects different data
    public static void addFlight(AirlineCoordinator ac, Scanner sc){
        System.out.println("-----------Add Flight-----------");

        int flNo = getInteger(sc, "Please enter the flight number: ");
        int maxSeats = getInteger(sc, "Please enter the maximum number of seats: ");

        String origin = getString(sc, "Please Enter the port of origin: ");
        while(origin.length() < 1 || origin.length() > cityNameLength){
            System.out.println("Please enter a name " + cityNameLength+ " characters or less. \n");
            origin = getString(sc, "Please Enter the port of origin: ");
        }

        String destination = getString(sc, "Please enter the destination port: ");
        while(destination.length() < 1 || destination.length() > cityNameLength){
            System.out.println("Please enter a name " + cityNameLength+ " characters or less. \n");
            destination= getString(sc, "Please enter the destination port: ");
        }

        if(ac.addFlight(flNo, origin, destination, maxSeats)){
            System.out.println("Flight successfully added..\n");
        }else{
            System.out.println("Custer was not added..\n");
        }

    }

    public static void deleteFlight(AirlineCoordinator ac, Scanner sc){
        int flightNo =  getInteger(sc,"Please enter a flight id to delete: ");

        // deleteFlight() returns false if a flight does not exist
        if(!ac.deleteFlight(flightNo)){
            System.out.println("Customer with id " + flightNo + " not found...\n");
        }else{
            System.out.println("Customer with id " + flightNo + " deleted...\n");
        }
    }

    public static void flightList(AirlineCoordinator ac){
        System.out.println(ac.flightList());
    }

    public static void chooseFlight(AirlineCoordinator ac){
        ac.chooseFlight();
    }
}
