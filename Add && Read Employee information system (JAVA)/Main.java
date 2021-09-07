//Add && Read Employee information system

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.Scanner;

class Employee{ 
	private String firstName;
	private String lastName;
	private int salary;
	private int rank = 0;
	
	public Employee(String firstName,String lastName,int salary, int rank){
		this.firstName = firstName;
		this.lastName = lastName;
		if (salary>=0) this.salary = salary; 
		else this.salary = 0;
		this.rank = rank;
	}
	public void setFirstName(String firstName){
		this.firstName = firstName;
	}
	public void setLastName(String lastName){
		this.lastName = lastName;
	}
	public void setSalary(int salary){
		this.salary = salary;
	}
	public void setRank(int rank){
		this.rank = rank;
	}
	public String getFirstName(){
		return firstName;
	}
	public String getLastName(){
		return lastName;
	}
	public int getSalary(){
		return salary;
	}
	public int getRank(){
		return rank;
	}
}

class Manager extends Employee{ 
	private boolean authorized; 
	public Manager(String firstName, String lastName, int salary, int rank, boolean authorized) {
		super(firstName, lastName, salary, rank);
		this.authorized = authorized;
	}
	public String getAuthorized(){
		String _check = "N";
		if(authorized) {_check = "Y";}
		return _check;
	}
}

class Staff extends Employee{ 
	private int compLeave; 
	public Staff(String firstName, String lastName, int salary, int rank, int compLeave) {
		super(firstName, lastName, salary, rank);
		this.compLeave = compLeave;
	}
	public int getCompLeave(){
		return compLeave;
	}
}


public class Main {
	
	public static void main(String[] args)   { 
		
           Scanner scanner = new Scanner(System.in);
           try {    
        	   System.out.println("What do you need to choose : ");
               System.out.println("1. Read Employee information, 2. Add Employee information");
               int y = scanner.nextInt();
               
               if(y==1) {
            	System.out.println("What do you need to choose : ");
                System.out.println("1. Read Staff information, 2. Read Manager information");
                int c = scanner.nextInt();
                
                if(c==1) {
            	FileReader fr = new FileReader("Staff.txt");
            	BufferedReader br = new BufferedReader(fr);
            	br = new BufferedReader(fr);
         	   String content = br.readLine();
               System.out.println(content);
        	   while ((content = br.readLine())!= null) 
        	   {
                   System.out.println(content);
               }
               scanner.close();
               fr.close();
               }
                
                if(c==2) {
               	FileReader fr = new FileReader("Manager.txt");
               	BufferedReader br = new BufferedReader(fr);
               	br = new BufferedReader(fr);
          	   String content = br.readLine();
                  System.out.println(content);
                  scanner.close();
                  fr.close();
                  }
               }
               
               else if (y==2) {
        		System.out.println("Please enter the Position : 1. Staff, 2. Manager");
                int Pos = scanner.nextInt();
            		if(Pos==2) 
            		{
            		FileWriter fw = new FileWriter("Manager.txt");
                    System.out.println("Please enter the First Name");
                    String Fname = scanner.next();
                    System.out.println("Please enter the Last Name");
                    String Lname = scanner.next();
                    System.out.println("Please enter the salary");
                    int salary = scanner.nextInt();
                    System.out.println("Please enter the Rank");
                    int Rank = scanner.nextInt();
                    		
            		System.out.println("Have the authorized? 1. Yes, 2. No");
            		int AuthorizedCheck = scanner.nextInt();
            		boolean Authorized = false;
            		if(AuthorizedCheck == 1) {Authorized = true;}
            		else if(AuthorizedCheck == 2) {Authorized = false;}
            		
            		Manager a = new Manager(Fname, Lname, salary, Rank, Authorized);
            		
            		 fw.write(a.getFirstName() + "\t" + "");
            		 fw.write(a.getLastName() + "\t" + "");
            		 fw.write("$" + a.getSalary() + "\t" + "");
            		 fw.write("Rank : "+a.getRank() + "\t" + "");
            		 fw.write("Authorized : "+a.getAuthorized() + "\t" + "");

            		 fw.flush();
                     System.out.println("Write Complete!");
                     fw.close();
            		}
            		 else if (Pos==1) {
                		FileWriter fw = new FileWriter("Staff.txt");
                		 
                		System.out.println("How many staff want to input?");
            			int qty = scanner.nextInt();
                		for (int i=0;i<qty;i++){
                        System.out.println("Please enter the First Name");
                        String Fname = scanner.next();
                        System.out.println("Please enter the Last Name");
                        String Lname = scanner.next();
                        System.out.println("Please enter the salary");
                        int salary = scanner.nextInt();
                        System.out.println("Please enter the Rank");
                        int Rank = scanner.nextInt();
                		
                		System.out.println("How many compLeave?");
                		int compLeave = scanner.nextInt();
                		
                		Staff a = new Staff(Fname, Lname, salary, Rank, compLeave);
                		
                		 fw.write(a.getFirstName() + "\t" + "");
                		 fw.write(a.getLastName() + "\t" + "");
                		 fw.write("$" + a.getSalary() + "\t" + "");
                		 fw.write("Rank : "+a.getRank() + "\t" + "");
                		 fw.write("CompLeave : "+a.getCompLeave() + "\t" + "");
                		 fw.write("\n");}
                		 
                		 fw.flush();
                         System.out.println("Write Complete!");
                         scanner.close();
                         fw.close();
                	}
            		
            	}
             
             
                 } catch (Exception e) {
               System.out.println("Something Error");
           }
    
       }
   }