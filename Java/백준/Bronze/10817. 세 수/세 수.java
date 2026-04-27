import java.util.*;

class Main{
    public static void main(String[] args){
        Scanner a = new Scanner(System.in);
        
    	int num1 = a.nextInt();
    	int num2 = a.nextInt();
    	int num3 = a.nextInt();
        
        int max = num1;
        int max2;
        
        if(max<num2) {
        	max2=max;
        	max=num2;
        }
        else
        	max2=num2;
        
        if(max<num3) {
        	max2=max;
        	max=num3;
        }
        else {
        	if(max2<num3)
        		max2=num3;
        }
        
        System.out.println(max2);
        
        
    }
}