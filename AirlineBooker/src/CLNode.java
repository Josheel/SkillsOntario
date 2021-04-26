/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: CLNode.java
    Brief: Node to create list of customers/passengers
*/

public class CLNode {

    Customer customer;
    CLNode prev;
    CLNode next;

    public CLNode(Customer cust){
        customer = cust;
        prev = next = null;
    }
}
