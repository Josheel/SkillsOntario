/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: FlightManager.java
    Brief: manages flights, virtually identical to CustomerManager.java
*/

public class FlightManager {
    FLNode head,tail;
    int maxFlights;
    int numFlights;

    public FlightManager(int maxFlt){
        maxFlights = maxFlt;
        numFlights = 0;
    }

    public boolean addFlight(int flNo, String or, String de, int mS){

        if(flightExist(flNo))
            return false;

        FLNode newNode = new FLNode(new Flight(flNo, or, de, mS));

        if(numFlights != maxFlights) {
            if (head == null) {
                head = tail = newNode;
            } else {
                tail.next = newNode;
                tail.next.prev = tail;
                tail = tail.next;
            }

            numFlights++;
            return true;
        }

        return false;
    }

    private int findFlight(int flightNo){

        FLNode curr = head;

        while(curr != null){

            if(curr.flight.flightNumber == flightNo)
                return curr.flight.flightNumber;
            curr = curr.next;

        }

        return -1;
    }

    public boolean flightExist(int flightNo){

        if(head == null)
            return false;

        return findFlight(flightNo) == flightNo;
    }

    public Flight getFlight(int flightNo){
        FLNode curr = head;

        if(head.flight.flightNumber == flightNo)
            return head.flight;

        else if(tail.flight.flightNumber == flightNo)
            return tail.flight;

        while(curr != null){
            if(curr.flight.flightNumber == flightNo)
                return curr.flight;

            curr = curr.next;
        }

        return null;
    }

    public boolean deleteFlight(int flightNo){
        FLNode curr = head;

        if(head == null)
            return false;

        else if(numFlights == 1){
            if(curr.flight.flightNumber == flightNo) {
                head = null;
                numFlights--;
                return true;
            }
        }

        else if(head.flight.flightNumber == flightNo){
            head = head.next;
            head.prev = null;
            numFlights--;
            return true;
        }

        else if(tail.flight.flightNumber == flightNo){
            tail = tail.prev;
            tail.next = null;
            numFlights--;
            return true;
        }

        while(curr != null){
            if(curr.flight.flightNumber == flightNo){
                curr.prev.next = curr.next;
                numFlights--;
                return true;
            }
            curr = curr.next;
        }

        return false;
    }

    public String getFlightList(){

        FLNode curr = head;
        StringBuilder str = new StringBuilder("Flight List:\n");
        while(curr != null){
            str.append(curr.flight.toString());
            curr = curr.next;
        }
        return str.toString();
    }
}
