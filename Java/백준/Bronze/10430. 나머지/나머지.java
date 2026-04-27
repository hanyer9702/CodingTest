import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
        int b = a.nextInt();
        int c = a.nextInt();
        int d = a.nextInt();
        
        System.out.println((b+c)%d);
        System.out.println(((b%d)+(c%d))%d);
        System.out.println((b*c)%d);
        System.out.println(((b%d)*(c%d))%d);
    }
}