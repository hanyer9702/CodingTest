import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
        int num = a.nextInt();
        
        if(num%4==0)
        {
            if((num%100!=0)||(num%400==0))
                System.out.println("1");
            else
                System.out.println("0");
        }
        else
                System.out.println("0");
    }
}