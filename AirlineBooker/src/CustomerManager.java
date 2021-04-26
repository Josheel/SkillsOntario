/*
    Author: Josheel Dhanda
    Date: March 8, 2021
    File: CustomerManager.java
    Brief: manages customers
*/

import java.util.Random;

public class CustomerManager {

    private CLNode head,tail;
    static int currentCustNo;
    private final int maxCustomers;
    private int numCustomers;

    public CustomerManager(int seed, int maxCust){
        numCustomers = seed;
        maxCustomers = maxCust;
        currentCustNo = 0;
        head = tail = null;
        seedData(seed);
    }

    public boolean addCustomer(String fN, String lN, String ph){

        CLNode newNode = new CLNode(new Customer(currentCustNo, fN, lN, ph));

        if(numCustomers < maxCustomers) {
            if (head == null) {
                head = tail = newNode;
            } else {
                tail.next = newNode;
                tail.next.prev = tail;
                tail = tail.next;
            }

            numCustomers++;
            currentCustNo++;
            return true;
        }

            return false;
    }

    public int findCustomer(int cId){
        CLNode curr = head;

        while(curr != null){
            if(curr.customer.customerId == cId)
                return curr.customer.customerId;

            curr = curr.next;
        }

        return -1;
    }

    public boolean customerExist(int cId){
        if(head == null)
            return false;

        return findCustomer(cId) == cId;
    }

    public Customer getCustomer(int cId){
        CLNode curr = head;

        if(head.customer.customerId == cId)
            return head.customer;

        else if(tail.customer.customerId == cId)
            return tail.customer;

        while(curr != null){
            if(curr.customer.customerId == cId)
                return curr.customer;

            curr = curr.next;
        }

        return null;
    }

    public boolean deleteCustomer(int cId){
        CLNode curr = head;

        if(head == null)
            return false;

        else if(numCustomers == 1){
            if(curr.customer.customerId == cId) {
                head = null;
                numCustomers--;
                return true;
            }
        }

        else if(head.customer.customerId == cId){
            head = head.next;
            head.prev = null;
            numCustomers--;
            return true;
        }

        else if(tail.customer.customerId == cId){
            tail = tail.prev;
            tail.next = null;
            numCustomers--;
            return true;
        }

        while(curr != null){
            if(curr.customer.customerId == cId){
                curr.prev.next = curr.next;
                numCustomers--;
                return true;
            }
            curr = curr.next;
        }

        return false;
    }

    public String getCustomerList(){
        CLNode curr = head;
        StringBuilder str = new StringBuilder("ID     FirstName      LastName       \t\t Phone\n");
        while(curr != null){
            str.append(curr.customer.toString());
            curr = curr.next;
        }
        return str.toString();
    }

    // Populate data structure with data
    public void seedData(int seed){

        for(int i = 0; i < seed; i ++) {
            Random random = new Random();
            String[] firstName = {"Obama", "Bill", "Andrew", "Josheel", "Michelle", "Hillary", "Ron", "Donald", "Joe",
                    "Hank", "Homer", "Austin", "Xena", "Lara", "Ashley", "Trish", "Mikasa"};

            String[] lastName = {"Saw A Unicorn!", " the Flat Earther!", "the Gold Digger!", "the Great!",
                    "the Trump Sympathizer", "the Democrat Destroyer", "Anti-Vaxxer",
                    "the Hype Beast", "Peez Freely", "the Vampire Slayer!", "D. Roosevelt"};

            addCustomer(firstName[random.nextInt(firstName.length)],
                    lastName[random.nextInt(lastName.length)],
                    "5555555555");
        }

    }
}
