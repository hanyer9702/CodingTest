import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
        int b = a.nextInt();
        int c = a.nextInt();
        
        System.out.println(b*(c%10));
        System.out.println(b*(c/10%10));
        System.out.println(b*(c/100%10));
        System.out.println(b*c);
        
    }
}