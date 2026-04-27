import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
        int h = a.nextInt();
        int m = a.nextInt();
        
        if(m<45){
            if(h==0) {
                h=23; 
                m=m+60-45;
            }
            else {
                h=h-1; 
                m=m+60-45;
            }
        }
        else {
           m=m-45;
        }
        System.out.println(h+" "+m);
    }
}