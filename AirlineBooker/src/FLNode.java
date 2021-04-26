/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: FLNode.java
    Brief: Node to be used to create list of flights
*/

public class FLNode {

    Flight flight;
    FLNode next,prev;

    public FLNode(Flight fl){
        flight = fl;
        next = prev = null;
    }
}
