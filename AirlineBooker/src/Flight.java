/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: Flight.java
    Brief: Contains unique flight information, behaves like CustomerManager.java
           as each flight contains a dedicated list of customers(passengers).
           May be possible to have Flight extend CustomerManager.java since it Flight
           only has two unique method implementation.
*/

public class Flight{

    private CLNode head,tail;
    int flightNumber;
    String origin;
    String destination;
    int maxSeats;
    int numPassengers;

    public Flight(int flNo, String or, String det, int mSeats){
        head = tail = null;
        flightNumber = flNo;
        origin = or;
        destination = det;
        maxSeats = mSeats;
        numPassengers = 0;
    }

    public boolean addPassenger(Customer customer){
        CLNode newNode = new CLNode(customer);

        if(numPassengers < maxSeats) {
            if (head == null) {
                head = tail = newNode;
            } else {
                tail.next = newNode;
                tail.next.prev = tail;
                tail = tail.next;
            }

            numPassengers++;
            return true;
        }

        return false;
    }

    private int findPassenger(int custId){
        CLNode curr = head;

        while(curr != null){
            if(curr.customer.customerId == custId)
                return curr.customer.customerId;

            curr = curr.next;
        }

        return -1;
    }

    public boolean removePassenger(int cId){
        CLNode curr = head;

        if(findPassenger(cId) == cId){
            if(head == null)
                return false;

            else if(numPassengers == 1){
                if(curr.customer.customerId == cId) {
                    head = null;
                    numPassengers--;
                    return true;
                }
            }

            else if(head.customer.customerId == cId){
                head = head.next;
                head.prev = null;
                numPassengers--;
                return true;
            }

            else if(tail.customer.customerId == cId){
                tail = tail.prev;
                tail.next = null;
                numPassengers--;
                return true;
            }

            while(curr != null){
                if(curr.customer.customerId == cId){
                    curr.prev.next = curr.next;
                    numPassengers--;
                    return true;
                }
                curr = curr.next;
            }
        }

        return false;
    }

    public String getPassengerList(){
        CLNode curr = head;
        StringBuilder str = new StringBuilder("ID     FirstName      LastName       Phone\n");

        while(curr != null){
            str.append(curr.customer.toString());
            curr = curr.next;
        }

        return str.toString();
    }

    public String toString(){
        return flightNumber + " from " + origin + " to " + destination + "\n";
    }

}
