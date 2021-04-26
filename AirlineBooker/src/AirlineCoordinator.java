/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: AirlineCoordinator.java
    Brief: manages flights and customers
*/

import java.util.Scanner;

public class AirlineCoordinator {

    private final FlightManager flightMan;
    private final CustomerManager customerMan;

    public AirlineCoordinator(int custIdSeed, int maxCustomers, int maxFlights){
        customerMan = new CustomerManager(custIdSeed, maxCustomers);
        flightMan = new FlightManager(maxFlights);
    }

    // Used to get integer inputs from the user, taken from Andrew Rudder's
    // GameShop demo
    public static int getInteger(Scanner sc,String message){
        System.out.print(message);
        while (!sc.hasNextInt())
        {
            sc.nextLine(); // clear the invalid input ...
            System.out.print(message);
        }
        return Integer.parseInt(sc.nextLine());
    }

    public boolean addFlight( int flNo, String origin, String dest, int maxSeats){
        return flightMan.addFlight(flNo, origin, dest, maxSeats);
    }

    public boolean addCustomer(String cfName, String clName, String phone){
        return customerMan.addCustomer(cfName, clName, phone);
    }

    public String flightList(){
        return flightMan.getFlightList();
    }

    public String customerList(){
        return customerMan.getCustomerList();
    }

    public boolean deleteCustomer(int cId){
        if(customerMan.customerExist(cId)){
            return customerMan.deleteCustomer(cId);
        }

        return false;
    }

    public boolean deleteFlight(int flightNo){
        if(flightMan.flightExist(flightNo)){
            return flightMan.deleteFlight(flightNo);
        }

        return false;
    }


    // Picks a flight to examine base on the flight number, will not proceed to
    // flightPassengerMenu() unless flightExist() in FlightManager class
    // returns true
    public void chooseFlight(){
        int flightNo = getInteger(new Scanner(System.in), "Enter a flight number: ");

        if(!flightMan.flightExist(flightNo))
            System.out.println("Flight does not exist...");

        else
            getFlightPassengerMenu(flightMan.getFlight(flightNo));
    }

    public void flightPassengerMenu(){
        System.out.println("Please select a choice from the menu below:\n\n" +
                "1: Add Passenger\n" +
                "2: Remove Passenger\n" +
                "3: View Passenger\n" +
                "4: Exit \n");
    }

    // Opens up a sub menu where specifics of a flight can be analyzed and
    // managed
    public void getFlightPassengerMenu(Flight flight) {
        boolean exit = false;

        do{
            flightPassengerMenu();
            System.out.print("Input: ");
            String option = new Scanner(System.in).nextLine();
            System.out.println();

            switch(option){

                case "1":
                    addPassenger(flight);
                    break;
                case "2":
                    removePassenger(flight);
                    break;
                case "3":
                    getPassengerList(flight);
                    break;
                case "4":
                    System.out.println("Returning to main menu...\n");
                    exit = true;
                    break;
                default:
                    System.out.println("Enter a valid input...\n");

            }

        }while(!exit);
    }

    // Since passengers are customers, we attach a dedicated list of customers to
    // each flight which is managed with the following three methods
    public void addPassenger(Flight flight){
        int custId = getInteger(new Scanner(System.in), "Enter a customer id: ");

        if(customerMan.customerExist(custId)){
            if(flight.addPassenger(customerMan.getCustomer(custId)))
                System.out.println("Passenger was added to flight...");
            else
                System.out.println("Passenger was not added to flight...");
        }
        else
            System.out.println("Passenger was not found...");
    }

    public void getPassengerList(Flight flight){
        System.out.println(flight.getPassengerList());
    }

    public void removePassenger(Flight flight){
        int custId = getInteger(new Scanner(System.in), "Enter a customer id: ");

        if(customerMan.customerExist(custId)){
            if(flight.removePassenger(custId))
                System.out.println("Passenger removed from flight");
            else
                System.out.println("Passenger was not removed");
        }
    }

}
