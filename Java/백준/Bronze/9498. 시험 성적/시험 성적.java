import java.util.*;

class Main{
    public static void main(String[] args){
       Scanner a = new Scanner(System.in);
    	 
    	 int num = a.nextInt();
         
         switch (num/10) {
             case 10:
             case 9:
                 System.out.println("A");
                 break;
             case 8:
                 System.out.println("B");
                 break;
             case 7:
                 System.out.println("C");
                 break;
             case 6:
                 System.out.println("D");
                 break;
             default:
                 System.out.println("F");
         }
    }
}