/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: Customer.java
    Brief: Customer/Passenger class. Can possibly create a customer interface
           to increase usability and identify between different types of
           customers
*/

public class Customer {

    int customerId;
    String firstName;
    String lastName;
    String phone;

    public Customer(int id, String fn, String ln, String ph){
        customerId = id;
        firstName = fn;
        lastName = ln;
        phone = ph;
    }

    public String toString(){
        return rightPadding(Integer.toString(customerId), 7) +
                rightPadding(firstName, 15) +
                rightPadding(lastName, 23) +
                rightPadding(phone, 12) + "\n";
    }

    public static String rightPadding(String str, int num) {
        return String.format("%1$-" + num + "s", str);
    }

}
