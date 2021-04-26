import java.util.Scanner;

public class BankSystem extends BankSystemMethods {

    static final int MAX = 100;
    
    
    public static void main(String[] args){
        BankAccountCoordinator bac = new BankAccountCoordinator(MAX);
        Scanner scanner = new Scanner(System.in);
        boolean exit = false;
        int option;
        do{
            menu();
            option = scanner.nextInt();
            scanner.nextLine();
            System.out.println();
            
            switch(option){

                case 1:
                    addAccountHolder(scanner, bac);
                    break;
                case 2:
                    getAccountHolder(scanner, bac);
                    break;
                case 3:
                    getAccountHolderList(bac);
                    break;
                case 4:
                    System.out.println("Exiting program...");
                    exit = true;
                    break;
                default:
                    System.out.println("Enter a valid input\n");
            }
        }while(!exit);

        scanner.close();
    }
}