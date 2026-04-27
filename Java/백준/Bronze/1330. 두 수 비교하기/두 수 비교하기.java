import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
        int num1 = a.nextInt();
        int num2 = a.nextInt();
        
        if(num1>num2){
            System.out.println(">");
        }
        else if(num1<num2){
            System.out.println("<");
        }
        else{
            System.out.println("==");
        }
    }
}