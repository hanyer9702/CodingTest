import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
        int b = a.nextInt();
       
        for(int i=1; i<10; i++){
            System.out.println(b+" * "+i+" = "+i*b);
        }
    }
}